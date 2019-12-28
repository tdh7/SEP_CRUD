using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    public class BaseFormGenerator: FormGenerator
    {
        public BaseFormGenerator(ProjectGenerator p) :
            base(p, "BaseForm")
        {

        }

        public override ClassGenerator OnCreateFormDesignerGenerator()
        {
            return new BaseFormDesignerGenerator(this); 
        }

        public override string ToSourceCode()
        {
            var template = new BaseFormTemplate();
            template.Generator = this;
            return template.TransformText();
        }
    }
}
