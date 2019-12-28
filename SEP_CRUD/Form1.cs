using SEP_CRUD.Entities.Loader;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Model;
using SEP_CRUD.Generator.Project;
using System;
using System.Windows.Forms;

namespace SEP_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SolutionGenerator solutionGenerator = new SolutionGenerator("SQLViewer");
            ProjectGenerator project = ProjectGenerator.NewInstance("SQLViewer");

            FormGenerator f1 = new FormGenerator(project, "GeneratedForm", project.Name);
            project.Add(f1);
            project.DefaultFormGenerator = f1;

            ProjectGenerator project2 = ProjectGenerator.NewInstance("CreatedProject2");
            FormGenerator f2 = new FormGenerator(project2, "MyForm", project2.Name);
            project2.Add(f2);
            project2.DefaultFormGenerator = f2;

            solutionGenerator.Add(project);
            solutionGenerator.Add(project2);

            EntitiesLoader loader = EntitiesLoader.Instance;
            loader.DataSource = "DESKTOP-5NQGFJL\\SQLEXPRESS";
            loader.DatabaseName = "LOP_HOC";
            loader.Username = "sa";
            loader.Password = "12345";

            Result loadResult = loader.CheckValid();
            if (loadResult.OK) loadResult = loader.Connect();
            if(loadResult.OK)
            {
                loadResult = Entities.Entities.Instance.UpdateData();
            }

            Console.WriteLine("load data " + loadResult.OK + " with message " + loadResult.Message);

            if(loadResult.OK)
            {
                Entities.Entities entities = Entities.Entities.Instance;
                foreach (var t in entities.Tables)
                {
                    project.Add(new ModelGenerator(t.Value, project));
                }
            } 
            /* if(loadResult.OK)
             {
                 Entities.Entities entities = Entities.Entities.Instance;
                 foreach(var t in entities.Tables)
                 {
                     Table table = t.Value;
                     Console.Write("\nTable " + table.BindingName + " ("+table.BindingName+"): ");
                     foreach(Column c in table)
                     {
                         Console.Write(c.DatabaseName+ " => "+ c.BindingName+", ");
                     }
                 }

                 foreach(var f in entities.ForeignKeys)
                 {
                     ForeignKey key = f.Value;
                     Console.Write("\n Foreign Key " + key.BindingName + "(" + key.DatabaseName + "): ");

                     for (int i = 0; i < key.Count; i++)
                         Console.Write("\n" +key.SrcColumns[i].BindingName+" (table "+entities.Tables[key.SrcColumns[i].TableId].BindingName+" ) connects to "+ key.DestColumns[i].BindingName +" (table "+entities.Tables[key.DestColumns[i].TableId].BindingName+" )");
                 }
             }
             */

            Result result = solutionGenerator.ExportToFiles("output");
            Console.WriteLine("write " + result.OK + " with message " + result.Message);
        }
    }
}
