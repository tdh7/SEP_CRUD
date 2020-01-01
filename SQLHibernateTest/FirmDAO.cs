using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHibernate.DAO;

namespace SQLHibernateTest
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
