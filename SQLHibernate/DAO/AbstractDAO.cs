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
        private IDatabase database = null;
        //private string connectionString = "Data Source=DESKTOP-G7ODJ9B\\SQLEXPRESS;Initial Catalog=ManagementSystem;Integrated Security=True";
        Type clazz = typeof(T);

        public AbstractDAO()
        {
        }

        private void updateDatabase()
        {
            if(database == null)
                database = new SqlDatabase(ConfigController.Instance.ConnectionString);
        }

        public IList<T> readAll()
        {
            updateDatabase();
            ITable table = database.Table(clazz);
            return table.ReadAll().Cast<T>().ToList();
        }

        public int Delete(T obj)
        {
            updateDatabase();
            ITable table = database.Table(clazz);
            return table.Delete(obj);
        }

        public int Update(T obj)
        {
            updateDatabase();
            ITable table = database.Table(clazz);
            return table.Update(obj);
        }

        public int Insert(T obj)
        {
            updateDatabase();
            ITable table = database.Table(clazz);
            return table.Insert(obj);
        }
    }
}
