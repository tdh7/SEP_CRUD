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
    using System.Drawing;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class EditFormDesignerTemplate : SharedFormDesignerTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("namespace ");
            
            #line 7 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 Write(Generator.Namespace); 
            
            #line default
            #line hidden
            this.Write("{\r\n    partial class Edit");
            
            #line 9 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table.BindingName));
            
            #line default
            #line hidden
            this.Write(@"Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name=""disposing"">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
");
            
            #line 37 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 /*									*/ 
            
            #line default
            #line hidden
            
            #line 38 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 /*									*/ 
            
            #line default
            #line hidden
            
            #line 39 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 /*System.Windows.Forms.Label label1; */ 
            
            #line default
            #line hidden
            
            #line 40 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 for (int i = 0; i < Table.Count; i++)
   { 
            
            #line default
            #line hidden
            this.Write("\t\t\tSystem.Windows.Forms.Label label");
            
            #line 42 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i + 1));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 43 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 44 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
/*																*/ 
            
            #line default
            #line hidden
            
            #line 45 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
/*																*/ 
            
            #line default
            #line hidden
            
            #line 46 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
/*        this.textBoxHoTen = new System.Windows.Forms.TextBox(); */ 
            
            #line default
            #line hidden
            
            #line 47 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 for (int i = 0; i < Table.Count; i++)
   { 
            
            #line default
            #line hidden
            
            #line 49 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
	 if (Table[i].IsAbleBindingToTextBoxControl())
	 {	
            
            #line default
            #line hidden
            this.Write("\t\t\tthis.textBox");
            
            #line 51 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(" = new System.Windows.Forms.TextBox();\r\n");
            
            #line 52 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
   }  
            
            #line default
            #line hidden
            this.Write("\t\t\r\n");
            
            #line 53 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
   if (Table[i].IsAbleBindingToDateTimePicker()) 
     { 
            
            #line default
            #line hidden
            this.Write("\t\t\tthis.dateTimePicker");
            
            #line 55 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(" = new System.Windows.Forms.DateTimePicker();\r\n");
            
            #line 56 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
   } 
            
            #line default
            #line hidden
            this.Write("\t \r\n");
            
            #line 58 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            \r\n");
            
            #line 59 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 /*										   */ 
            
            #line default
            #line hidden
            
            #line 60 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 /*										   */ 
            
            #line default
            #line hidden
            
            #line 61 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 /*label1 = new System.Windows.Forms.Label();*/ 
            
            #line default
            #line hidden
            
            #line 62 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 for (int i = 0; i < Table.Count; i++)
   { 
            
            #line default
            #line hidden
            this.Write("\t\t\tlabel");
            
            #line 64 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i + 1));
            
            #line default
            #line hidden
            this.Write(" = new System.Windows.Forms.Label();\r\n");
            
            #line 65 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            this.SuspendLayout();\r\n");
            
            #line 67 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
/*
			//
			// label2
			//
			label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 13);
            label2.TabIndex = 3;
            label2.Text = "Diem TB";
			*/ 
			for (int i = 0; i < Table.Count; i++)
              {
				string label = "label"+(i + 1);
				var x = LABEL_MARGIN_LEFT;
				var y = SPACING * (i + 1) + i * labelSize.Height;

            
            #line default
            #line hidden
            this.Write("\t\t\t// \r\n\t\t\t// ");
            
            #line 86 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(label));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t// \r\n\t\t\t");
            
            #line 88 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(label));
            
            #line default
            #line hidden
            this.Write(".Anchor = System.Windows.Forms.AnchorStyles.Left;\r\n\t\t\t");
            
            #line 89 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(label));
            
            #line default
            #line hidden
            this.Write(".AutoSize = true;\r\n\t\t\t");
            
            #line 90 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(label));
            
            #line default
            #line hidden
            this.Write(".Location = new System.Drawing.Point(");
            
            #line 90 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 90 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(y));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t");
            
            #line 91 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(label));
            
            #line default
            #line hidden
            this.Write(".Name = \"");
            
            #line 91 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(label));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\t");
            
            #line 92 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(label));
            
            #line default
            #line hidden
            this.Write(".Size = new System.Drawing.Size(");
            
            #line 92 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(labelSize.Width));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 92 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(labelSize.Height));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t");
            
            #line 93 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(label));
            
            #line default
            #line hidden
            this.Write(".TabIndex = 1;\r\n\t\t\t");
            
            #line 94 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(label));
            
            #line default
            #line hidden
            this.Write(".Text = \"");
            
            #line 94 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write("\"; \r\n");
            
            #line 95 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 96 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
/*        // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxHoTen.Location = new System.Drawing.Point(91, 29);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(124, 20);
            this.textBoxHoTen.TabIndex = 1;*/ 

            
            #line default
            #line hidden
            this.Write("          \r\n");
            
            #line 105 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 for (int i = 0; i < Table.Count; i++)
   { 
	 if (Table[i].IsAbleBindingToTextBoxControl())
	 {	
		 var x = TEXT_BOX_MARGIN_LEFT;
		 var y = ComputeControlYLocation(i, textBoxSize);

            
            #line default
            #line hidden
            this.Write("\t\t\t// \r\n            // textBox");
            
            #line 113 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write("\r\n            // \r\n\t\t\tthis.textBox");
            
            #line 115 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(".Anchor = System.Windows.Forms.AnchorStyles.Right;\r\n            this.textBox");
            
            #line 116 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(".Location = new System.Drawing.Point(");
            
            #line 116 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 116 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(y));
            
            #line default
            #line hidden
            this.Write(");\r\n            this.textBox");
            
            #line 117 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(".Name = \"textBox");
            
            #line 117 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write("\";\r\n            this.textBox");
            
            #line 118 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(".Size = new System.Drawing.Size(130, ");
            
            #line 118 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controlHeight));
            
            #line default
            #line hidden
            this.Write(");\r\n            this.textBox");
            
            #line 119 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(".TabIndex = ");
            
            #line 119 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i + 1));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 120 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
  } 
            
            #line default
            #line hidden
            
            #line 121 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 if (Table[i].IsAbleBindingToDateTimePicker()) 
	{ 
		var x = TEXT_BOX_MARGIN_LEFT;
		var y = ComputeControlYLocation(i, dateTimePickerSize);	

            
            #line default
            #line hidden
            this.Write("\t\t\tthis.dateTimePicker");
            
            #line 126 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(".Anchor = System.Windows.Forms.AnchorStyles.Right;\r\n            this.dateTimePick" +
                    "er");
            
            #line 127 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(".Location = new System.Drawing.Point(");
            
            #line 127 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(x));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 127 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(y));
            
            #line default
            #line hidden
            this.Write(");\r\n            this.dateTimePicker");
            
            #line 128 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(".Name = \"dateTimePicker");
            
            #line 128 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write("\";\r\n            this.dateTimePicker");
            
            #line 129 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(".Size = new System.Drawing.Size(130, ");
            
            #line 129 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controlHeight));
            
            #line default
            #line hidden
            this.Write(");\r\n            this.dateTimePicker");
            
            #line 130 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(".TabIndex = ");
            
            #line 130 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i + 1));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 131 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
  } 
            
            #line default
            #line hidden
            
            #line 132 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            // \r\n            // Edit");
            
            #line 134 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table.BindingName));
            
            #line default
            #line hidden
            this.Write("Form\r\n            // \r\n            this.AutoScaleDimensions = new System.Drawing." +
                    "SizeF(6F, 13F);\r\n            this.ClientSize = new System.Drawing.Size(");
            
            #line 137 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ComputeFormWidth()));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 137 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ComputeFormHeight()));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 138 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 for (int i = 0; i < Table.Count; i++)
   {  
            
            #line default
            #line hidden
            
            #line 140 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
	 if (Table[i].IsAbleBindingToTextBoxControl())
	 {	
            
            #line default
            #line hidden
            this.Write("\t\t\tthis.Controls.Add(this.textBox");
            
            #line 142 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 143 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
	 }  
            
            #line default
            #line hidden
            this.Write("\t\t\t\r\n");
            
            #line 144 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
   if (Table[i].IsAbleBindingToDateTimePicker()) 
     {  
            
            #line default
            #line hidden
            this.Write("\t\t\tthis.Controls.Add(this.dateTimePicker");
            
            #line 146 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 147 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
   }  
            
            #line default
            #line hidden
            this.Write(" \r\n");
            
            #line 148 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 149 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 for (int i = 0; i < Table.Count; i++)
   { 
            
            #line default
            #line hidden
            this.Write("\t\t\tthis.Controls.Add(label");
            
            #line 151 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i + 1));
            
            #line default
            #line hidden
            this.Write("); \r\n");
            
            #line 152 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            this.Name = \"Edit");
            
            #line 153 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table.BindingName));
            
            #line default
            #line hidden
            this.Write("Form\";\r\n            this.Text = \"Edit");
            
            #line 154 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table.BindingName));
            
            #line default
            #line hidden
            this.Write("Form\";\r\n            this.ResumeLayout(false);\r\n            this.PerformLayout();\r" +
                    "\n\r\n        }\r\n\r\n        #endregion\r\n");
            
            #line 161 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 for (int i = 0; i < Table.Count; i++)
   { 
            
            #line default
            #line hidden
            
            #line 163 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
	 if (Table[i].IsAbleBindingToTextBoxControl())
	 {	
            
            #line default
            #line hidden
            this.Write("\t\tprivate System.Windows.Forms.TextBox textBox");
            
            #line 165 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 166 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
   }  
            
            #line default
            #line hidden
            
            #line 167 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
   if (Table[i].IsAbleBindingToDateTimePicker()) 
	 {  
            
            #line default
            #line hidden
            this.Write("\t\tprivate System.Windows.Forms.DateTimePicker dateTimePicker");
            
            #line 169 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Table[i].BindingName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 170 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
   }  
            
            #line default
            #line hidden
            
            #line 171 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 174 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditFormDesignerTemplate.tt"
   // Start of class feature block
private int ComputeControlYLocation(int i, Size size)
{
    return SPACING * (i + 1) + i * size.Height;
}

private int ComputeFormHeight()
{
	return SPACING * (Table.Count + 1) + (Table.Count) * controlHeight;
}

private int ComputeFormWidth()
{
	return TEXT_BOX_MARGIN_LEFT + textBoxSize.Width + LABEL_MARGIN_LEFT;
}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
