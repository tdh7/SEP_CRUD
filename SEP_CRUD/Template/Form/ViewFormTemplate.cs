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
    
    #line 1 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ViewFormTemplate : SharedFormGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
 var entityName = Table.BindingName; 
            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.ComponentModel;\r\nu" +
                    "sing System.Data;\r\nusing System.Drawing;\r\nusing System.Text;\r\nusing System.Windo" +
                    "ws.Forms;\r\nusing ");
            
            #line 14 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.ProjectOwner.DefaultModelNamespaces));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nnamespace ");
            
            #line 16 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class View");
            
            #line 18 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write("Form: ViewDataFrom<");
            
            #line 18 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n\r\n        public View");
            
            #line 21 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write("Form()\r\n        {\r\n            InitializeComponent();\r\n        }\r\n\r\n\t\t// TODO: re" +
                    "trieve data from BUS and return result here\r\n        protected override IList<");
            
            #line 27 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write("> initList()\r\n        {\r\n\t\t\treturn new List<");
            
            #line 29 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write(">();   \r\n        }\r\n\r\n        protected override void Add()\r\n        {\r\n         " +
                    "   Edit");
            
            #line 34 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write("Form.Add(delegate(");
            
            #line 34 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write(" sv)\r\n            {\r\n                bindingList.Add(sv);\r\n\t\t\t\t// TODO: update da" +
                    "ta to BUS here\r\n                \r\n            });\r\n        }\r\n\r\n        protecte" +
                    "d override void Edit(");
            
            #line 42 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write(" item)\r\n        {\r\n            Edit");
            
            #line 44 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write("Form.Edit(item, delegate(");
            
            #line 44 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write(" sv)\r\n            {\r\n                // TODO: update data to BUS here\r\n          " +
                    "  });\r\n        }\r\n\r\n        protected override void Delete(");
            
            #line 50 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\ViewFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityName));
            
            #line default
            #line hidden
            this.Write(@" item)
        {
			// TODO: update data to BUS here

            bindingList.Remove(item);
        }

        protected override void ViewDataFrom_Load(object sender, EventArgs e)
        {
            base.ViewDataFrom_Load(sender, e);

        }
    }
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
