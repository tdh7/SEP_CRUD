namespace SEP_CRUD.Forms
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
            this.listBoxDBTableName = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripButton();
            this.textBoxSlnName = new System.Windows.Forms.TextBox();
            this.projectInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPrjName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 13);
            label1.TabIndex = 4;
            label1.Text = "Which table you want to gen?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 297);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 13);
            label2.TabIndex = 5;
            label2.Text = "Solution Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 339);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 13);
            label3.TabIndex = 6;
            label3.Text = "Project Name";
            // 
            // listBoxDBTableName
            // 
            this.listBoxDBTableName.Enabled = false;
            this.listBoxDBTableName.FormattingEnabled = true;
            this.listBoxDBTableName.Location = new System.Drawing.Point(12, 74);
            this.listBoxDBTableName.Name = "listBoxDBTableName";
            this.listBoxDBTableName.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDBTableName.Size = new System.Drawing.Size(312, 186);
            this.listBoxDBTableName.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(249, 26);
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
            this.toolStrip1.Size = new System.Drawing.Size(336, 25);
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
            this.textBoxSlnName.Location = new System.Drawing.Point(113, 293);
            this.textBoxSlnName.Name = "textBoxSlnName";
            this.textBoxSlnName.Size = new System.Drawing.Size(211, 20);
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
            this.textBoxPrjName.Location = new System.Drawing.Point(113, 335);
            this.textBoxPrjName.Name = "textBoxPrjName";
            this.textBoxPrjName.Size = new System.Drawing.Size(211, 20);
            this.textBoxPrjName.TabIndex = 8;
            // 
            // ProjectInfoForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(336, 382);
            this.Controls.Add(this.textBoxPrjName);
            this.Controls.Add(this.textBoxSlnName);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxDBTableName);
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
        private System.Windows.Forms.BindingSource projectInfoBindingSource;
    }
}
