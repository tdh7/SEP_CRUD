using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.DAO
{
    class ConfigController
    {
        private static ConfigController instance = new ConfigController();
        private string connectionString;

        private ConfigController()
        {
        }

        public static ConfigController Instance
        {
            get
            {
                return instance;
            }
        }

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }

    }
}
