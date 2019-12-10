using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEP_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SolutionGenerator solutionGenerator = new SolutionGenerator("SQLViewer");
            ProjectGenerator project = ProjectGenerator.CreateEmptyProject("SQLViewer");
            solutionGenerator.addProject(project);
            Result result = solutionGenerator.ExportTo("output");
            Console.WriteLine("write " + result.GetResult() + " with message " + result.GetMessage());
        }
    }
}
