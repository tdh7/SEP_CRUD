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
    
    #line 1 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\SelectTableFormTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class SelectTableFormTemplate : SharedFormGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.ComponentModel;\r\nu" +
                    "sing System.Data;\r\nusing System.Data.SqlClient;\r\nusing System.Drawing;\r\nusing Sy" +
                    "stem.Runtime.CompilerServices;\r\nusing System.Text;\r\nusing System.Windows.Forms;\r" +
                    "\n\r\nnamespace ");
            
            #line 16 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\SelectTableFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class SelectTableForm : BaseForm\r\n    {\r\n        private " +
                    "string connectionStr;\r\n\r\n        public SelectTableForm()\r\n        {\r\n          " +
                    "  InitializeComponent();\r\n        }\r\n\r\n        private void OnLoginSuccessHandle" +
                    "r(object sender, string e)\r\n        {\r\n            this.connectionStr = e;\r\n    " +
                    "        \r\n            listBoxDBTableName.DataSource = getTableName();\r\n         " +
                    "   listBoxDBTableName.DisplayMember = \"TABLE_NAME\";\r\n            listBoxDBTableN" +
                    "ame.ValueMember = \"TABLE_NAME\";\r\n\r\n            buttonViewTable.Enabled = true;\r\n" +
                    "            toolStripButtonConnect.Enabled = false;\r\n        }\r\n\r\n        privat" +
                    "e DataTable getTableName()\r\n        {\r\n            var sqlQuery = \"SELECT TABLE_" +
                    "NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = \'BASE TABLE\'\";\r\n         " +
                    "   var dt = new DataTable();\r\n            using (var sqlConnection = new SqlConn" +
                    "ection(connectionStr))\r\n            {\r\n                sqlConnection.Open();\r\n  " +
                    "              var sqlCommand = new SqlCommand(sqlQuery, sqlConnection);\r\n       " +
                    "         var adapter = new SqlDataAdapter(sqlCommand);\r\n                adapter." +
                    "Fill(dt);\r\n            }\r\n            return dt;\r\n        }\r\n\r\n        private v" +
                    "oid buttonViewTable_Click(object sender, EventArgs e)\r\n        {\r\n            st" +
                    "ring tableName = (string) listBoxDBTableName.SelectedValue;\r\n            Message" +
                    "Box.Show($\"Table {tableName} has chosen\");\r\n\r\n\t\t\t// TODO: open form\r\n           " +
                    " var form = ViewFormFactory.getFormByTableName(tableName);\r\n\t\t\tform.Show();\r\n   " +
                    "     }\r\n\r\n        private void SelectDBTableForm_Shown(object sender, EventArgs " +
                    "e)\r\n        {\r\n            OpenLoginForm();\r\n        }\r\n\r\n        private void O" +
                    "penLoginForm()\r\n        {\r\n            LoginForm form = new LoginForm();\r\n      " +
                    "      form.OnLoginSuccessHandler = OnLoginSuccessHandler;\r\n            form.Show" +
                    "Dialog(); // Force user focus on login form\r\n        }\r\n\r\n        private void t" +
                    "oolStripButtonConnect_Click(object sender, EventArgs e)\r\n        {\r\n            " +
                    "  OpenLoginForm();\r\n        }\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
