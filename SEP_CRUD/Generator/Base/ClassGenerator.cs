using SEP_CRUD.Generator.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Generator.Base
{
    public abstract class ClassGenerator : GroupGenerator<ClassGenerator>
    {
        public ProjectGenerator ProjectOwner { get; set; }
        public string Namespace { get; set; }
        public ClassGenerator(ProjectGenerator p, string name, string _namespace)
        {
            ProjectOwner = p;
            this.name = name;
            Namespace = _namespace;
        }
        public override string GetFileName()
        {
            return name + ".cs";
        }

        public override string GetRelativePath()
        {
            if (ProjectOwner != null)
                return ProjectOwner.GetRelativePath();
            return "";
        }
    }
}
