using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD.Entities;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    class EditFormDesignerGenerator
        : Base.FormDesignerGenerator
    {
        private Table Table;

        public EditFormDesignerGenerator(FormGenerator owner, Table t) 
            : base(owner)
        {
            this.Table = t;
        }

        public override string ToSourceCode()
        {
            var template = new EditFormDesignerTemplate();
            template.Generator = this;
            template.Table = Table;
            return template.TransformText();
        }
    }
}
