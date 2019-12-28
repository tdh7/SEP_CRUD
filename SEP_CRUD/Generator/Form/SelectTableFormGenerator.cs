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
    class SelectTableFormGenerator: FormGenerator
    {
        public SelectTableFormGenerator(ProjectGenerator p, string _namespace) 
            : base(p, "SelectTableForm", _namespace)
        {
            Clear();
            Add(new SelectTableFormDesignerGenerator(this));
        }

        public override string ToSourceCode()
        {
            var template = new SelectTableFormTemplate();
            template.Generator = this;
            return template.TransformText();
        }
    }
}
