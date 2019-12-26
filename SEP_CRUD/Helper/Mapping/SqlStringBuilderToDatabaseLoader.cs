using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD.Entities.Loader;

namespace SEP_CRUD.Helper.Mapping
{
    class SqlStringBuilderToDatabaseLoader
    {
        public static void Convert(SqlConnectionStringBuilder builder,
            DatabaseLoader databaseLoader)
        {
            databaseLoader.DataSource = builder.DataSource;
            databaseLoader.DatabaseName = builder.InitialCatalog;
            databaseLoader.Username = builder.UserID;
            databaseLoader.Password = builder.Password;
        }
    }
}
