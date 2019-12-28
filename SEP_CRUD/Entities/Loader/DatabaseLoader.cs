using SEP_CRUD.Generator.Base;
using SEP_CRUD.Template.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Entities.Loader
{
    public class DatabaseLoader
    {
        public List<string> LoadTableNames()
        {
            List<string> list = new List<string>();
            SqlCommand command = new SqlCommand(Constant.LoadTablesSqlQuery, SqlConnection);
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

        

        public string DataSource { get; set; }
        public string DatabaseName { get; set; }
        public string Username { get; set; } = "";
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
