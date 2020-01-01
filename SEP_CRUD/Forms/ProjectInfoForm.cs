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
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(folderBrowserDialog.RootFolder);
        }

        private void OnLoginSuccessHandler(object sender, SqlConnectionStringBuilder e)
        {
            this.builder = e;

            toolStripButtonConnect.Enabled = false;
            buttonStart.Enabled = true;
            listBoxDBTableName.Enabled = true;
            textBoxSlnName.Enabled = true;
            textBoxPrjName.Enabled = true;
            textBoxPath.Enabled = true;
            buttonBrowser.Enabled = true;

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
                listBoxDBTableName.DisplayMember = "BindingName";
                Console.WriteLine("Entities info load successful");

                projectInfoBindingSource.DataSource = new ProjectInfo()
                {
                    ProjectName = entities.BindingName,
                    SolutionName = entities.BindingName,
                    Path = folderBrowserDialog.SelectedPath
                };
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
            project.Add(new BaseFormGenerator(project));
            project.Add(new EditDataFormGenerator(project));
            project.Add(new EditableObjectGenerator(project));
            project.Add(new BaseModelGenerator(project));
            project.Add(new ViewDataFormGenerator(project));
            project.Add(new LoginFormGenerator(project, builder.InitialCatalog));
            project.Add(new WaitingFormGenerator(project));
            project.Add(new ViewFormFactoryGenerator(project, listTable));
            project.AddAsStartupForm(new SelectTableFormGenerator(project));

            // generate model for all tables
            foreach(var t in entities.Tables)
            {
                project.Add(new ModelGenerator(t.Value, project));
            }

            // add concrete class
            // TODO loop for each selected tables, generated forms
            foreach (int i in listBoxDBTableName.SelectedIndices)
            {
                var table = listBoxDBTableName.Items[i] as Table;
                project.Add(new EditFormGenerator(project,  table));
               
                project.Add(new ViewFormGenerator(project, table));
                project.Add(new ModelDAOGenerator(project, table));
            }
            project.Add(new ConfigControllerGenerator(project, builder.ConnectionString));


            solutionGenerator.Add(project);
            Result result = solutionGenerator.ExportToFiles(projectInfo.Path);
            Console.WriteLine("write " + result.GetResult() + " with message " + result.Message);
            CopyDLLToGeneratedProject(projectInfo.Path, project.Name);
        }

        private void CopyDLLToGeneratedProject(string path, string projectName)
        {
            var dllName = "SQLHibernate.dll";
            var srcFilePath = Path.Combine("orm", dllName);
            var destDir = Path.Combine(path, projectName, "orm");
            var destFilePath = Path.Combine(destDir, dllName);

            Directory.CreateDirectory(destDir);
            File.Create(destFilePath).Dispose();

            File.Copy(srcFilePath, destFilePath, true);
        }

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog.SelectedPath;
                textBoxPath.Focus();
                Console.Write("Selected Folder: ");
                Console.WriteLine(folderBrowserDialog.SelectedPath);
            }
        }
    }


    public class ProjectInfo
    {
        public string ProjectName { get; set; }

        public string SolutionName { get; set; }

        public string Path { get; set; }

        public override string ToString()
        {
            return $"Project info:\n Sln: {SolutionName},\n Prj: {ProjectName} \nPath: {Path}";
        }
    }
}
