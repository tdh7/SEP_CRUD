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
    class ViewFormDesignerGenerator : FormDesignerGenerator<ViewFormGenerator>
    {
        private Table Table => Owner.table;

        public ViewFormDesignerGenerator(ViewFormGenerator owner) : base(owner)
        {
        }

        public override string ToSourceCode()
        {
            var template = new ViewFormDesignerTemplate();
            template.Generator = this;
            template.Table = Table;
            return template.TransformText();
        }
    }
}
