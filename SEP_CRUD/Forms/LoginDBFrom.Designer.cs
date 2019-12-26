namespace SEP_CRUD.Forms
{
    partial class LoginDBFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.comboBoxServerList = new System.Windows.Forms.ComboBox();
            this.loginInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDBName = new System.Windows.Forms.ComboBox();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 0;
            label1.Text = "Server Name:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 13);
            label2.TabIndex = 0;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(38, 98);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 13);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // comboBoxServerList
            // 
            this.comboBoxServerList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxServerList.FormattingEnabled = true;
            this.comboBoxServerList.Location = new System.Drawing.Point(145, 42);
            this.comboBoxServerList.Name = "comboBoxServerList";
            this.comboBoxServerList.Size = new System.Drawing.Size(222, 21);
            this.comboBoxServerList.TabIndex = 1;
            this.comboBoxServerList.DropDown += new System.EventHandler(this.comboBoxServerList_DropDown);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.Location = new System.Drawing.Point(145, 69);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(222, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(145, 95);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(222, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnect.Location = new System.Drawing.Point(204, 200);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(73, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(292, 200);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select a database";
            // 
            // comboBoxDBName
            // 
            this.comboBoxDBName.FormattingEnabled = true;
            this.comboBoxDBName.Location = new System.Drawing.Point(145, 142);
            this.comboBoxDBName.Name = "comboBoxDBName";
            this.comboBoxDBName.Size = new System.Drawing.Size(222, 21);
            this.comboBoxDBName.TabIndex = 7;
            this.comboBoxDBName.DropDown += new System.EventHandler(this.comboBoxDBName_DropDown);
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(25, 200);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(95, 23);
            this.buttonTestConnection.TabIndex = 8;
            this.buttonTestConnection.Text = "Test connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // LoginDBFrom
            // 
            this.AcceptButton = this.buttonConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(396, 244);
            this.Controls.Add(this.buttonTestConnection);
            this.Controls.Add(this.comboBoxDBName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.comboBoxServerList);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginDBFrom";
            this.Text = "Login to DB Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            ((System.ComponentModel.ISupportInitialize)(this.loginInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxServerList;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource loginInfoBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDBName;
        private System.Windows.Forms.Button buttonTestConnection;
    }
}
