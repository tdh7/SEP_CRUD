using SEP_CRUD.Generator.Base;
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
            Result result = solutionGenerator.ExportToFiles("output");
            Console.WriteLine("write " + result.GetResult() + " with message " + result.GetMessage());
        }
    }
}
