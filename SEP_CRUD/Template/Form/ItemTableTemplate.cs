﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SEP_CRUD.Template.Form
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\ItemTableTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ItemTableTemplate : SharedFormTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System.Drawing;\r\nusing System.Windows.Forms;\r\n\r\nnamespace ");
            
            #line 9 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\ItemTableTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class ItemTableUserControl : UserControl\r\n    {\r\n        " +
                    "public ItemTableUserControl()\r\n        {\r\n            InitializeComponent();\r\n  " +
                    "      }\r\n\r\n        public string BindingName { get; set; } = \"UnknownTable\";\r\n  " +
                    "      public string Databasename { get; set; } = \"UNKNOWN_TABLE\";\r\n\r\n        pub" +
                    "lic int Position { get; } = 0;\r\n        public ItemTableUserControl(int position" +
                    ", string bindingName, string databaseName)\r\n        {\r\n            this.Position" +
                    " = position;\r\n            this.BindingName = bindingName;\r\n            this.Data" +
                    "basename = databaseName;\r\n            InitializeComponent();\r\n            Init()" +
                    ";\r\n        }\r\n\r\n        public void Init()\r\n        {\r\n            if(Position%4" +
                    "==0)\r\n            {\r\n                this.Margin = new Padding(32, 16, 16, 16);\r" +
                    "\n            } else if ((Position + 1) % 4 ==0)\r\n            {\r\n                " +
                    "this.Margin = new Padding(16, 16, 32, 16);\r\n            } else\r\n            {\r\n " +
                    "               this.Margin = new Padding(16, 16, 16, 16);\r\n            }\r\n\r\n    " +
                    "        Title.Text = this.BindingName;\r\n            Description.Text = \"From tab" +
                    "le \\\"\" + this.Databasename + \"\\\"\";\r\n        }\r\n\r\n        private void OnMouseMov" +
                    "ePanel(object sender, MouseEventArgs e)\r\n        {\r\n            InsidePanel.Heig" +
                    "ht = 223;\r\n            InsidePanel.BackColor = Color.FromArgb(227, 253, 253);\r\n " +
                    "           //Title.ForeColor = Description.ForeColor = Color.White;\r\n        }\r\n" +
                    "\r\n        private void OnMouseLeavePanel(object sender, System.EventArgs e)\r\n   " +
                    "     {\r\n            InsidePanel.Height = 218;\r\n            InsidePanel.BackColor" +
                    " = Color.White;\r\n            //Title.ForeColor = Description.ForeColor = Color.F" +
                    "romArgb(11,11,11);\r\n\r\n        }\r\n\r\n        private void OnMouseDownPanel(object " +
                    "sender, MouseEventArgs e)\r\n        {\r\n            Form f = ViewFormFactory.Insta" +
                    "nce.FindFormByBindingName(BindingName);\r\n            if (f == null) MessageBox.S" +
                    "how(\"No Form for this item\");\r\n            else f.Show();\r\n        }\r\n    }\r\n}\r\n" +
                    "");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
