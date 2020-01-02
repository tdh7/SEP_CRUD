using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DemoGeneratedProject.DAO
{
    public class DatabaseLoader
    {
        public List<string> SavedTableBindingNames { get; } = new List<string>
        {

        };

        public List<string> SavedTableDatabaseNames { get; } = new List<string>
        {

        };

        public Result DatabaseMatching()
        {
            Result r = Result.Create(true);
            if (!Connected) r = Result.Create("Database is not connected");
            
            if(r.OK)
            {
                try
                {
                    List<string> latestTables = LoadTableNames();
                    List<string> savedTables = SavedTableDatabaseNames;
                    foreach (string s in savedTables)
                    {
                        if(!latestTables.Contains(s))
                        {
                            r = Result.Create("Database doesn't match records (Database misses the table\""+s+"\"");
                            break;
                        }
                    }
                } catch( Exception e)
                {
                    r = Result.Create("Error: " + e.Message);
                }
            }
            return r;
        }

        private static DatabaseLoader sInstance = null;
        public static DatabaseLoader Instance
        {
            get
            {
                if (sInstance == null)
                {
                    sInstance = new DatabaseLoader();
                }
                return sInstance;
            }
        }

        public static void Dispose()
        {
            if (sInstance != null) sInstance.Destroy();
            sInstance = null;
        }

        public List<string> LoadTableNames()
        {
            List<string> list = new List<string>();
            SqlCommand command = new SqlCommand(@"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND
    OBJECTPROPERTY(OBJECT_ID(QUOTENAME(TABLE_SCHEMA) +
        N'.' +
        QUOTENAME(TABLE_NAME)), 'IsMSShipped') = 0" , SqlConnection);
            command.CommandType = System.Data.CommandType.Text;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                string name = "";
                while (reader.Read())
                {
                    try
                    {
                        name = reader.GetString(0);
                    } catch(Exception) {
                        name = "";
                    }
                    if (name != null && name.Length != 0) list.Add(name); 
                }
            }
            return list;
        }

        public void Destroy()
        {
            Disconnect();
        }

        public string DataSource { get; set; } = @"DESKTOP-5NQGFJL\SQLEXPRESS";
        public string DatabaseName { get; set; } = @"LOP_HOC";
        public string Username { get; set; } = @"sa";
        public string Password { get; set; } = "";
        public bool Connected = false;

        private SqlConnection SqlConnection { get; set; }

        public Result CheckValid()
        {
            if (DataSource == null || DataSource.Equals("")) return Result.Create("Data source is empty");
            if (Username == null) return Result.Create("Username is undefined");
            if (Password == null) return Result.Create("Password is undefined");
            return Result.Create(true);
        }
        public Boolean Valid
        { get
            {
                return CheckValid().GetResult();
            }
        }

        public string ConnectionString
        {
            get
            {
                if (!Valid) return "";
                if (Username.Equals("") && Password.Equals(""))
                    return @"Data Source=" + DataSource + ";Initial Catalog="
                         + DatabaseName + ";Persist Security Info=True";
                return @"Data Source=" + DataSource + ";Initial Catalog="
                         + DatabaseName + ";Persist Security Info=True;User ID=" + Username + ";Password=" + Password;
            }
        }

        public SqlCommand LoadCommand(string query)
        {
            SqlCommand c = new SqlCommand(query, SqlConnection);
            c.CommandType = System.Data.CommandType.Text;
            return c;
        }

        public Result Connect()
        {
            Result result = CheckValid();
            if (!result.GetResult()) return result;

            try
            {
                SqlConnection = new SqlConnection(ConnectionString);
            } catch(Exception e)
            {
                result = Result.Create("Exception: " + e.Message);
            }

            if(result.OK)
            {
                try
                {
                    SqlConnection.Open();
                } catch(Exception e)
                {
                    result = Result.Create("Exception: " + e.Message);
                }
            }

            Connected = result.OK;
            return result;
        }

        public void Disconnect()
        {
            if(SqlConnection!=null)
            try
            {
                    SqlConnection.Close();
            } catch (Exception) { }
        }
    }
}
