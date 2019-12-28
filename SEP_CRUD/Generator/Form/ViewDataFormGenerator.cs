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
    class ViewDataFormGenerator: FormGenerator
    {
        public ViewDataFormGenerator(ProjectGenerator p, string _namespace) : 
            base(p, "ViewDataForm", _namespace)
        {
            Clear();
            Add(new ViewDataFormDesignerGenerator(this));
        }

        public override string ToSourceCode()
        {
            var template = new ViewDataFormTemplate();
            template.Generator = this;
            return template.TransformText();
        }
    }
}
