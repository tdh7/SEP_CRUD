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
        public WaitingFormGenerator(ProjectGenerator p) 
            : base(p, "WaitingForm")
        {
        }

        public override ClassGenerator OnCreateFormDesignerGenerator()
        {
            return new WaitingFormDesignerGenerator(this);
        }

        public override string ToSourceCode()
        {
            var template = new WaitingFormTemplate();
            template.Generator = this;
            return template.TransformText();
        }
    }
}
