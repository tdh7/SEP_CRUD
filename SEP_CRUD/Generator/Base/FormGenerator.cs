using System;
using SEP_CRUD.Generator.Project;

namespace SEP_CRUD.Generator.Base
{
    public class FormGenerator : ClassGenerator
    {
        public FormGenerator(ProjectGenerator p, string name, string _namespace) 
            : base(p, name, _namespace)
        {

        }

        public override string ToSourceCode()
        {
            throw new NotImplementedException();
        }
    }
}
