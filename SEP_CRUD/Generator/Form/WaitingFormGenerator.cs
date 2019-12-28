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
    class WaitingFormGenerator: FormGenerator
    {
        public WaitingFormGenerator(ProjectGenerator p, string _namespace) 
            : base(p, "WaitingForm", _namespace)
        {
            Clear();
            Add(new WaitingFormDesignerGenerator(this));
        }

        public override string ToSourceCode()
        {
            var template = new WaitingFormTemplate();
            template.Generator = this;
            return template.TransformText();
        }
    }
}
