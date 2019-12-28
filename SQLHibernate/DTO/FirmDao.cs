using SQLHibernate.DAO;
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
    class FirmDAO : AbstractDAO<Firm>
    {
        private string connectionString = "Data Source=DESKTOP-G7ODJ9B\\SQLEXPRESS;Initial Catalog=ManagementSystem;Integrated Security=True";

        public FirmDAO() : base() { }

        public static FirmDAO Instance
        {
            get
            {
                return new FirmDAO();
            }
        }

        protected override string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }
    }
}
