using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;
using System;

namespace SEP_CRUD.Generator.Form
{
    public class EmptyFormGenerator : FormGenerator
    {
        public EmptyFormGenerator(ProjectGenerator p, string name) : base(p, name)
        {
        }

        public override FormDesignerGenerator FormDesignerGenerator => new EmptyDesignerFormGenerator(this);

        public override string ToSourceCode()
        {
            return new FormTemplate(this).TransformText();
        }
    }
}
