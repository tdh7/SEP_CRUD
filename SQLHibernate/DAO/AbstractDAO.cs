using SQLHibernate.Define.Inteface;
using SQLHibernate.Define.SQLServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.DAO
{
    public abstract class AbstractDAO<T>
    {
        private IDatabase database;
        //private string connectionString = "Data Source=DESKTOP-G7ODJ9B\\SQLEXPRESS;Initial Catalog=ManagementSystem;Integrated Security=True";
        Type clazz = typeof(T);

        protected abstract string ConnectionString { get; }

        public AbstractDAO()
        {
            database = new SqlDatabase(ConnectionString);
        }

        public IList readAll()
        {
            ITable table = database.Table(clazz);
            return table.ReadAll();
        }

        public int Delete(object obj)
        {
            ITable table = database.Table(clazz);
            return table.Delete(obj);
        }

        public int Update(object obj)
        {
            ITable table = database.Table(clazz);
            return table.Update(obj);
        }

        public int Insert(object obj)
        {
            ITable table = database.Table(clazz);
            return table.Insert(obj);
        }
    }
}
