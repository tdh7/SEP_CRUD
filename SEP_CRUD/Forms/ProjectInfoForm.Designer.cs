﻿namespace SEP_CRUD.Forms
{
    partial class ProjectInfoForm
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
            System.Windows.Forms.Label label4;
            this.listBoxDBTableName = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripButton();
            this.textBoxSlnName = new System.Windows.Forms.TextBox();
            this.projectInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPrjName = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxCreateDirectoryForSln = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 13);
            label1.TabIndex = 4;
            label1.Text = "Which forms you want to gen?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 380);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 13);
            label2.TabIndex = 5;
            label2.Text = "Solution Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 292);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 13);
            label3.TabIndex = 6;
            label3.Text = "Project Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 337);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 13);
            label4.TabIndex = 9;
            label4.Text = "Location";
            // 
            // listBoxDBTableName
            // 
            this.listBoxDBTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDBTableName.Enabled = false;
            this.listBoxDBTableName.FormattingEnabled = true;
            this.listBoxDBTableName.Location = new System.Drawing.Point(12, 74);
            this.listBoxDBTableName.Name = "listBoxDBTableName";
            this.listBoxDBTableName.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDBTableName.Size = new System.Drawing.Size(660, 186);
            this.listBoxDBTableName.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(597, 417);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 22);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonConnect.Image = global::SEP_CRUD.Properties.Resources.Connect_16x;
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonConnect.Text = "Connect to DB Server";
            this.toolStripButtonConnect.Click += new System.EventHandler(this.toolStripButtonConnect_Click);
            // 
            // textBoxSlnName
            // 
            this.textBoxSlnName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectInfoBindingSource, "SolutionName", true));
            this.textBoxSlnName.Enabled = false;
            this.textBoxSlnName.Location = new System.Drawing.Point(105, 377);
            this.textBoxSlnName.Name = "textBoxSlnName";
            this.textBoxSlnName.Size = new System.Drawing.Size(385, 20);
            this.textBoxSlnName.TabIndex = 7;
            // 
            // projectInfoBindingSource
            // 
            this.projectInfoBindingSource.DataSource = typeof(SEP_CRUD.Forms.ProjectInfo);
            // 
            // textBoxPrjName
            // 
            this.textBoxPrjName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectInfoBindingSource, "ProjectName", true));
            this.textBoxPrjName.Enabled = false;
            this.textBoxPrjName.Location = new System.Drawing.Point(105, 288);
            this.textBoxPrjName.Name = "textBoxPrjName";
            this.textBoxPrjName.Size = new System.Drawing.Size(385, 20);
            this.textBoxPrjName.TabIndex = 8;
            // 
            // textBoxPath
            // 
            this.textBoxPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectInfoBindingSource, "Path", true));
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(105, 333);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(385, 20);
            this.textBoxPath.TabIndex = 10;
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowser.AutoSize = true;
            this.buttonBrowser.Enabled = false;
            this.buttonBrowser.Location = new System.Drawing.Point(514, 333);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(81, 23);
            this.buttonBrowser.TabIndex = 11;
            this.buttonBrowser.Text = "Browser...";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // checkBoxCreateDirectoryForSln
            // 
            this.checkBoxCreateDirectoryForSln.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCreateDirectoryForSln.AutoSize = true;
            this.checkBoxCreateDirectoryForSln.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.projectInfoBindingSource, "DirectoryForSolution", true));
            this.checkBoxCreateDirectoryForSln.Enabled = false;
            this.checkBoxCreateDirectoryForSln.Location = new System.Drawing.Point(514, 380);
            this.checkBoxCreateDirectoryForSln.Name = "checkBoxCreateDirectoryForSln";
            this.checkBoxCreateDirectoryForSln.Size = new System.Drawing.Size(154, 17);
            this.checkBoxCreateDirectoryForSln.TabIndex = 12;
            this.checkBoxCreateDirectoryForSln.Text = "Create directory for solution";
            this.checkBoxCreateDirectoryForSln.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(514, 416);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ProjectInfoForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.checkBoxCreateDirectoryForSln);
            this.Controls.Add(this.buttonBrowser);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(label4);
            this.Controls.Add(this.textBoxPrjName);
            this.Controls.Add(this.textBoxSlnName);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxDBTableName);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "ProjectInfoForm";
            this.Text = "Project Info";
            this.Shown += new System.EventHandler(this.ProjectInfoForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDBTableName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect;
        private System.Windows.Forms.TextBox textBoxSlnName;
        private System.Windows.Forms.TextBox textBoxPrjName;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.BindingSource projectInfoBindingSource;
        private System.Windows.Forms.CheckBox checkBoxCreateDirectoryForSln;
        private System.Windows.Forms.Button buttonCancel;
    }
}
