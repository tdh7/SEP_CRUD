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
    
    #line 1 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\WaitingFormDesignerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class WaitingFormDesignerTemplate : SharedFormDesignerTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("namespace ");
            
            #line 6 "C:\Users\trung\source\repos\SEP_CRUD\SEP_CRUD\Template\Form\WaitingFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    partial class WaitingForm\r\n    {\r\n        /// <summary>\r\n        /// Req" +
                    "uired designer variable.\r\n        /// </summary>\r\n        private System.Compone" +
                    "ntModel.IContainer components = null;\r\n\r\n        /// <summary>\r\n        /// Clea" +
                    "n up any resources being used.\r\n        /// </summary>\r\n        /// <param name=" +
                    "\"disposing\">true if managed resources should be disposed; otherwise, false.</par" +
                    "am>\r\n        protected override void Dispose(bool disposing)\r\n        {\r\n       " +
                    "     if (disposing && (components != null))\r\n            {\r\n                comp" +
                    "onents.Dispose();\r\n            }\r\n            base.Dispose(disposing);\r\n        " +
                    "}\r\n\r\n        #region Windows Form Designer generated code\r\n\r\n        /// <summar" +
                    "y>\r\n        /// Required method for Designer support - do not modify\r\n        //" +
                    "/ the contents of this method with the code editor.\r\n        /// </summary>\r\n   " +
                    "     private void InitializeComponent()\r\n        {\r\n            this.label1 = ne" +
                    "w System.Windows.Forms.Label();\r\n            this.SuspendLayout();\r\n            " +
                    "// \r\n            // label1\r\n            // \r\n            this.label1.AutoSize = " +
                    "true;\r\n            this.label1.Location = new System.Drawing.Point(43, 9);\r\n    " +
                    "        this.label1.Name = \"label1\";\r\n            this.label1.Size = new System." +
                    "Drawing.Size(229, 13);\r\n            this.label1.TabIndex = 0;\r\n            this." +
                    "label1.Text = \"Please wait while we retrieve the list of server...\";\r\n          " +
                    "  // \r\n            // WaitingForm\r\n            // \r\n            this.AutoScaleDi" +
                    "mensions = new System.Drawing.SizeF(6F, 13F);\r\n            this.ClientSize = new" +
                    " System.Drawing.Size(309, 33);\r\n            this.Controls.Add(this.label1);\r\n   " +
                    "         this.Location = new System.Drawing.Point(0, 0);\r\n            this.Maxim" +
                    "izeBox = false;\r\n            this.MaximumSize = new System.Drawing.Size(325, 72)" +
                    ";\r\n            this.MinimizeBox = false;\r\n            this.MinimumSize = new Sys" +
                    "tem.Drawing.Size(325, 72);\r\n            this.Name = \"WaitingForm\";\r\n            " +
                    "this.ShowIcon = false;\r\n            this.ShowInTaskbar = false;\r\n            thi" +
                    "s.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;\r\n            this.Tex" +
                    "t = \"Please wait\";\r\n            this.WindowState = System.Windows.Forms.FormWind" +
                    "owState.Normal;\r\n            this.ResumeLayout(false);\r\n            this.Perform" +
                    "Layout();\r\n\r\n        }\r\n\r\n        #endregion\r\n\r\n        private System.Windows.F" +
                    "orms.Label label1;\r\n    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
