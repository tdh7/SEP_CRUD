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
    
    #line 1 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\TableListFormDesignerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class TableListFormDesignerTemplate : SharedFormDesignerTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("namespace ");
            
            #line 6 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\TableListFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    partial class TableListForm\r\n    {\r\n        /// <summary>\r\n        /// R" +
                    "equired designer variable.\r\n        /// </summary>\r\n        private System.Compo" +
                    "nentModel.IContainer components = null;\r\n\r\n        /// <summary>\r\n        /// Cl" +
                    "ean up any resources being used.\r\n        /// </summary>\r\n        /// <param nam" +
                    "e=\"disposing\">true if managed resources should be disposed; otherwise, false.</p" +
                    "aram>\r\n        protected override void Dispose(bool disposing)\r\n        {\r\n     " +
                    "       if (disposing && (components != null))\r\n            {\r\n                co" +
                    "mponents.Dispose();\r\n            }\r\n            base.Dispose(disposing);\r\n      " +
                    "  }\r\n\r\n        #region Windows Form Designer generated code\r\n\r\n        /// <summ" +
                    "ary>\r\n        /// Required method for Designer support - do not modify\r\n        " +
                    "/// the contents of this method with the code editor.\r\n        /// </summary>\r\n " +
                    "       private void InitializeComponent()\r\n        {\r\n            this.FlowListP" +
                    "anel = new System.Windows.Forms.FlowLayoutPanel();\r\n            this.Title = new" +
                    " System.Windows.Forms.Label();\r\n            this.Notification = new System.Windo" +
                    "ws.Forms.Label();\r\n            this.FlowListPanel.SuspendLayout();\r\n            " +
                    "this.SuspendLayout();\r\n            // \r\n            // FlowListPanel\r\n          " +
                    "  // \r\n            this.FlowListPanel.AutoScroll = true;\r\n            this.FlowL" +
                    "istPanel.BackColor = System.Drawing.Color.Transparent;\r\n            this.FlowLis" +
                    "tPanel.Controls.Add(this.Title);\r\n            this.FlowListPanel.Controls.Add(th" +
                    "is.Notification);\r\n            this.FlowListPanel.Dock = System.Windows.Forms.Do" +
                    "ckStyle.Fill;\r\n            this.FlowListPanel.ForeColor = System.Drawing.Color.W" +
                    "hite;\r\n            this.FlowListPanel.Location = new System.Drawing.Point(0, 0);" +
                    "\r\n            this.FlowListPanel.Margin = new System.Windows.Forms.Padding(3, 30" +
                    ", 3, 3);\r\n            this.FlowListPanel.Name = \"FlowListPanel\";\r\n            th" +
                    "is.FlowListPanel.Size = new System.Drawing.Size(1067, 607);\r\n            this.Fl" +
                    "owListPanel.TabIndex = 1;\r\n            // \r\n            // Title\r\n            //" +
                    " \r\n            this.Title.BackColor = System.Drawing.Color.Transparent;\r\n       " +
                    "     this.Title.Font = new System.Drawing.Font(\"Segoe UI Semibold\", 18F, System." +
                    "Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));\r\n      " +
                    "      this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11))))" +
                    ", ((int)(((byte)(11)))), ((int)(((byte)(11)))));\r\n            this.Title.Locatio" +
                    "n = new System.Drawing.Point(3, 0);\r\n            this.Title.Name = \"Title\";\r\n   " +
                    "         this.Title.Padding = new System.Windows.Forms.Padding(16, 6, 32, 6);\r\n " +
                    "           this.Title.Size = new System.Drawing.Size(991, 75);\r\n            this" +
                    ".Title.TabIndex = 8;\r\n            this.Title.Text = \"Which data do you want to v" +
                    "iew ?\";\r\n            this.Title.TextAlign = System.Drawing.ContentAlignment.Midd" +
                    "leLeft;\r\n            // \r\n            // Notification\r\n            // \r\n        " +
                    "    this.Notification.BackColor = System.Drawing.Color.Transparent;\r\n           " +
                    " this.Notification.Cursor = System.Windows.Forms.Cursors.Hand;\r\n            this" +
                    ".Notification.Font = new System.Drawing.Font(\"Segoe UI Semibold\", 18F, System.Dr" +
                    "awing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));\r\n        " +
                    "    this.Notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0" +
                    ")))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));\r\n            this.Notific" +
                    "ation.Location = new System.Drawing.Point(3, 75);\r\n            this.Notification" +
                    ".Name = \"Notification\";\r\n            this.Notification.Padding = new System.Wind" +
                    "ows.Forms.Padding(16, 6, 32, 6);\r\n            this.Notification.Size = new Syste" +
                    "m.Drawing.Size(1052, 523);\r\n            this.Notification.TabIndex = 10;\r\n      " +
                    "      this.Notification.Text = \"Sign In to Continue… \";\r\n            this.Notifi" +
                    "cation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;\r\n            //" +
                    " \r\n            // TableListForm\r\n            // \r\n            this.AutoScaleDime" +
                    "nsions = new System.Drawing.SizeF(8F, 16F);\r\n            this.AutoScaleMode = Sy" +
                    "stem.Windows.Forms.AutoScaleMode.Font;\r\n            this.BackColor = System.Draw" +
                    "ing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte" +
                    ")(250)))));\r\n            this.ClientSize = new System.Drawing.Size(1100, 607);\r\n" +
                    "            this.Controls.Add(this.FlowListPanel);\r\n            this.ForeColor =" +
                    " System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((i" +
                    "nt)(((byte)(64)))));\r\n            this.MaximumSize = new System.Drawing.Size(110" +
                    "0, 654);\r\n            this.MinimumSize = new System.Drawing.Size(1100, 654);\r\n  " +
                    "          this.Name = \"TableListForm\";\r\n            this.ShowIcon = false;\r\n    " +
                    "        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen" +
                    ";\r\n            this.Text = \"Dashboard\";\r\n            this.FlowListPanel.ResumeLa" +
                    "yout(false);\r\n            this.ResumeLayout(false);\r\n\r\n        }\r\n\r\n        #end" +
                    "region\r\n        private System.Windows.Forms.FlowLayoutPanel FlowListPanel;\r\n   " +
                    "     private System.Windows.Forms.Label Title;\r\n        private System.Windows.F" +
                    "orms.Label Notification;\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
