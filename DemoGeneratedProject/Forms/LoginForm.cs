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

        public EventHandler<string> OnLoginSuccessHandler;

        public LoginForm()
        {
            InitializeComponent();

            // binding ui control to SqlConnectionStringBuilder
            loginInfoBindingSource.DataSource = new SqlConnectionStringBuilder();
            comboBoxServerList.DataBindings.Add("Text", loginInfoBindingSource, "DataSource");
            textBoxLogin.DataBindings.Add("Text", loginInfoBindingSource, "UserID");
            textBoxPassword.DataBindings.Add("Text", loginInfoBindingSource, "Password");
        }

        #region All control event
        private void comboBoxServerList_DropDown(object sender, EventArgs e)
        {
            RetrieveAllDbInstanceIfEmpty();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var connectionStringBuilder = loginInfoBindingSource.Current as SqlConnectionStringBuilder;
            connectionStringBuilder.InitialCatalog = "QL_SINH_VIEN";
            if (TestDBConnection(connectionStringBuilder))
            {
                var connectionString = connectionStringBuilder.ConnectionString;
                ConfigController.Instance.ConnectionString = connectionString;
                OnLoginSuccessHandler?.Invoke(this, connectionString);
                this.Close();
            }
            else
            {
                MessageBox.Show("Connection failed");
            }

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
    }
}
