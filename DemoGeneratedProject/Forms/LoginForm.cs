﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using SQLHibernate.DAO;

namespace DemoGeneratedProject.Forms
{
    public partial class LoginForm : BaseForm
    {
        private WaitingForm waitForm = new WaitingForm();
        private IList<string> DbInstanceList = new List<string>();
        private DataTable DBNameTable;

        public EventHandler<bool> LoginResultHandler;

        public LoginForm()
        {
            InitializeComponent();

            // binding ui control to SqlConnectionStringBuilder
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
       

            loginInfoBindingSource.DataSource = builder;
            comboBoxServerList.DataBindings.Add("Text", loginInfoBindingSource, "DataSource");
            textBoxLogin.DataBindings.Add("Text", loginInfoBindingSource, "UserID");
            textBoxPassword.DataBindings.Add("Text", loginInfoBindingSource, "Password");

            builder.DataSource = DatabaseLoader.Instance.DataSource;
            builder.UserID = DatabaseLoader.Instance.Username;
            builder.Password = DatabaseLoader.Instance.Password;
            builder.InitialCatalog = DatabaseLoader.Instance.DatabaseName;
        }

        #region All control event
        private void comboBoxServerList_DropDown(object sender, EventArgs e)
        {
            RetrieveAllDbInstanceIfEmpty();
        }

        private bool result = false;

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var connectionStringBuilder = loginInfoBindingSource.Current as SqlConnectionStringBuilder;
            Result r = Connect(connectionStringBuilder);
            if (r.OK)
            {
                var connectionString = connectionStringBuilder.ConnectionString;
                
                result = true;
                this.Close();
            }
            else
            {
                result = false;
                MessageBox.Show(r.Message, "Connection failed");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void RetrieveAllDbInstanceIfEmpty()
        {
            if (DbInstanceList.Count == 0)
            {
                BackgroundWorker bgWorker = new BackgroundWorker();
                bgWorker.DoWork += BgWorker_RetrieveDbInstance;
                bgWorker.RunWorkerCompleted += BgWorker_RetrieveDbInstanceCompleted;
                bgWorker.RunWorkerAsync();
                waitForm.ShowDialog();
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

        private Result Connect(SqlConnectionStringBuilder builder)
        {
            DatabaseLoader loader = DatabaseLoader.Instance;
            Result r = Result.Create(true);
            try
            {
                loader.DataSource = builder.DataSource;
                loader.Username = builder.UserID;
                loader.Password = builder.Password;
                r = loader.Connect();
            }
            catch (Exception e)
            {
                r = Result.Create("Failed with message\"" + e.Message + "\"");
            }

            if (r.OK) r = DatabaseMatching();
            return r;
        }

        private Result DatabaseMatching()
        {
            return DatabaseLoader.Instance.DatabaseMatching();
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginResultHandler?.Invoke(this, result);
        }
    }
}
