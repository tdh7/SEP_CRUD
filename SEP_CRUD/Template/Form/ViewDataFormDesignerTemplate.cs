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
    
    #line 1 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\ViewDataFormDesignerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ViewDataFormDesignerTemplate : SharedFormDesignerTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("namespace ");
            
            #line 6 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\ViewDataFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n   abstract partial class ViewDataFrom<E>\r\n    {\r\n        /// <summary>\r\n   " +
                    "     /// Required designer variable.\r\n        /// </summary>\r\n        private Sy" +
                    "stem.ComponentModel.IContainer components = null;\r\n\r\n        /// <summary>\r\n    " +
                    "    /// Clean up any resources being used.\r\n        /// </summary>\r\n        /// " +
                    "<param name=\"disposing\">true if managed resources should be disposed; otherwise," +
                    " false.</param>\r\n        protected override void Dispose(bool disposing)\r\n      " +
                    "  {\r\n            if (disposing && (components != null))\r\n            {\r\n        " +
                    "        components.Dispose();\r\n            }\r\n            base.Dispose(disposing" +
                    ");\r\n        }\r\n\r\n        #region Windows Form Designer generated code\r\n\r\n       " +
                    " /// <summary>\r\n        /// Required method for Designer support - do not modify" +
                    "\r\n        /// the contents of this method with the code editor.\r\n        /// </s" +
                    "ummary>\r\n        private void InitializeComponent()\r\n        {\r\n            this" +
                    ".components = new System.ComponentModel.Container();\r\n            this.toolStrip" +
                    "ButtonRefresh = new System.Windows.Forms.ToolStripButton();\r\n            this.da" +
                    "taGridView1 = new System.Windows.Forms.DataGridView();\r\n            this.context" +
                    "MenuStripDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);\r" +
                    "\n            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenu" +
                    "Item();\r\n            this.deleteToolStripMenuItem = new System.Windows.Forms.Too" +
                    "lStripMenuItem();\r\n            this.toolStrip1 = new System.Windows.Forms.ToolSt" +
                    "rip();\r\n            this.toolStripButtonNew = new System.Windows.Forms.ToolStrip" +
                    "Button();\r\n            this.toolStripButtonEdit = new System.Windows.Forms.ToolS" +
                    "tripButton();\r\n            this.toolStripButtonDelete = new System.Windows.Forms" +
                    ".ToolStripButton();\r\n            ((System.ComponentModel.ISupportInitialize)(thi" +
                    "s.dataGridView1)).BeginInit();\r\n            this.contextMenuStripDataGrid.Suspen" +
                    "dLayout();\r\n            this.toolStrip1.SuspendLayout();\r\n            this.Suspe" +
                    "ndLayout();\r\n            // \r\n            // toolStripButtonRefresh\r\n           " +
                    " // \r\n            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Form" +
                    "s.ToolStripItemDisplayStyle.Text;\r\n            this.toolStripButtonRefresh.Image" +
                    "TransparentColor = System.Drawing.Color.Magenta;\r\n            this.toolStripButt" +
                    "onRefresh.Name = \"toolStripButtonRefresh\";\r\n            this.toolStripButtonRefr" +
                    "esh.Size = new System.Drawing.Size(50, 22);\r\n            this.toolStripButtonRef" +
                    "resh.Text = \"Refresh\";\r\n            // \r\n            // dataGridView1\r\n         " +
                    "   // \r\n            this.dataGridView1.AllowUserToAddRows = false;\r\n            " +
                    "this.dataGridView1.AllowUserToDeleteRows = false;\r\n            this.dataGridView" +
                    "1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fil" +
                    "l;\r\n            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;" +
                    "\r\n            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Fo" +
                    "rms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;\r\n            this.dataGrid" +
                    "View1.ContextMenuStrip = this.contextMenuStripDataGrid;\r\n            this.dataGr" +
                    "idView1.Dock = System.Windows.Forms.DockStyle.Fill;\r\n            this.dataGridVi" +
                    "ew1.Location = new System.Drawing.Point(0, 0);\r\n            this.dataGridView1.M" +
                    "argin = new System.Windows.Forms.Padding(4, 4, 4, 4);\r\n            this.dataGrid" +
                    "View1.Name = \"dataGridView1\";\r\n            this.dataGridView1.ReadOnly = true;\r\n" +
                    "            this.dataGridView1.Size = new System.Drawing.Size(1067, 519);\r\n     " +
                    "       this.dataGridView1.TabIndex = 0;\r\n            this.dataGridView1.CellDoub" +
                    "leClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVi" +
                    "ew1_CellDoubleClick);\r\n            // \r\n            // contextMenuStripDataGrid\r" +
                    "\n            // \r\n            this.contextMenuStripDataGrid.ImageScalingSize = n" +
                    "ew System.Drawing.Size(20, 20);\r\n            this.contextMenuStripDataGrid.Items" +
                    ".AddRange(new System.Windows.Forms.ToolStripItem[] {\r\n            this.editToolS" +
                    "tripMenuItem,\r\n            this.deleteToolStripMenuItem});\r\n            this.con" +
                    "textMenuStripDataGrid.Name = \"contextMenuStripDataGrid\";\r\n            this.conte" +
                    "xtMenuStripDataGrid.Size = new System.Drawing.Size(123, 52);\r\n            // \r\n " +
                    "           // editToolStripMenuItem\r\n            // \r\n            this.editToolS" +
                    "tripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;" +
                    "\r\n            this.editToolStripMenuItem.Name = \"editToolStripMenuItem\";\r\n      " +
                    "      this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);\r\n     " +
                    "       this.editToolStripMenuItem.Text = \"Edit\";\r\n            // \r\n            /" +
                    "/ deleteToolStripMenuItem\r\n            // \r\n            this.deleteToolStripMenu" +
                    "Item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;\r\n      " +
                    "      this.deleteToolStripMenuItem.Name = \"deleteToolStripMenuItem\";\r\n          " +
                    "  this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);\r\n       " +
                    "     this.deleteToolStripMenuItem.Text = \"Delete\";\r\n            // \r\n           " +
                    " // toolStrip1\r\n            // \r\n            this.toolStrip1.BackColor = System." +
                    "Drawing.Color.White;\r\n            this.toolStrip1.ImageScalingSize = new System." +
                    "Drawing.Size(20, 20);\r\n            this.toolStrip1.Items.AddRange(new System.Win" +
                    "dows.Forms.ToolStripItem[] {\r\n            this.toolStripButtonNew,\r\n            " +
                    "this.toolStripButtonEdit,\r\n            this.toolStripButtonDelete, \r\n\t\t\tthis.too" +
                    "lStripButtonRefresh});\r\n            this.toolStrip1.Location = new System.Drawin" +
                    "g.Point(0, 0);\r\n            this.toolStrip1.Name = \"toolStrip1\";\r\n            th" +
                    "is.toolStrip1.Size = new System.Drawing.Size(1067, 27);\r\n            this.toolSt" +
                    "rip1.TabIndex = 2;\r\n            this.toolStrip1.Text = \"toolStrip1\";\r\n          " +
                    "  // \r\n            // toolStripButtonNew\r\n            // \r\n            this.tool" +
                    "StripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Tex" +
                    "t;\r\n            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.C" +
                    "olor.Magenta;\r\n            this.toolStripButtonNew.Name = \"toolStripButtonNew\";\r" +
                    "\n            this.toolStripButtonNew.Size = new System.Drawing.Size(90, 24);\r\n  " +
                    "          this.toolStripButtonNew.Text = \"Create New\";\r\n            // \r\n       " +
                    "     // toolStripButtonEdit\r\n            // \r\n            this.toolStripButtonEd" +
                    "it.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;\r\n        " +
                    "    this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magent" +
                    "a;\r\n            this.toolStripButtonEdit.Name = \"toolStripButtonEdit\";\r\n        " +
                    "    this.toolStripButtonEdit.Size = new System.Drawing.Size(62, 24);\r\n          " +
                    "  this.toolStripButtonEdit.Text = \"Update\";\r\n            // \r\n            // too" +
                    "lStripButtonDelete\r\n            // \r\n            this.toolStripButtonDelete.Disp" +
                    "layStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;\r\n            thi" +
                    "s.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;\r\n " +
                    "           this.toolStripButtonDelete.Name = \"toolStripButtonDelete\";\r\n         " +
                    "   this.toolStripButtonDelete.Size = new System.Drawing.Size(57, 24);\r\n         " +
                    "   this.toolStripButtonDelete.Text = \"Delete\";\r\n            // \r\n            // " +
                    "ViewDataFrom\r\n            // \r\n            this.AutoScaleDimensions = new System" +
                    ".Drawing.SizeF(8F, 16F);\r\n            this.ClientSize = new System.Drawing.Size(" +
                    "1067, 519);\r\n            this.Controls.Add(this.toolStrip1);\r\n            this.C" +
                    "ontrols.Add(this.dataGridView1);\r\n            this.Margin = new System.Windows.F" +
                    "orms.Padding(5, 5, 5, 5);\r\n            this.Name = \"ViewDataFrom\";\r\n            " +
                    "this.Text = \"Dashboard\";\r\n            this.Load += new System.EventHandler(this." +
                    "ViewDataFrom_Load);\r\n            ((System.ComponentModel.ISupportInitialize)(thi" +
                    "s.dataGridView1)).EndInit();\r\n            this.contextMenuStripDataGrid.ResumeLa" +
                    "yout(false);\r\n            this.toolStrip1.ResumeLayout(false);\r\n            this" +
                    ".toolStrip1.PerformLayout();\r\n            this.ResumeLayout(false);\r\n           " +
                    " this.PerformLayout();\r\n\r\n        }\r\n\r\n        #endregion\r\n\r\n        private Sys" +
                    "tem.Windows.Forms.DataGridView dataGridView1;\r\n        private System.Windows.Fo" +
                    "rms.ToolStrip toolStrip1;\r\n        private System.Windows.Forms.ToolStripButton " +
                    "toolStripButtonNew;\r\n        private System.Windows.Forms.ToolStripButton toolSt" +
                    "ripButtonEdit;\r\n        private System.Windows.Forms.ToolStripButton toolStripBu" +
                    "ttonDelete;\r\n        private System.Windows.Forms.ContextMenuStrip contextMenuSt" +
                    "ripDataGrid;\r\n        private System.Windows.Forms.ToolStripMenuItem editToolStr" +
                    "ipMenuItem;\r\n        private System.Windows.Forms.ToolStripMenuItem deleteToolSt" +
                    "ripMenuItem;\r\n\t\tprivate System.Windows.Forms.ToolStripButton toolStripButtonRefr" +
                    "esh;\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
