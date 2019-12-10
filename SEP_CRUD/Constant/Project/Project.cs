using SEP_CRUD.Generator.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Constant.Project
{
    public class Project
    {
        public const string PROJECT_PATH = "Constant.Project.";
        public const string PROJECTS_SOLUTION_PARA1 = "Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") = \"@name\", \"@name\\@name.csproj\", \"{@guid}";
        public const string PROJECT_SOLUTION_PARA2 = "";
        public void d()
        {
         
        }
    }

    public partial class SolutionTemplate
    {
        private SolutionTemplate()
        {

        }
        SolutionGenerator Generator;

        public SolutionTemplate(SolutionGenerator generator)
        {
        Generator = generator;
        }
    }
}
