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
    
    #line 1 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\WaitingFormTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class WaitingFormTemplate : SharedFormTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.ComponentModel;\r\nu" +
                    "sing System.Data;\r\nusing System.Drawing;\r\nusing System.Text;\r\nusing System.Windo" +
                    "ws.Forms;\r\n\r\nnamespace ");
            
            #line 14 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\WaitingFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.Namespace));
            
            #line default
            #line hidden
            this.Write(@"
{
    public partial class WaitingForm : BaseForm
    {
        public WaitingForm()
        {
            InitializeComponent();
        }

        private const int WS_SYSMENU = 0x80000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~ WS_SYSMENU;
                return cp;
            }

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
