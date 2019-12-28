using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    public class BaseFormGenerator: Base.FormGenerator
    {
        public BaseFormGenerator(ProjectGenerator p, string _namespace) :
            base(p, "BaseForm", _namespace)
        {
            Clear();
            Add(new BaseFromDesignerGenerator(this));
        }

        public override string ToSourceCode()
        {
            var template = new BaseFormTemplate();
            template.Generator = this;
            return template.TransformText();
        }
    }
}
