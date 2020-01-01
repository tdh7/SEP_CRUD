using SQLHibernate.Define.HAttribute;
using SQLHibernate.Define.HDefinition;
using SQLHibernate.Define.Inteface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.SQLServer
{
    class SqlTable : ITable
    {
        private SqlDatabase database;
        private Type clazz;
        private string name;
        private string schema;
        private SqlField[] fields;

        public SqlTable(SqlDatabase database, Type clazz)
        {
            this.database = database;
            this.clazz = clazz;

            BuildTable();
        }

        private void BuildTable()
        {
            TableDefinition table = TableDefinitionFactory.Build(clazz);
            if(table == null)
            {
                throw new Exception("Error when build TableDefinition");
            }
            //convert TableDefinition to SqlTable
            ConvertToSqlTable(table);
        }

        private void ConvertToSqlTable(TableDefinition table)
        {
            this.name = table.Name;
            this.schema = table.Schema;
            this.fields = new SqlField[table.fields.Count];

            BindingFlags flags = BindingFlags.Instance
                    | BindingFlags.Public
                    | BindingFlags.NonPublic;

            int i = 0;
            //convert FieldDefinition to SqlField
            foreach (FieldDefinition fieldDef in table.fields)
            {
                MemberInfo member = clazz.GetProperty(fieldDef.FieldName, flags);
                if(member == null)
                {
                    member = clazz.GetField(fieldDef.FieldName, flags);
                }
                if(member == null)
                {
                    throw new Exception(string.Format("Cannot find {0} in {1} for column name {2}",
                            fieldDef.FieldName, clazz.FullName, fieldDef.ColumnName));
                }
                this.fields[i++] = new SqlField(fieldDef.ColumnName, member, fieldDef.Flags);
            }

        }

        public IDatabase Database
        {
            get { return database; }
        }

        public Type Clazz
        {
            get { return clazz; }
        }

        public SqlField[] GetFields(FieldFlags flags)
        {
            return GetFields(delegate (SqlField f) {
                return ((f.Flags & flags) == flags);
            });
        }

        public SqlField[] GetFields(Predicate<SqlField> match)
        {
            return Array.FindAll(fields, match);
        }

        public int Delete(object obj)
        {
            SqlField[] keys = GetFields(FieldFlags.Key);
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM ")
                    .Append(QuotedName)
                    .Append(" WHERE ");
            bool first = true;
            for (int i = 0; i < keys.Length; ++i)
            {
                if (!first)
                    sql.Append(" AND ");
                sql.Append(database.QuoteName(keys[i].Name))
                        .Append("=")
                        .Append("@p").Append(i);
            }

            object[] parameters = new object[keys.Length];
            for (int i = 0; i < keys.Length; ++i)
                parameters[i] = keys[i].GetValue(obj);


            int rowcount = 0;
            try
            {
                rowcount = database.ExecuteNonReader(sql.ToString(), parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
            return rowcount;
        }
        
        public int Insert(object obj)
        {
            SqlField[] writeable = GetFields(FieldFlags.Write);
           // SqlField[] identity = GetFields(FieldFlags.Auto);
            string[] names = new string[writeable.Length];
            string[] places = new string[writeable.Length];
            for (int i = 0; i < writeable.Length; ++i)
            {
                names[i] = database.QuoteName(writeable[i].Name);
                places[i] = "@p" + i;
            }
            string fieldstr = string.Join(",", names);
            string valuestr = string.Join(",", places);
            string sql = "INSERT INTO " + QuotedName +
                    "(" + fieldstr + ") VALUES(" + valuestr + ");";

            int rowcount = 0;
            object[] parameters = new object[writeable.Length];
            for (int i = 0; i < writeable.Length; ++i)
            {
                parameters[i] = writeable[i].GetValue(obj);
                // HACK: Support setting binary fields to NULL.
                //       See SqlStatement.SetParamValue().
                if (parameters[i] == null && writeable[i].DataType == SqlDatabase.ByteArrayType)
                    parameters[i] = SqlDatabase.BinaryNull;
            }
            try
            {
                rowcount = database.ExecuteNonReader(sql.ToString(), parameters);
            }
            catch (Exception e)
            {
                throw e;
            }

            return rowcount;
        }

        public IList ReadAll()
        {
            SqlField[] keys = GetFields(FieldFlags.Key);
            IList list = new ArrayList();
            SqlField[] readables = GetFields(FieldFlags.Read);
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ");
            bool first = true;
            foreach (SqlField f in readables)
            {
                if (!first)
                    sql.Append(",");
                first = false;
                sql.Append(database.QuoteName(f.Name));
            }
            sql.Append(" FROM ").Append(QuotedName);

            ForEachCallback callback = new ForEachCallback(delegate (IRow row)
            {
                object obj = NewObject();
                object value = null;
                int i = 0;
                foreach (SqlField f in readables)
                {
                    value = row[i++];
                    if (Convert.IsDBNull(value))
                        value = null;
                    f.SetValue(obj, value);
                }
                list.Add(obj);
            });

            QueryResult result = null;
            try
            {
                SqlDataReader reader = database.ExecuteReader(sql.ToString(), null);
                result = new QueryResult(reader);
                result.ForEach(callback);
                database.CloseConnection();
            }
            catch (Exception e)
            {
                throw e;
            }
            return list;
        }

        public int Update(object obj)
        {
            SqlField[] nonKeys = GetFields(delegate (SqlField f) {
                return ((f.Flags & FieldFlags.Write) == FieldFlags.Write &&
                        (f.Flags & FieldFlags.Key) != FieldFlags.Key);
            });
            SqlField[] keys = GetFields(FieldFlags.Key);
            int i = 0;
            bool first = true;
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE ")
                    .Append(QuotedName)
                    .Append(" SET ");
            foreach (SqlField f in nonKeys)
            {
                if (!first)
                    sql.Append(",");
                sql.Append(database.QuoteName(f.Name))
                        .Append("=")
                        .Append("@p").Append(i);
                first = false;
                i++;
            }
            if (keys.Length > 0)
            {
                first = true;
                sql.Append(" WHERE ");
                foreach (SqlField f in keys)
                {
                    if (!first)
                        sql.Append(" AND ");
                    sql.Append(database.QuoteName(f.Name))
                            .Append("=")
                            .Append("@p").Append(i);
                    first = false;
                    i++;
                }
            }
            
            object[] parameters = new object[nonKeys.Length + keys.Length];

            i = 0;
            foreach (SqlField f in nonKeys)
                parameters[i++] = f.GetValue(obj);
            foreach (SqlField f in keys)
                parameters[i++] = f.GetValue(obj);

            int rowcount = 0;
            try
            {
                rowcount = database.ExecuteNonReader(sql.ToString(), parameters);
            }
            catch (Exception e)
            {
                throw e;
            }
            return rowcount;
        }

        public string QuotedName
        {
            get
            {
                if (!string.IsNullOrEmpty(schema))
                    return database.QuoteName(schema) + "." + database.QuoteName(name);
                return database.QuoteName(name);
            }
        }

        public virtual object NewObject()
        {
            return Activator.CreateInstance(clazz);
        }
    }
}
