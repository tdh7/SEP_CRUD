using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Generator
{
    public class ProgramGenerator : ClassGenerator
    {
        public ProgramGenerator(ProjectGenerator p) : base(p, "Program", p.Name)
        {
        }

        public override string ToSourceCode()
        {
            return new ProgramTemplate(ProjectOwner).TransformText();
        }
    }
}
