namespace Lab2_Ontap
{
    partial class FormTBGiaoVien
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
            this.labelThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelThongBao.Location = new System.Drawing.Point(65, 64);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(92, 16);
            this.labelThongBao.TabIndex = 0;
            this.labelThongBao.Text = "labelThongBao";
            // 
            // FormTBGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 506);
            this.Controls.Add(this.labelThongBao);
            this.Name = "FormTBGiaoVien";
            this.Text = "FormTBGiaoVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThongBao;
    }
}