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
        public Table table;
        public ViewFormGenerator(ProjectGenerator p, Table t) : 
            base(p, $"View{t.BindingName}Form")
        {
            this.table = t;
        }

        public override ClassGenerator OnCreateFormDesignerGenerator()
        {
            return new ViewFormDesignerGenerator(this);
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
