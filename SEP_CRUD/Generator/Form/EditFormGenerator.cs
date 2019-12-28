using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD.Entities;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    class EditFormGenerator
        : Base.FormGenerator
    {
        public Table Table { get; set; }

        public EditFormGenerator(ProjectGenerator p, string _namespace, Table t) 
            : base(p, $"Edit{t.BindingName}Form", _namespace)
        {
            Clear();
            this.Table = t;
            Add(new EditFormDesignerGenerator(this, t));
        }

        public override string ToSourceCode()
        {
            var template = new EditFormTemplate();
            template.Generator = this;
            template.Table = Table;
            return template.TransformText();
        }
    }
}
