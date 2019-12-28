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
    class EditFormGenerator
        : FormGenerator
    {
        public Table Table { get; set; }

        public EditFormGenerator(ProjectGenerator p, Table t) 
            : base(p, $"Edit{t.BindingName}Form")
        {
            Table = t;
        }

        public override string ToSourceCode()
        {
            var template = new EditFormTemplate();
            template.Generator = this;
            template.Table = Table;
            return template.TransformText();
        }

        public override ClassGenerator OnCreateFormDesignerGenerator()
        {
            return new EditFormDesignerGenerator(this);
        }
    }
}
