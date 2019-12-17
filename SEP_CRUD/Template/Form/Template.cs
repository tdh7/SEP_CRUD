using SEP_CRUD.Generator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Template.Form
{
    public partial class FormTemplate
    {
        FormGenerator generator;
        public FormTemplate(FormGenerator g)
        {
            generator = g;
        }
    }

    public partial class FormDesignerTemplate
    {
        FormDesignerGenerator generator;
        public FormDesignerTemplate(FormDesignerGenerator g)
        {
            generator = g;
        }
    }
}
