using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Template.Project
{
    public partial class SolutionTemplate
    {
        public SolutionGenerator generator;
        public SolutionTemplate(SolutionGenerator generator)
        {
            this.generator = generator;
        }
    }

    public partial class ProjectTemplate
    {
        public ProjectGenerator generator;
        public ProjectTemplate(ProjectGenerator generator)
        {
            this.generator = generator;
        }
    }

    public partial class ProgramTemplate
    {
        public ProjectGenerator generator;
        public ProgramTemplate(ProjectGenerator project)
        {
            this.generator = project;
        }
    }

    public partial class AssemblyInfoTemplate
    {
        public ProjectGenerator generator;
        public AssemblyInfoTemplate(ProjectGenerator generator)
        {
           
            this.generator = generator;
        }
    }
}
