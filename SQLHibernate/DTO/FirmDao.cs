using SQLHibernate.Define.Inteface;
using SQLHibernate.Define.SQLServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.DTO
{
    class FirmDAO
    {
        private IDatabase database;
        private String connectionString = "Data Source=DESKTOP-G7ODJ9B\\SQLEXPRESS;Initial Catalog=ManagementSystem;Integrated Security=True";
        public static FirmDAO Instance
        {
            get
            {
                return new FirmDAO();
            }
        }

        private FirmDAO()
        {
            database = new SqlDatabase(connectionString);
        }

        public IList readAll()
        {
            ITable table = database.Table(typeof(Firm));
            return table.ReadAll();
        }

        public int Delete(object obj)
        {
            ITable table = database.Table(typeof(Firm));
            return table.Delete(obj);
        }

        public int Update(object obj)
        {
            ITable table = database.Table(typeof(Firm));
            return table.Update(obj);
        }

        public int Insert(object obj)
        {
            ITable table = database.Table(typeof(Firm));
            return table.Insert(obj);
        }
    }
}
