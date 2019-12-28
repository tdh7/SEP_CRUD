using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    class ViewDataFormDesignerGenerator: FormDesignerGenerator
    {
        public ViewDataFormDesignerGenerator(FormGenerator owner) : base(owner)
        {
        }

        public override string ToSourceCode()
        {
            var template = new ViewDataFormDesignerTemplate();
            template.Generator = this;
            return template.TransformText();
        }
    }
}
