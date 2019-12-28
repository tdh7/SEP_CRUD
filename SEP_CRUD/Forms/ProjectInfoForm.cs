using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using SEP_CRUD.Entities;
using SEP_CRUD.Entities.Loader;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Form;
using SEP_CRUD.Generator.Model;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Helper.Mapping;
using SEP_CRUD.Template.Form;


namespace SEP_CRUD.Forms
{
    public partial class ProjectInfoForm : BaseForm
    {
        private SqlConnectionStringBuilder builder;

        private EntitiesLoader entitiesLoader = EntitiesLoader.Instance;
        private Entities.Entities entities;

        public ProjectInfoForm()
        {
            InitializeComponent();
        }

        private void OnLoginSuccessHandler(object sender, SqlConnectionStringBuilder e)
        {
            this.builder = e;
            string dbName = builder.InitialCatalog.toClassNameNotation();

            toolStripButtonConnect.Enabled = false;
            buttonStart.Enabled = true;
            listBoxDBTableName.Enabled = true;
            textBoxSlnName.Enabled = true;
            textBoxPrjName.Enabled = true;

            projectInfoBindingSource.DataSource = new ProjectInfo()
                {ProjectName = dbName, SolutionName = dbName};


            SqlStringBuilderToDatabaseLoader.Convert(builder, entitiesLoader);
            Result loadResult = entitiesLoader.CheckValid();
            if (loadResult.OK)
            {
                loadResult = entitiesLoader.Connect();
            }
            if (loadResult.OK)
            {
                loadResult = Entities.Entities.Instance.UpdateData();
            }

            if (loadResult.OK)
            {
                entities = Entities.Entities.Instance;
                listBoxDBTableName.DataSource = loadAllTable();
                listBoxDBTableName.DisplayMember = "DatabaseName";
                Console.WriteLine("Entities info load successful");
            }
        }

        private List<Table> loadAllTable()
        {
            List<Table> tables = new List<Table>();
            foreach (var t in entities.Tables)
            {
                tables.Add(t.Value);
            }
            return tables;
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
            // Log solution name, project name, selected tables:
            ProjectInfo projectInfo = projectInfoBindingSource.Current as ProjectInfo;
            Console.WriteLine(projectInfo); // projectInfo.ToString() 

            foreach (int i in listBoxDBTableName.SelectedIndices)
            {
                var table = listBoxDBTableName.Items[i] as Table;
                Console.WriteLine(table.DatabaseName);
            }

            startGenerate(projectInfo);
            MessageBox.Show("Done");
        }

        private void startGenerate(ProjectInfo projectInfo)
        {
            var listTable = listBoxDBTableName.SelectedItems.Cast<Table>().ToList();
            SolutionGenerator solutionGenerator = new SolutionGenerator(projectInfo.SolutionName);
            ProjectGenerator project = ProjectGenerator.NewInstance(projectInfo.ProjectName);

            // add must have class            
            project.Add(new BaseFormGenerator(project, project.Name));
            project.Add(new EditDataFormGenerator(project, project.Name));
            project.Add(new EditableObjectGenerator(project));
            project.Add(new BaseModelGenerator(project));
            project.Add(new ViewDataFormGenerator(project, project.Name));
            project.Add(new LoginFormGenerator(project, project.Name, builder.InitialCatalog));
            project.Add(new WaitingFormGenerator(project, project.Name));
            project.Add(new ViewFormFactoryGenerator(project, listTable));
            var selectTableForm = new SelectTableFormGenerator(project, project.Name);
            project.Add(selectTableForm);
            project.DefaultFormGenerator = selectTableForm;

            // add concrete class
            // TODO loop for each table name, genera form
            foreach (int i in listBoxDBTableName.SelectedIndices)
            {
                var table = listBoxDBTableName.Items[i] as Table;
                project.Add(new EditFormGenerator(project, project.Name, table));
                project.Add(new ModelGenerator(table, project));
                project.Add(new ViewFormGenerator(project, table, project.Name));
            }

            solutionGenerator.Add(project);
            Result result = solutionGenerator.ExportToFiles("output");
            Console.WriteLine("write " + result.GetResult() + " with message " + result.Message);
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
