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
    public class ItemTableGenerator : FormGenerator
    {
        public ItemTableGenerator(ProjectGenerator p) : base(p, "ItemTableUserControl")
        {

        }

        public override string SubType => "UserControl";

        public override ClassGenerator OnCreateFormDesignerGenerator()
        {
            return new ItemTableDesignerGenerator(this);
        }

        public override string ToSourceCode()
        {
            SharedFormTemplate t = new ItemTableTemplate();
            t.Generator = this;
            return t.TransformText();
        }
    }
}
