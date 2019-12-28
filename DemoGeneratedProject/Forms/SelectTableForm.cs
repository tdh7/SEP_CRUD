using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace DemoGeneratedProject.Forms
{
    public partial class SelectTableForm : BaseForm
    {
        private string connectionStr;

        public SelectTableForm()
        {
            InitializeComponent();
        }

        private void OnLoginSuccessHandler(object sender, string e)
        {
            this.connectionStr = e;
            
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
            string tableName = (string) listBoxDBTableName.SelectedValue;

            MessageBox.Show($"Table {tableName} has chosen");

            ViewSinhVienForm form = new ViewSinhVienForm();
            form.Show();
        }

        private void SelectDBTableForm_Shown(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            LoginForm form = new LoginForm();
            form.OnLoginSuccessHandler = OnLoginSuccessHandler;
            form.ShowDialog(); // Force user focus on login form
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
              OpenLoginForm();
        }
    }
}
