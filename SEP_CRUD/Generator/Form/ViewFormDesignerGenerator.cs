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
    class ViewFormDesignerGenerator : FormDesignerGenerator
    {
        private Table table;

        public ViewFormDesignerGenerator(FormGenerator owner, Table t) : base(owner)
        {
            this.table = t;
        }

        public override string ToSourceCode()
        {
            var template = new ViewFormDesignerTemplate();
            template.Generator = this;
            template.Table = table;
            return template.TransformText();
        }
    }
}
