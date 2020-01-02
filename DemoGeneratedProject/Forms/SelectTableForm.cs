using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace DemoGeneratedProject.Forms
{
    public partial class SelectTableForm : BaseForm
    {
        private string connectionStr;

        public SelectTableForm()
        {
            InitializeComponent();
        }

        private void OnLoginSuccess()
        {
            this.connectionStr = "";

            listBoxDBTableName.DataSource = getTableName();
            listBoxDBTableName.DisplayMember = "TABLE_NAME";
            listBoxDBTableName.ValueMember = "TABLE_NAME";

            buttonViewTable.Enabled = true;
            toolStripButtonConnect.Enabled = false;
        }

        private DataTable getTableName()
        {
            var sqlQuery = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            var dt = new DataTable();
            using (var sqlConnection = new SqlConnection(connectionStr))
            {
                sqlConnection.Open();
                var sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                var adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dt);
            }
            return dt;
        }

        private void buttonViewTable_Click(object sender, EventArgs e)
        {
            ShowSelectedTable();
        }

        private void ShowSelectedTable()
        {
            string tableName = null;
            try
            {
                tableName = (string)listBoxDBTableName.SelectedValue;
            }
            catch (Exception) { }

            if(tableName!=null)
            {
                ViewSinhVienForm form = new ViewSinhVienForm();
                form.Show();
            }
        }

        private void SelectDBTableForm_Shown(object sender, EventArgs e)
        {
            new TableListForm().Show();
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            LoginForm form = new LoginForm();
            form.LoginResultHandler = OnLoginResult;
            Hide();
            form.ShowDialog(); // Force user focus on login form
        }

        private void OnLoginResult(object sender, bool e)
        {
            this.Show();
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
              OpenLoginForm();
        }

        private void listBoxDBTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonViewTable_Click(sender, e);
        }
    }
}
