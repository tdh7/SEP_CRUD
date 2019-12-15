using SEP_CRUD.Generator.Base;
using SEP_CRUD.Template.Project;
using System;
using System.Collections.Generic;

namespace SEP_CRUD.Generator.Project
{
    public class SolutionGenerator : GroupGenerator<ProjectGenerator>
    {
        public string Guid { get; } 

        public void SetStartupProject(int position)
        {

        }

        public SolutionGenerator(string name)
        {
            this.name = name;
            Guid = System.Guid.NewGuid().ToString().ToUpperInvariant();

        }

        public override string GetFileName()
        {
            return name+".sln";
        }

        public override string GetRelativePath()
        {
            return "";
        }

        public override string ToSourceCode()
        {
            return new SolutionTemplate(this).TransformText();
        }

    }
}
