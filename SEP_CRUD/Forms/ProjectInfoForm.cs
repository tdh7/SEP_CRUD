using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;

//using DemoGeneratedProject.DTO;

namespace SEP_CRUD.Forms
{
    public partial class ProjectInfoForm : BaseForm
    {
        private SqlConnectionStringBuilder builder;

        private const string COLUMN_NAME = "TABLE_NAME";

        public ProjectInfoForm()
        {
            InitializeComponent();
        }

        private void OnLoginSuccessHandler(object sender, SqlConnectionStringBuilder e)
        {
            this.builder = e;
            string dbName = builder.InitialCatalog.toClassNameNotation();

            listBoxDBTableName.DataSource = getTableName();
            listBoxDBTableName.DisplayMember = COLUMN_NAME;

            toolStripButtonConnect.Enabled = false;
            buttonStart.Enabled = true;
            listBoxDBTableName.Enabled = true;
            textBoxSlnName.Enabled = true;
            textBoxPrjName.Enabled = true;

            projectInfoBindingSource.DataSource = new ProjectInfo()
                { ProjectName = dbName, SolutionName = dbName };
        }

        private DataTable getTableName()
        {
            var sqlQuery = $"SELECT {COLUMN_NAME} FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            var dt = new DataTable();
            using (var sqlConnection = new SqlConnection(builder.ConnectionString))
            {
                sqlConnection.Open();
                var sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                var adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dt);
            }
            return dt;
        }

        private void ProjectInfoForm_Shown(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            LoginDBFrom form = new LoginDBFrom();
            form.OnLoginSuccessHandler = OnLoginSuccessHandler;
            form.ShowDialog(); // Force user focus on login form
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            List<String> tablesName = new List<string>();
            ProjectInfo projectInfo = projectInfoBindingSource.Current as ProjectInfo;

            Console.WriteLine(projectInfo); // projectInfo.ToString() 

            foreach (int i in listBoxDBTableName.SelectedIndices)
            {
                DataRowView dataRowView = (DataRowView)listBoxDBTableName.Items[i];
                string tableName = dataRowView.Row[COLUMN_NAME].ToString();

                tablesName.Add(tableName);
                Console.WriteLine(tableName); // log
            }

            startGenerate(projectInfo, tablesName, builder);
        }

        private void startGenerate(ProjectInfo projectInfo,
            List<string> tablesName,
            SqlConnectionStringBuilder builder)
        {
            SolutionGenerator solutionGenerator = new SolutionGenerator(projectInfo.SolutionName);
            ProjectGenerator projectGenerator = ProjectGenerator.NewInstance(projectInfo.ProjectName);

            // TODO loop for each table name, genera form
            FormGenerator f1 = new FormGenerator(projectGenerator, "GeneratedForm", projectGenerator.Name);
            projectGenerator.Add(f1);
            projectGenerator.DefaultFormGenerator = f1;

            solutionGenerator.Add(projectGenerator);
            Result result = solutionGenerator.ExportToFiles("output");
            Console.WriteLine("write " + result.GetResult() + " with message " + result.GetMessage());
        }
    }


    public class ProjectInfo
    {
        public string ProjectName { get; set; }

        public string SolutionName { get; set; }

        public override string ToString()
        {
            return $"Project info: Sln: {SolutionName}, Prj: {ProjectName}";
        }
    }
}
