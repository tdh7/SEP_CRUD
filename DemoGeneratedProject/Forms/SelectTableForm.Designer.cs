﻿namespace DemoGeneratedProject.Forms
{
    partial class SelectTableForm
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
            this.listBoxDBTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDBTableName.FormattingEnabled = true;
            this.listBoxDBTableName.ItemHeight = 16;
            this.listBoxDBTableName.Location = new System.Drawing.Point(0, 43);
            this.listBoxDBTableName.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDBTableName.Name = "listBoxDBTableName";
            this.listBoxDBTableName.Size = new System.Drawing.Size(431, 512);
            this.listBoxDBTableName.TabIndex = 1;
            this.listBoxDBTableName.SelectedIndexChanged += new System.EventHandler(this.listBoxDBTableName_SelectedIndexChanged);
            // 
            // buttonViewTable
            // 
            this.buttonViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewTable.BackColor = System.Drawing.Color.White;
            this.buttonViewTable.Enabled = false;
            this.buttonViewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewTable.ForeColor = System.Drawing.Color.Black;
            this.buttonViewTable.Location = new System.Drawing.Point(129, 574);
            this.buttonViewTable.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewTable.Name = "buttonViewTable";
            this.buttonViewTable.Size = new System.Drawing.Size(155, 48);
            this.buttonViewTable.TabIndex = 2;
            this.buttonViewTable.Text = "View Table";
            this.buttonViewTable.UseVisualStyleBackColor = false;
            this.buttonViewTable.Click += new System.EventHandler(this.buttonViewTable_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnect});
            this.toolStrip1.Location = new System.Drawing.Point(21, -5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(361, 44);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonConnect.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(349, 41);
            this.toolStripButtonConnect.Text = "Connect to Database Server";
            this.toolStripButtonConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButtonConnect.Click += new System.EventHandler(this.toolStripButtonConnect_Click);
            // 
            // SelectTableForm
            // 
            this.AcceptButton = this.buttonViewTable;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 635);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonViewTable);
            this.Controls.Add(this.listBoxDBTableName);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(448, 682);
            this.MinimumSize = new System.Drawing.Size(448, 682);
            this.Name = "SelectTableForm";
            this.ShowIcon = false;
            this.Text = "Dashboard";
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
