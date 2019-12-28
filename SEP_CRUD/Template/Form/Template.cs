using SEP_CRUD.Generator.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using SEP_CRUD.Entities;

namespace SEP_CRUD.Template.Form
{
    public partial class FormTemplate
    {
        Generator.Base.FormGenerator generator;
        public FormTemplate(Generator.Base.FormGenerator g)
        {
            generator = g;
        }
    }

    public partial class FormDesignerTemplate
    {
        Generator.Base.FormDesignerGenerator generator;
        public FormDesignerTemplate(Generator.Base.FormDesignerGenerator g)
        {
            generator = g;
        }
    }

    public partial class EditFormDesignerTemplate
    {
        public Table Table;

        private static int SPACING = 50;
        private static int TEXT_BOX_MARGIN_LEFT = 90;
        private static int LABEL_MARGIN_LEFT = 26;
        private static int controlHeight = 20;
        private static Size labelSize = new Size(55, controlHeight);
        private static Size textBoxSize = new Size(130, controlHeight);
        private static Size dateTimePickerSize = new Size(130, controlHeight);
    }

    public partial class EditFormTemplate
    {
        public Table Table;
    }

    public partial class ViewFormDesignerTemplate
    {
        public Table Table;
    }

    public partial class ViewFormTemplate
    {
        public Table Table;
    }

    public partial class LoginFormTemplate
    {
        public string DBName;
    }

    public partial class ViewFormFactoryTemplate
    {
        public List<Table> Tables;
        public string _namespace;
    }
}
