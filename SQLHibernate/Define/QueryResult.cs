using SQLHibernate.Define.Inteface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define
{
    class QueryResult : IQueryResult, IRow, IDisposable
    {
        int fieldCount;
        string[] fieldNames;
        IDataReader reader;

        public QueryResult(IDataReader reader)
        {
            this.reader = reader;
        }

        public object this[string name] => throw new NotImplementedException();

        public object this[int index]
        {
            get
            {
                object value = reader[index];

                return value;
            }
        }

        public int FieldCount
        {
            get
            {
                return reader.FieldCount;
            }
        }

        public string[] FieldNames
        {
            get
            {
                if (fieldNames == null)
                    fieldNames = RowSet.GetFieldNames(reader);
                return fieldNames;
            }
        }

        public RowSet ToRowSet()
        {
            using (this)
                return RowSet.From(reader);
        }
        public DataTable ToDataTable()
        {
            DataTable table = new DataTable();
            using (this)
                table.Load(reader);
            return table;
        }

        public int GetValues(object[] values)
        {
            int ret = reader.GetValues(values);
            for (int i = 0; i < values.Length; ++i)
                if (Convert.IsDBNull(values[i]))
                    values[i] = null;
            return ret;
        }
        
        public void Dispose()
        {
            if (reader != null)
            {
                if (!reader.IsClosed)
                    reader.Close();
                reader.Dispose();
                reader = null;
            }
        }

        public void ForEach(ForEachCallback callback)
        {
            while (reader.Read())
                callback(this);
        }

        public IList ToList(ToListCallback callback)
        {
            throw new NotImplementedException();
        }

        public IList<T> ToList<T>(ToListCallback<T> callback)
        {
            throw new NotImplementedException();
        }
    }
}
