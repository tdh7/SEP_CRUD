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
            ProjectGenerator project2 = ProjectGenerator.NewInstance("CreatedProject2");
            solutionGenerator.Add(project);
            solutionGenerator.Add(project2);
            Result result = solutionGenerator.ExportToFiles("output");
            Console.WriteLine("write " + result.GetResult() + " with message " + result.GetMessage());
        }
    }
}
