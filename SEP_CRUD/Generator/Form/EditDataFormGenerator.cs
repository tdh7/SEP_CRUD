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
    class EditDataFormGenerator: FormGenerator
    {
        public EditDataFormGenerator(ProjectGenerator p, string _namespace) 
            : base(p, "EditDataForm", _namespace)
        {
            Clear();
            Add(new EditDataFormDesignerGenerator(this));
        }

        public override string ToSourceCode()
        {
            var template = new EditDataFormTemplate();
            template.Generator = this;
            return template.TransformText();
        }
    }
}
