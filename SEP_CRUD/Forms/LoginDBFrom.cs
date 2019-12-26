using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
//using DemoGeneratedProject.DTO;

namespace SEP_CRUD.Forms
{
    public partial class LoginDBFrom : BaseForm
    {
        private WaitingForm waitForm = new WaitingForm();
        private IList<string> DbInstanceList = new List<string>();
        private DataTable DBNameTable;

        public EventHandler<SqlConnectionStringBuilder> OnLoginSuccessHandler;

        public LoginDBFrom()
        {
            InitializeComponent();

            // binding ui control to SqlConnectionStringBuilder
            loginInfoBindingSource.DataSource = new SqlConnectionStringBuilder();
            comboBoxServerList.DataBindings.Add("Text", loginInfoBindingSource, "DataSource");
            textBoxLogin.DataBindings.Add("Text", loginInfoBindingSource, "UserID");
            textBoxPassword.DataBindings.Add("Text", loginInfoBindingSource, "Password");
            comboBoxDBName.DataBindings.Add("Text", loginInfoBindingSource, "InitialCatalog");
        }

        #region All control event
        private void comboBoxServerList_DropDown(object sender, EventArgs e)
        {
            RetrieveAllDbInstanceIfEmpty();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var connectionStringBuilder = loginInfoBindingSource.Current as SqlConnectionStringBuilder;

            if (TestDBConnection(connectionStringBuilder))
            {
                OnLoginSuccessHandler?.Invoke(this, connectionStringBuilder);
                this.Close();
            }
            else
            {
                MessageBox.Show("Connection failed");
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
            RetrieveDbNameIfNeed();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void RetrieveAllDbInstanceIfEmpty()
        {
            if (DbInstanceList.isEmpty())
            {
                BackgroundWorker bgWorker = new BackgroundWorker();
                bgWorker.DoWork += BgWorker_RetrieveDbInstance;
                bgWorker.RunWorkerCompleted += BgWorker_RetrieveDbInstanceCompleted;
                bgWorker.RunWorkerAsync();
                waitForm.ShowDialog();
            }
        }

        private void RetrieveDbNameIfNeed()
        {
            SqlConnectionStringBuilder builder = loginInfoBindingSource.Current as SqlConnectionStringBuilder;
            if (!TestDBConnection(builder))
            {
                MessageBox.Show("Connection failed");
                return;
            }

            if (DBNameTable == null)
            {
                DBNameTable = GetDBListOfCurrentServerInstance(builder);
                comboBoxDBName.DataSource = DBNameTable;
                comboBoxDBName.DisplayMember = "name";
                comboBoxDBName.SelectedIndex = -1;
            }
        }

        private void BgWorker_RetrieveDbInstanceCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            waitForm.Close();

            DataTable dbInstanceTable = e.Result as DataTable;
            dbInstanceTable?.DisplayData();
            ConvertTableToList(dbInstanceTable, DbInstanceList);
            InitComboboxServerList();
        }

        private void BgWorker_RetrieveDbInstance(object sender, DoWorkEventArgs e)
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();
            e.Result = table;
        }

        private void BgWorker_TestConnectionComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            bool connectable = (bool)e.Result;
            if (connectable)
            {
                MessageBox.Show("Test connection succeeded");
            }
            else
            {
                MessageBox.Show("Connection failed");
            }
        }

        private void BgWorker_TestConnection(object sender, DoWorkEventArgs e)
        {
            SqlConnectionStringBuilder connectionString = (SqlConnectionStringBuilder)e.Argument;
            bool connectable = TestDBConnection(connectionString);
            e.Result = connectable;
        }

        private bool TestDBConnection(SqlConnectionStringBuilder builder)
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
                connectable = false;
            }

            return connectable;
        }

        private void ConvertTableToList(DataTable dbInstanceTable, IList<string> serverInstances)
        {
            if (dbInstanceTable == null)
                return;

            foreach (DataRow row in dbInstanceTable.Rows)
            {
                serverInstances.Add($@"{row["ServerName"]}\{row["InstanceName"]}");
            }
        }

        private void InitComboboxServerList()
        {
            comboBoxServerList.DataSource = DbInstanceList;
            comboBoxServerList.SelectedIndex = -1;
        }

        private DataTable GetDBListOfCurrentServerInstance(SqlConnectionStringBuilder builder)
        {
            var tb = new DataTable();
            var sqlQuery = "SELECT name FROM master.dbo.sysdatabases";
            var connectionString = builder.ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sqlCommand = new SqlCommand(sqlQuery, connection);
                var adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(tb);
            }

            return tb;
        }

    }
}
