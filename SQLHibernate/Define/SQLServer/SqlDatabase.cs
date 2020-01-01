using SQLHibernate.Define.Inteface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.SQLServer
{
    class SqlDatabase : IDatabase
    {
        public static byte DecimalPrecision = 18;
        public static byte DecimalScale = 0;

        private SqlConnection connection;
        private SqlTransaction transaction;
        private bool closeConnection = false;

        public SqlDatabase(string connectionStr)
        {
            connection = new SqlConnection(connectionStr);
            if(connection.State != ConnectionState.Open)
            {
                connection.Open();
                closeConnection = true;
            }
        }
        public bool InTransaction {
            get {
                return transaction != null;
            }
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Prepare(SqlCommand command, int paramCount)
        {
            if (paramCount < 0)
                throw new ArgumentOutOfRangeException(
                        "parameter count must be positive or zero", "paramCount");
            
            for (int i = 0; i < paramCount; ++i)
            {
                SqlParameter p = new SqlParameter();
                p.ParameterName = "@p" + i.ToString();
                command.Parameters.Add(p);
            }
        }

        public SqlDataReader ExecuteReader(string sql, object[] parameters)
        {
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.Connection = this.connection;
                command.Transaction = this.transaction;
                command.CommandText = sql;

                int paramCount = (parameters != null) ? parameters.Length : 0;
                Prepare(command, paramCount);
                if (parameters != null)
                {
                    int i = 0;
                    foreach (object p in parameters)
                    {
                        SetParamValue(command.Parameters[i++], p);
                    }
                }

                SqlDataReader reader = command.ExecuteReader();
                //Commit();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecuteNonReader(string sql, object[] parameters)
        {
            int ret = 0;
            try
            {
                BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Connection = this.connection;
                command.Transaction = this.transaction;
                command.CommandText = sql;
                int paramCount = (parameters != null) ? parameters.Length : 0;
                Prepare(command, paramCount);
                
                if (parameters != null)
                {
                    int i = 0;
                    foreach (object p in parameters)
                    {
                        SetParamValue(command.Parameters[i++], p);
                    }
                }


                ret = command.ExecuteNonQuery();

                Commit();

                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
        }

        public void Commit()
        {
            if(transaction != null)
            {
                transaction.Commit();
                transaction = null;
            }
        }

        public void Dispose()
        {
            Close();
        }

        public void Close()
        {
            if (connection == null)
                return;
            Rollback();
            if (closeConnection && connection.State != ConnectionState.Closed)
                connection.Close();
            connection = null;
        }

        public void Rollback()
        {
            if(transaction != null)
            {
                transaction.Rollback();
                transaction = null;
            }
        }

        public ITable Table(Type type)
        {
            return new SqlTable(this, type);
        }

        public ITable Table<T>()
        {
            return Table(typeof(T));
        }

        public string QuoteName(string name)
        {
            return "[" + name + "]";
        }

        void SetParamValue(SqlParameter p, object value)
        {
            if (value == null)
            {
                p.Value = DBNull.Value;
                p.SqlDbType = SqlDbType.NVarChar;
                p.Size = 0;
                return;
            }
            // HACK: Support setting binary fields to NULL.
            // Without this, Sql Server cannot implicitly convert nvarchar to varbinary.
            if (value == BinaryNull)
            {
                p.Value = DBNull.Value;
                p.SqlDbType = SqlDbType.VarBinary;
                p.Size = 0;
                return;
            }

            p.Value = value;
            Type type = value.GetType();
            if (type == StringType)
            {
                p.SqlDbType = SqlDbType.NVarChar;
                p.Size = ((string)value).Length;
            }
            else if (type == IntType || type == UIntType)
            {
                p.SqlDbType = SqlDbType.Int;
            }
            else if (type == BoolType)
            {
                p.SqlDbType = SqlDbType.Bit;
            }
            else if (type == DateTimeType)
            {
                p.SqlDbType = SqlDbType.DateTime;
            }
            else if (type == DecimalType)
            {
                p.SqlDbType = SqlDbType.Decimal;
                p.Precision = SqlDatabase.DecimalPrecision;
                p.Scale = SqlDatabase.DecimalScale;
            }
            else if (type == LongType || type == ULongType)
            {
                p.SqlDbType = SqlDbType.BigInt;
            }
            else if (type == GuidType)
            {
                p.SqlDbType = SqlDbType.UniqueIdentifier;
            }
            else if (type == ByteType || type == SByteType)
            {
                p.SqlDbType = SqlDbType.TinyInt;
            }
            else if (type == CharType)
            {
                p.SqlDbType = SqlDbType.Char;
                p.Size = 1;
            }
            else if (type == ShortType || type == UShortType)
            {
                p.SqlDbType = SqlDbType.SmallInt;
            }
            else if (type == FloatType)
            {
                p.SqlDbType = SqlDbType.Real;
            }
            else if (type == DoubleType)
            {
                p.SqlDbType = SqlDbType.Float;
            }
            else if (type == ByteArrayType)
            {
                p.SqlDbType = SqlDbType.VarBinary;
                p.Size = ((byte[])value).Length;
            }
        }

        public static readonly Type IntType = typeof(int);
        public static readonly Type UIntType = typeof(uint);
        public static readonly Type LongType = typeof(long);
        public static readonly Type ULongType = typeof(ulong);
        public static readonly Type ByteType = typeof(byte);
        public static readonly Type SByteType = typeof(sbyte);
        public static readonly Type ShortType = typeof(short);
        public static readonly Type UShortType = typeof(ushort);
        public static readonly Type DecimalType = typeof(decimal);
        public static readonly Type FloatType = typeof(float);
        public static readonly Type DoubleType = typeof(double);
        public static readonly Type BoolType = typeof(bool);
        public static readonly Type StringType = typeof(string);
        public static readonly Type CharType = typeof(char);
        public static readonly Type DateTimeType = typeof(DateTime);
        public static readonly Type GuidType = typeof(Guid);
        public static readonly Type ByteArrayType = typeof(byte[]);

        public static readonly object BinaryNull = new object();
    }
}
