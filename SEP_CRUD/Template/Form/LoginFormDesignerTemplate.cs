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
    
    #line 1 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\LoginFormDesignerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class LoginFormDesignerTemplate : SharedFormDesignerTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("namespace ");
            
            #line 6 "C:\Users\Kim Ninh\Documents\Visual Studio 2017\Projects\sep_crud\SEP_CRUD\Template\Form\LoginFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Generator.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    partial class LoginForm\r\n    {\r\n        /// <summary>\r\n        /// Requi" +
                    "red designer variable.\r\n        /// </summary>\r\n        private System.Component" +
                    "Model.IContainer components = null;\r\n\r\n        /// <summary>\r\n        /// Clean " +
                    "up any resources being used.\r\n        /// </summary>\r\n        /// <param name=\"d" +
                    "isposing\">true if managed resources should be disposed; otherwise, false.</param" +
                    ">\r\n        protected override void Dispose(bool disposing)\r\n        {\r\n         " +
                    "   if (disposing && (components != null))\r\n            {\r\n                compon" +
                    "ents.Dispose();\r\n            }\r\n            base.Dispose(disposing);\r\n        }\r" +
                    "\n\r\n        #region Windows Form Designer generated code\r\n\r\n        /// <summary>" +
                    "\r\n        /// Required method for Designer support - do not modify\r\n        /// " +
                    "the contents of this method with the code editor.\r\n        /// </summary>\r\n     " +
                    "   private void InitializeComponent()\r\n        {\r\n            this.components = " +
                    "new System.ComponentModel.Container();\r\n            System.Windows.Forms.Label l" +
                    "abel1;\r\n            System.Windows.Forms.Label label2;\r\n            System.Windo" +
                    "ws.Forms.Label label3;\r\n            System.Windows.Forms.Label TitleLabel;\r\n    " +
                    "        this.Notification = new System.Windows.Forms.Label();\r\n            this." +
                    "comboBoxServerList = new System.Windows.Forms.ComboBox();\r\n            this.logi" +
                    "nInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);\r\n " +
                    "           this.textBoxLogin = new System.Windows.Forms.TextBox();\r\n            " +
                    "this.textBoxPassword = new System.Windows.Forms.TextBox();\r\n            this.but" +
                    "tonConnect = new System.Windows.Forms.Button();\r\n            this.buttonCancel =" +
                    " new System.Windows.Forms.Button();\r\n            label1 = new System.Windows.For" +
                    "ms.Label();\r\n            label2 = new System.Windows.Forms.Label();\r\n           " +
                    " label3 = new System.Windows.Forms.Label();\r\n            TitleLabel = new System" +
                    ".Windows.Forms.Label();\r\n            ((System.ComponentModel.ISupportInitialize)" +
                    "(this.loginInfoBindingSource)).BeginInit();\r\n            this.SuspendLayout();\r\n" +
                    "            // \r\n            // label1\r\n            // \r\n            label1.Anch" +
                    "or = System.Windows.Forms.AnchorStyles.Left;\r\n            label1.AutoSize = true" +
                    ";\r\n            label1.FlatStyle = System.Windows.Forms.FlatStyle.System;\r\n      " +
                    "      label1.Font = new System.Drawing.Font(\"Microsoft Sans Serif\", 11.25F, Syst" +
                    "em.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));\r\n" +
                    "            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44))" +
                    ")), ((int)(((byte)(44)))), ((int)(((byte)(44)))));\r\n            label1.Location " +
                    "= new System.Drawing.Point(38, 354);\r\n            label1.Margin = new System.Win" +
                    "dows.Forms.Padding(4, 0, 4, 0);\r\n            label1.Name = \"label1\";\r\n          " +
                    "  label1.Size = new System.Drawing.Size(121, 24);\r\n            label1.TabIndex =" +
                    " 0;\r\n            label1.Text = \"Server Name\";\r\n            // \r\n            // l" +
                    "abel2\r\n            // \r\n            label2.Anchor = System.Windows.Forms.AnchorS" +
                    "tyles.Left;\r\n            label2.AutoSize = true;\r\n            label2.FlatStyle =" +
                    " System.Windows.Forms.FlatStyle.System;\r\n            label2.Font = new System.Dr" +
                    "awing.Font(\"Microsoft Sans Serif\", 11.25F, System.Drawing.FontStyle.Regular, Sys" +
                    "tem.Drawing.GraphicsUnit.Point, ((byte)(0)));\r\n            label2.ForeColor = Sy" +
                    "stem.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)" +
                    "(((byte)(44)))));\r\n            label2.Location = new System.Drawing.Point(40, 17" +
                    "7);\r\n            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);\r\n" +
                    "            label2.Name = \"label2\";\r\n            label2.Size = new System.Drawin" +
                    "g.Size(97, 24);\r\n            label2.TabIndex = 0;\r\n            label2.Text = \"Us" +
                    "ername\";\r\n            // \r\n            // label3\r\n            // \r\n            l" +
                    "abel3.Anchor = System.Windows.Forms.AnchorStyles.Left;\r\n            label3.AutoS" +
                    "ize = true;\r\n            label3.FlatStyle = System.Windows.Forms.FlatStyle.Syste" +
                    "m;\r\n            label3.Font = new System.Drawing.Font(\"Microsoft Sans Serif\", 11" +
                    ".25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byt" +
                    "e)(0)));\r\n            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((" +
                    "byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));\r\n            label3" +
                    ".Location = new System.Drawing.Point(41, 255);\r\n            label3.Margin = new " +
                    "System.Windows.Forms.Padding(4, 0, 4, 0);\r\n            label3.Name = \"label3\";\r\n" +
                    "            label3.Size = new System.Drawing.Size(92, 24);\r\n            label3.T" +
                    "abIndex = 0;\r\n            label3.Text = \"Password\";\r\n            // \r\n          " +
                    "  // TitleLabel\r\n            // \r\n            TitleLabel.Font = new System.Drawi" +
                    "ng.Font(\"Microsoft Sans Serif\", 32F, System.Drawing.FontStyle.Regular, System.Dr" +
                    "awing.GraphicsUnit.Point, ((byte)(0)));\r\n            TitleLabel.ForeColor = Syst" +
                    "em.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)((" +
                    "(byte)(11)))));\r\n            TitleLabel.Location = new System.Drawing.Point(13, " +
                    "67);\r\n            TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, " +
                    "0);\r\n            TitleLabel.Name = \"TitleLabel\";\r\n            TitleLabel.Size = " +
                    "new System.Drawing.Size(195, 63);\r\n            TitleLabel.TabIndex = 7;\r\n       " +
                    "     TitleLabel.Text = \"Sign In\";\r\n            // \r\n            // Notification\r" +
                    "\n            // \r\n            this.Notification.Location = new System.Drawing.Po" +
                    "int(0, 0);\r\n            this.Notification.Name = \"Notification\";\r\n            th" +
                    "is.Notification.Size = new System.Drawing.Size(100, 23);\r\n            this.Notif" +
                    "ication.TabIndex = 0;\r\n            // \r\n            // comboBoxServerList\r\n     " +
                    "       // \r\n            this.comboBoxServerList.Anchor = System.Windows.Forms.An" +
                    "chorStyles.Left;\r\n            this.comboBoxServerList.Font = new System.Drawing." +
                    "Font(\"Microsoft Sans Serif\", 11.25F, System.Drawing.FontStyle.Regular, System.Dr" +
                    "awing.GraphicsUnit.Point, ((byte)(0)));\r\n            this.comboBoxServerList.For" +
                    "eColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)" +
                    "))), ((int)(((byte)(88)))));\r\n            this.comboBoxServerList.FormattingEnab" +
                    "led = true;\r\n            this.comboBoxServerList.Location = new System.Drawing.P" +
                    "oint(36, 384);\r\n            this.comboBoxServerList.Margin = new System.Windows." +
                    "Forms.Padding(4);\r\n            this.comboBoxServerList.Name = \"comboBoxServerLis" +
                    "t\";\r\n            this.comboBoxServerList.Size = new System.Drawing.Size(357, 32)" +
                    ";\r\n            this.comboBoxServerList.TabIndex = 3;\r\n            this.comboBoxS" +
                    "erverList.DropDown += new System.EventHandler(this.comboBoxServerList_DropDown);" +
                    "\r\n            // \r\n            // textBoxLogin\r\n            // \r\n            thi" +
                    "s.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;\r\n            thi" +
                    "s.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;\r\n    " +
                    "        this.textBoxLogin.Font = new System.Drawing.Font(\"Microsoft Sans Serif\"," +
                    " 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((" +
                    "byte)(0)));\r\n            this.textBoxLogin.ForeColor = System.Drawing.Color.From" +
                    "Argb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));\r\n   " +
                    "         this.textBoxLogin.Location = new System.Drawing.Point(38, 207);\r\n      " +
                    "      this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);\r\n         " +
                    "   this.textBoxLogin.Name = \"textBoxLogin\";\r\n            this.textBoxLogin.Size " +
                    "= new System.Drawing.Size(357, 29);\r\n            this.textBoxLogin.TabIndex = 1;" +
                    "\r\n            // \r\n            // textBoxPassword\r\n            // \r\n            " +
                    "this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;\r\n         " +
                    "   this.textBoxPassword.Font = new System.Drawing.Font(\"Microsoft Sans Serif\", 1" +
                    "1.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((by" +
                    "te)(0)));\r\n            this.textBoxPassword.ForeColor = System.Drawing.Color.Fro" +
                    "mArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));\r\n  " +
                    "          this.textBoxPassword.Location = new System.Drawing.Point(38, 284);\r\n  " +
                    "          this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);\r\n  " +
                    "          this.textBoxPassword.Name = \"textBoxPassword\";\r\n            this.textB" +
                    "oxPassword.PasswordChar = \'*\';\r\n            this.textBoxPassword.Size = new Syst" +
                    "em.Drawing.Size(357, 29);\r\n            this.textBoxPassword.TabIndex = 2;\r\n     " +
                    "       // \r\n            // buttonConnect\r\n            // \r\n            this.butt" +
                    "onConnect.Anchor = System.Windows.Forms.AnchorStyles.Left;\r\n            this.but" +
                    "tonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int" +
                    ")(((byte)(122)))), ((int)(((byte)(255)))));\r\n            this.buttonConnect.Flat" +
                    "Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((i" +
                    "nt)(((byte)(122)))), ((int)(((byte)(255)))));\r\n            this.buttonConnect.Fl" +
                    "atAppearance.BorderSize = 0;\r\n            this.buttonConnect.Font = new System.D" +
                    "rawing.Font(\"Microsoft Sans Serif\", 10F, System.Drawing.FontStyle.Regular, Syste" +
                    "m.Drawing.GraphicsUnit.Point, ((byte)(0)));\r\n            this.buttonConnect.Fore" +
                    "Color = System.Drawing.Color.White;\r\n            this.buttonConnect.Location = n" +
                    "ew System.Drawing.Point(284, 548);\r\n            this.buttonConnect.Margin = new " +
                    "System.Windows.Forms.Padding(4);\r\n            this.buttonConnect.Name = \"buttonC" +
                    "onnect\";\r\n            this.buttonConnect.Size = new System.Drawing.Size(106, 47)" +
                    ";\r\n            this.buttonConnect.TabIndex = 4;\r\n            this.buttonConnect." +
                    "Text = \"Continue\";\r\n            this.buttonConnect.UseVisualStyleBackColor = fal" +
                    "se;\r\n            this.buttonConnect.Click += new System.EventHandler(this.button" +
                    "Connect_Click);\r\n            // \r\n            // buttonCancel\r\n            // \r\n" +
                    "            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;\r\n" +
                    "            this.buttonCancel.BackColor = System.Drawing.Color.White;\r\n         " +
                    "   this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(" +
                    "((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));\r\n      " +
                    "      this.buttonCancel.Font = new System.Drawing.Font(\"Microsoft Sans Serif\", 1" +
                    "0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)" +
                    "(0)));\r\n            this.buttonCancel.ForeColor = System.Drawing.Color.Black;\r\n " +
                    "           this.buttonCancel.Location = new System.Drawing.Point(164, 548);\r\n   " +
                    "         this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);\r\n      " +
                    "      this.buttonCancel.Name = \"buttonCancel\";\r\n            this.buttonCancel.Si" +
                    "ze = new System.Drawing.Size(100, 47);\r\n            this.buttonCancel.TabIndex =" +
                    " 5;\r\n            this.buttonCancel.Text = \"Cancel\";\r\n            this.buttonCanc" +
                    "el.UseVisualStyleBackColor = false;\r\n            this.buttonCancel.Click += new " +
                    "System.EventHandler(this.buttonCancel_Click);\r\n            // \r\n            // L" +
                    "oginForm\r\n            // \r\n            this.AcceptButton = this.buttonConnect;\r\n" +
                    "            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);\r\n     " +
                    "       this.BackColor = System.Drawing.Color.White;\r\n            this.ClientSize" +
                    " = new System.Drawing.Size(430, 635);\r\n            this.Controls.Add(this.Notifi" +
                    "cation);\r\n            this.Controls.Add(TitleLabel);\r\n            this.Controls." +
                    "Add(this.buttonCancel);\r\n            this.Controls.Add(this.buttonConnect);\r\n   " +
                    "         this.Controls.Add(this.textBoxPassword);\r\n            this.Controls.Add" +
                    "(this.textBoxLogin);\r\n            this.Controls.Add(this.comboBoxServerList);\r\n " +
                    "           this.Controls.Add(label3);\r\n            this.Controls.Add(label2);\r\n " +
                    "           this.Controls.Add(label1);\r\n            this.Margin = new System.Wind" +
                    "ows.Forms.Padding(5);\r\n            this.MaximizeBox = false;\r\n            this.M" +
                    "aximumSize = new System.Drawing.Size(448, 682);\r\n            this.MinimizeBox = " +
                    "false;\r\n            this.MinimumSize = new System.Drawing.Size(448, 682);\r\n     " +
                    "       this.Name = \"LoginForm\";\r\n            this.ShowIcon = false;\r\n           " +
                    " this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;\r\n    " +
                    "        this.Text = \"Welcome back\";\r\n            this.FormClosed += new System.W" +
                    "indows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);\r\n            ((S" +
                    "ystem.ComponentModel.ISupportInitialize)(this.loginInfoBindingSource)).EndInit()" +
                    ";\r\n            this.ResumeLayout(false);\r\n            this.PerformLayout();\r\n\r\n " +
                    "       }\r\n\r\n        #endregion\r\n\r\n        private System.Windows.Forms.ComboBox " +
                    "comboBoxServerList;\r\n        private System.Windows.Forms.TextBox textBoxLogin;\r" +
                    "\n        private System.Windows.Forms.TextBox textBoxPassword;\r\n        private " +
                    "System.Windows.Forms.Button buttonConnect;\r\n        private System.Windows.Forms" +
                    ".Button buttonCancel;\r\n        private System.Windows.Forms.BindingSource loginI" +
                    "nfoBindingSource;\r\n        private System.Windows.Forms.Label Notification;\r\n   " +
                    " }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
