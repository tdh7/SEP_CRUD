using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using SEP_CRUD.Properties;

//using DemoGeneratedProject.DTO;

namespace SEP_CRUD.Forms
{
    public partial class LoginDBFrom : BaseForm
    {
        private WaitingForm waitForm = new WaitingForm();
        private BindingList<string> DbInstanceList = new BindingList<string>();
        private BindingList<string> DBNameList = new BindingList<string>();

        public EventHandler<SqlConnectionStringBuilder> OnLoginSuccessHandler;

        public LoginDBFrom()
        {
            InitializeComponent();

            // binding ui control to SqlConnectionStringBuilder
            loginInfoBindingSource.DataSource = new SqlConnectionStringBuilder();
            comboBoxServerList.DataBindings.Add("SelectedItem", loginInfoBindingSource, "DataSource",true,DataSourceUpdateMode.OnValidation);
            textBoxLogin.DataBindings.Add("Text", loginInfoBindingSource, "UserID", true, DataSourceUpdateMode.OnValidation);
            textBoxPassword.DataBindings.Add("Text", loginInfoBindingSource, "Password", true, DataSourceUpdateMode.OnValidation);
            comboBoxDBName.DataBindings.Add("SelectedItem", loginInfoBindingSource, "InitialCatalog", true, DataSourceUpdateMode.OnValidation);
        }

        #region All control event
        private void comboBoxServerList_DropDown(object sender, EventArgs e)
        {
            RetrieveDbInstanceIfNeed(DbInstanceList);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var connectionStringBuilder = loginInfoBindingSource.Current as SqlConnectionStringBuilder;
            var errorMessage = string.Empty;
            if (TestDBConnection(connectionStringBuilder, ref errorMessage))
            {
                OnLoginSuccessHandler?.Invoke(this, connectionStringBuilder);
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            var connectionStringBuilder = loginInfoBindingSource.Current as SqlConnectionStringBuilder;
            BackgroundWorker bgWorker = new BackgroundWorker();
            bgWorker.DoWork += BgWorker_TestConnection;
            bgWorker.RunWorkerCompleted += BgWorker_TestConnectionComplete;
            bgWorker.RunWorkerAsync(connectionStringBuilder);
        }

        private void comboBoxDBName_DropDown(object sender, EventArgs e)
        {
            RetrieveDbNameIfNeed(DBNameList);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginDBFrom_Load(object sender, EventArgs e)
        {
            comboBoxServerList.DataSource = DbInstanceList;
            comboBoxDBName.DataSource = DBNameList;

            LoadConnectionStringFromSettings();
            ValidateChildren();           // trigger validate event to update SqlConnectionString object
        }

        private void LoginDBFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            ValidateChildren();          // trigger validate event to update SqlConnectionString object
            SaveConnectionString();
        }

        private void linkLabelReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DbInstanceList.Clear();
            this.DBNameList.Clear();
            this.textBoxLogin.Text = string.Empty;
            this.textBoxPassword.Text = string.Empty;
            ValidateChildren();
        }
        #endregion

        private void RetrieveDbInstanceIfNeed(BindingList<string> instanceList)
        {
            if (DbInstanceList.Count <= 1)
            {
                BackgroundWorker bgWorker = new BackgroundWorker();
                bgWorker.DoWork += BgWorker_RetrieveDbInstance;
                bgWorker.RunWorkerCompleted += BgWorker_RetrieveDbInstanceCompleted;
                bgWorker.RunWorkerAsync();
                bgWorker.WorkerSupportsCancellation = true;
                waitForm.CloseAction = delegate()
                {
                    bgWorker.CancelAsync();
                };
                waitForm.ShowDialog();
            }
        }

        private void RetrieveDbNameIfNeed(BindingList<string> dbNameList)
        {
            var errorMessage = string.Empty;
            SqlConnectionStringBuilder builder = loginInfoBindingSource.Current as SqlConnectionStringBuilder;
            if (!TestDBConnection(builder, ref errorMessage))
            {
                MessageBox.Show(errorMessage, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dbNameList.Count <= 1)
            {
                dbNameList.Clear();
                addDbNameList(dbNameList, builder);
            }
        }

        private void addDbNameList(BindingList<string> dbNameList, SqlConnectionStringBuilder builder)
        {
            var sqlQuery = "SELECT name FROM master.dbo.sysdatabases";
            var connectionString = builder.ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sqlCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var dbName = reader.GetString(0);
                        dbNameList.Add(dbName);
                    }
                }
                reader.Close();
            }
        }

        private void BgWorker_RetrieveDbInstanceCompleted(object sender, RunWorkerCompletedEventArgs e)
        {   
            waitForm.Close();
            DbInstanceList.Clear();
            DataTable dbInstanceTable = e.Result as DataTable;
            dbInstanceTable?.DisplayData();
            ConvertTableToList(dbInstanceTable, DbInstanceList);
            comboBoxServerList.SelectedIndex = -1;
        }

        private void BgWorker_RetrieveDbInstance(object sender, DoWorkEventArgs e)
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();
            e.Result = table;
        }

        private void BgWorker_TestConnectionComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            string errorMessage = (string)e.Result;
            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Test connection succeeded");
            }
            else
            {
                MessageBox.Show(errorMessage, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BgWorker_TestConnection(object sender, DoWorkEventArgs e)
        {
            SqlConnectionStringBuilder connectionString = (SqlConnectionStringBuilder)e.Argument;
            var errorMessage = string.Empty;
            bool connectable = TestDBConnection(connectionString,ref errorMessage);
            e.Result = errorMessage;
        }

        private bool TestDBConnection(SqlConnectionStringBuilder builder, ref string errorMessage)
        {
            bool connectable = true;
            try
            {
                var connectionString = builder.ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                errorMessage = e.Message;
                connectable = false;
            }

            return connectable;
        }

        private void ConvertTableToList(DataTable dbInstanceTable, BindingList<string> serverInstances)
        {
            if (dbInstanceTable == null)
                return;

            foreach (DataRow row in dbInstanceTable.Rows)
            {
                serverInstances.Add($@"{row["ServerName"]}\{row["InstanceName"]}");
            }
        }

        private void LoadConnectionStringFromSettings()
        {
            Settings.Default.Reload();
            DbInstanceList.Add(Settings.Default.ServerName);
            DBNameList.Add(Settings.Default.DatabaseName);
            textBoxLogin.Text = Settings.Default.UserName;
            textBoxPassword.Text = Settings.Default.Password;
        }

        private void SaveConnectionString()
        {
            var connectionStringBuilder = loginInfoBindingSource.Current as SqlConnectionStringBuilder;

            if (connectionStringBuilder == null) return;
            Settings.Default.ServerName = connectionStringBuilder.DataSource;
            Settings.Default.UserName = connectionStringBuilder.UserID;
            Settings.Default.Password = connectionStringBuilder.Password;
            Settings.Default.DatabaseName = connectionStringBuilder.InitialCatalog;
            Settings.Default.Save();
        }
    }
}
