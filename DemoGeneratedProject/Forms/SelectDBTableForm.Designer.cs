﻿namespace DemoGeneratedProject.Forms
{
    partial class SelectDBTableForm
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
            this.listBoxDBTableName = new System.Windows.Forms.ListBox();
            this.buttonViewTable = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDBTableName
            // 
            this.listBoxDBTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDBTableName.FormattingEnabled = true;
            this.listBoxDBTableName.Location = new System.Drawing.Point(12, 74);
            this.listBoxDBTableName.Name = "listBoxDBTableName";
            this.listBoxDBTableName.Size = new System.Drawing.Size(312, 420);
            this.listBoxDBTableName.TabIndex = 1;
            // 
            // buttonViewTable
            // 
            this.buttonViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewTable.Enabled = false;
            this.buttonViewTable.Location = new System.Drawing.Point(249, 26);
            this.buttonViewTable.Name = "buttonViewTable";
            this.buttonViewTable.Size = new System.Drawing.Size(75, 22);
            this.buttonViewTable.TabIndex = 2;
            this.buttonViewTable.Text = "View Table";
            this.buttonViewTable.UseVisualStyleBackColor = true;
            this.buttonViewTable.Click += new System.EventHandler(this.buttonViewTable_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(336, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonConnect.Image = global::DemoGeneratedProject.Properties.Resources.Connect_16x;
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonConnect.Text = "Connect to DB Server";
            this.toolStripButtonConnect.Click += new System.EventHandler(this.toolStripButtonConnect_Click);
            // 
            // SelectDBTableForm
            // 
            this.AcceptButton = this.buttonViewTable;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(336, 506);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonViewTable);
            this.Controls.Add(this.listBoxDBTableName);
            this.Name = "SelectDBTableForm";
            this.Text = "Select Table";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Shown += new System.EventHandler(this.SelectDBTableForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDBTableName;
        private System.Windows.Forms.Button buttonViewTable;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect;
    }
}
