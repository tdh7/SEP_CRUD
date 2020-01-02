namespace DemoGeneratedProject.Forms
{
    partial class TableListForm
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
            this.FlowListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Title = new System.Windows.Forms.Label();
            this.Notification = new System.Windows.Forms.Label();
            this.FlowListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowListPanel
            // 
            this.FlowListPanel.AutoScroll = true;
            this.FlowListPanel.BackColor = System.Drawing.Color.Transparent;
            this.FlowListPanel.Controls.Add(this.Title);
            this.FlowListPanel.Controls.Add(this.Notification);
            this.FlowListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowListPanel.ForeColor = System.Drawing.Color.White;
            this.FlowListPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowListPanel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.FlowListPanel.Name = "FlowListPanel";
            this.FlowListPanel.Size = new System.Drawing.Size(1067, 607);
            this.FlowListPanel.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.Title.Location = new System.Drawing.Point(3, 0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(16, 6, 32, 6);
            this.Title.Size = new System.Drawing.Size(991, 75);
            this.Title.TabIndex = 8;
            this.Title.Text = "Which data do you want to view ?";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Notification
            // 
            this.Notification.BackColor = System.Drawing.Color.Transparent;
            this.Notification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Notification.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.Notification.Location = new System.Drawing.Point(3, 75);
            this.Notification.Name = "Notification";
            this.Notification.Padding = new System.Windows.Forms.Padding(16, 6, 32, 6);
            this.Notification.Size = new System.Drawing.Size(1052, 523);
            this.Notification.TabIndex = 10;
            this.Notification.Text = "Sign In to Continue… ";
            this.Notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1067, 607);
            this.Controls.Add(this.FlowListPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximumSize = new System.Drawing.Size(1085, 654);
            this.MinimumSize = new System.Drawing.Size(1085, 654);
            this.Name = "TableListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FlowListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowListPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Notification;
    }
}