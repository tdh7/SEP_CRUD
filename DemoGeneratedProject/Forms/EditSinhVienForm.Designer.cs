namespace DemoGeneratedProject.Forms
{
    partial class EditSinhVienForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.textBoxDiemTB = new System.Windows.Forms.TextBox();
            this.textBoxMSSV = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 13);
            label1.TabIndex = 6;
            label1.Text = "Ho Ten";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 13);
            label2.TabIndex = 6;
            label2.Text = "Diem TB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 189);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 13);
            label3.TabIndex = 6;
            label3.Text = "MSSV";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(90, 50);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(130, 20);
            this.textBoxHoTen.TabIndex = 1;
            // 
            // textBoxDiemTB
            // 
            this.textBoxDiemTB.Location = new System.Drawing.Point(90, 120);
            this.textBoxDiemTB.Name = "textBoxDiemTB";
            this.textBoxDiemTB.Size = new System.Drawing.Size(130, 20);
            this.textBoxDiemTB.TabIndex = 2;
            // 
            // textBoxMSSV
            // 
            this.textBoxMSSV.Location = new System.Drawing.Point(92, 182);
            this.textBoxMSSV.Name = "textBoxMSSV";
            this.textBoxMSSV.Size = new System.Drawing.Size(130, 20);
            this.textBoxMSSV.TabIndex = 3;
            // 
            // EditSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(234, 276);
            this.Controls.Add(this.textBoxMSSV);
            this.Controls.Add(this.textBoxDiemTB);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "EditSinhVienForm";
            this.Controls.SetChildIndex(label1, 0);
            this.Controls.SetChildIndex(label2, 0);
            this.Controls.SetChildIndex(label3, 0);
            this.Controls.SetChildIndex(this.textBoxHoTen, 0);
            this.Controls.SetChildIndex(this.textBoxDiemTB, 0);
            this.Controls.SetChildIndex(this.textBoxMSSV, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.TextBox textBoxDiemTB;
        private System.Windows.Forms.TextBox textBoxMSSV;
    }
}