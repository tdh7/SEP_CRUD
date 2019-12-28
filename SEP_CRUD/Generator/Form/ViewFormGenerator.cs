using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD.Entities;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    class ViewFormGenerator: FormGenerator
    {
        private Table table;
        public ViewFormGenerator(ProjectGenerator p, Table t, string _namespace) : 
            base(p, $"View{t.BindingName}Form", _namespace)
        {
            this.table = t;
            Clear();
            Add(new ViewFormDesignerGenerator(this, t));
        }

        public override string ToSourceCode()
        {
            var template = new ViewFormTemplate();
            template.Generator = this;
            template.Table = table;
            return template.TransformText();
        }
    }
}
