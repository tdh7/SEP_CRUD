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
        : Base.FormDesignerGenerator<EditFormGenerator>
    {
        public EditFormDesignerGenerator(EditFormGenerator owner) 
            : base(owner)
        {
           
        }

        public override string ToSourceCode()
        {
            var template = new EditFormDesignerTemplate();
            template.Generator = this;
            if(Owner is EditFormGenerator)
            template.Table = ((EditFormGenerator)Owner).Table;
            return template.TransformText();
        }
    }
}
