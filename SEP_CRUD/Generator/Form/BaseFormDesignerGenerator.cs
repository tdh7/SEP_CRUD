using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    class BaseFormDesignerGenerator: Base.FormDesignerGenerator<BaseFormGenerator>
    {
        public BaseFormDesignerGenerator(BaseFormGenerator owner) : base(owner)
        { }

        public override string ToSourceCode()
        {
            var template = new BaseFormDesignerTemplate();
            template.Generator = this;
            return template.TransformText();
        }
    }
}
