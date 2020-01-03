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
    
    #line 1 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditDataFormTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class EditDataFormTemplate : SharedFormTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.ComponentModel;\r\nu" +
                    "sing System.Data;\r\nusing System.Drawing;\r\nusing System.Runtime.CompilerServices;" +
                    "\r\nusing System.Text;\r\nusing System.Windows.Forms;\r\nusing ");
            
            #line 14 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditDataFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.ProjectOwner.DefaultModelNamespaces));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nnamespace ");
            
            #line 16 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\EditDataFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class EditDataForm<E, F> : BaseForm\r\n        where E: Bas" +
                    "eModel, new()\r\n        where F: EditDataForm<E, F>, new()\r\n    {\r\n        privat" +
                    "e Func<FormType, E, bool> _saveAction;\r\n        protected BindingSource bindingS" +
                    "ourceItem = new BindingSource();\r\n        private FormType currentMode;\r\n\t\t\r\n\t\tp" +
                    "ublic EditDataForm()\r\n        {\r\n            InitializeComponent();\r\n        }\r\n" +
                    "\r\n        private static F SetUpForm(E entity, Func<FormType, E, bool> saveActio" +
                    "n)\r\n        {\r\n            if (entity == null)\r\n                entity = new E()" +
                    ";\r\n\r\n            F f = new F();\r\n\t\t\tentity.BeginEdit();\r\n            f.InitBinde" +
                    "r(entity);\r\n            f._saveAction = saveAction;\r\n\t\t\treturn f;\r\n        }\r\n\r\n" +
                    "        public static void Edit(E entity, Func<FormType, E, bool> saveAction)\r\n " +
                    "       {\r\n            F f = SetUpForm(entity, saveAction);\r\n\t\t\tf.currentMode = F" +
                    "ormType.FormUpdate;\r\n            f.OnFormLoaded(f, f.currentMode);\r\n            " +
                    "f.ShowDialog();\r\n        }\r\n\r\n        public static void Add(Func<FormType, E, b" +
                    "ool> saveAction)\r\n        {\r\n            F f = SetUpForm(null, saveAction);\r\n   " +
                    "         f.currentMode = FormType.FormAdd;\r\n            f.OnFormLoaded(f, f.curr" +
                    "entMode);\r\n            f.ShowDialog();\r\n        }\r\n\r\n        protected virtual v" +
                    "oid OnFormLoaded(object sender, FormType e)\r\n        {\r\n        }\r\n\r\n        pro" +
                    "tected virtual void InitBinder(E entity)\r\n        {\r\n            bindingSourceIt" +
                    "em.DataSource = entity;\r\n        }\r\n\r\n        private void SaveChange()\r\n       " +
                    " {\r\n            var item = bindingSourceItem.Current as E;\r\n            var succ" +
                    "ess = _saveAction.Invoke(currentMode, item);\r\n\r\n\t\t\tif (success)\r\n\t\t\t{\r\n\t\t\t\titem." +
                    "EndEdit();\r\n\t\t\t}\r\n\t\t\telse\r\n\t\t\t{\r\n\t\t\t\titem.CancelEdit();\r\n\t\t\t}\r\n        }\r\n\r\n    " +
                    "    private void UndoChange()\r\n        {\r\n            var item = bindingSourceIt" +
                    "em.Current as E;\r\n            item.CancelEdit();\r\n        }\r\n\r\n        private v" +
                    "oid toolStripButtonSave_Click(object sender, EventArgs e)\r\n        {\r\n\t\t\tValidat" +
                    "e();\r\n            SaveChange();\r\n            this.Close();\r\n        }\r\n\r\n       " +
                    " private void toolStripButtonUndo_Click(object sender, EventArgs e)\r\n        {\r\n" +
                    "            UndoChange();\r\n        }\r\n\r\n        private void EditDataForm_FormCl" +
                    "osing(object sender, FormClosingEventArgs e)\r\n        {\r\n            UndoChange(" +
                    ");\r\n        }\r\n    }\r\n\r\n    public enum FormType\r\n    {\r\n        FormAdd,\r\n     " +
                    "   FormUpdate\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
