using SEP_CRUD.Generator.Base;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    public class EmptyDesignerFormGenerator : FormDesignerGenerator
    {
        public EmptyDesignerFormGenerator(FormGenerator owner) : base(owner)
        {

        }

        public override string ToSourceCode()
        {
            return new FormDesignerTemplate(this).TransformText();
        }
    }
}
