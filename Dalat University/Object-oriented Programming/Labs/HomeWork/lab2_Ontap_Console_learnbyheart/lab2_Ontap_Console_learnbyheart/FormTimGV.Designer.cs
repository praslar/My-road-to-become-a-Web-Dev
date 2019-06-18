namespace lab2_Ontap_Console_learnbyheart
{
    partial class FormTimGV
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
            this.groupBoxtimTheo = new System.Windows.Forms.GroupBox();
            this.radioButtonmaGV = new System.Windows.Forms.RadioButton();
            this.radioButtonhoTen = new System.Windows.Forms.RadioButton();
            this.radioButtonSDT = new System.Windows.Forms.RadioButton();
            this.labeltim = new System.Windows.Forms.Label();
            this.textBoxstrTim = new System.Windows.Forms.TextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.groupBoxtimTheo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxtimTheo
            // 
            this.groupBoxtimTheo.Controls.Add(this.radioButtonSDT);
            this.groupBoxtimTheo.Controls.Add(this.radioButtonhoTen);
            this.groupBoxtimTheo.Controls.Add(this.radioButtonmaGV);
            this.groupBoxtimTheo.Location = new System.Drawing.Point(14, 12);
            this.groupBoxtimTheo.Name = "groupBoxtimTheo";
            this.groupBoxtimTheo.Size = new System.Drawing.Size(540, 65);
            this.groupBoxtimTheo.TabIndex = 0;
            this.groupBoxtimTheo.TabStop = false;
            this.groupBoxtimTheo.Text = "Tìm theo";
            // 
            // radioButtonmaGV
            // 
            this.radioButtonmaGV.AutoSize = true;
            this.radioButtonmaGV.Location = new System.Drawing.Point(59, 22);
            this.radioButtonmaGV.Name = "radioButtonmaGV";
            this.radioButtonmaGV.Size = new System.Drawing.Size(63, 20);
            this.radioButtonmaGV.TabIndex = 0;
            this.radioButtonmaGV.TabStop = true;
            this.radioButtonmaGV.Text = "Mã GV";
            this.radioButtonmaGV.UseVisualStyleBackColor = true;
            this.radioButtonmaGV.CheckedChanged += new System.EventHandler(this.radioButtonmaGV_CheckedChanged);
            // 
            // radioButtonhoTen
            // 
            this.radioButtonhoTen.AutoSize = true;
            this.radioButtonhoTen.Location = new System.Drawing.Point(209, 22);
            this.radioButtonhoTen.Name = "radioButtonhoTen";
            this.radioButtonhoTen.Size = new System.Drawing.Size(67, 20);
            this.radioButtonhoTen.TabIndex = 0;
            this.radioButtonhoTen.TabStop = true;
            this.radioButtonhoTen.Text = "Họ Tên";
            this.radioButtonhoTen.UseVisualStyleBackColor = true;
            this.radioButtonhoTen.CheckedChanged += new System.EventHandler(this.radioButtonhoTen_CheckedChanged);
            // 
            // radioButtonSDT
            // 
            this.radioButtonSDT.AutoSize = true;
            this.radioButtonSDT.Location = new System.Drawing.Point(324, 22);
            this.radioButtonSDT.Name = "radioButtonSDT";
            this.radioButtonSDT.Size = new System.Drawing.Size(107, 20);
            this.radioButtonSDT.TabIndex = 0;
            this.radioButtonSDT.TabStop = true;
            this.radioButtonSDT.Text = "Số Điện Thoại";
            this.radioButtonSDT.UseVisualStyleBackColor = true;
            this.radioButtonSDT.CheckedChanged += new System.EventHandler(this.radioButtonSDT_CheckedChanged);
            // 
            // labeltim
            // 
            this.labeltim.AutoSize = true;
            this.labeltim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltim.Location = new System.Drawing.Point(10, 90);
            this.labeltim.Name = "labeltim";
            this.labeltim.Size = new System.Drawing.Size(37, 19);
            this.labeltim.TabIndex = 1;
            this.labeltim.Text = "Tìm";
            // 
            // textBoxstrTim
            // 
            this.textBoxstrTim.Location = new System.Drawing.Point(139, 90);
            this.textBoxstrTim.Name = "textBoxstrTim";
            this.textBoxstrTim.Size = new System.Drawing.Size(346, 23);
            this.textBoxstrTim.TabIndex = 2;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(491, 90);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(65, 23);
            this.buttonsearch.TabIndex = 3;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // FormTimGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 123);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.textBoxstrTim);
            this.Controls.Add(this.labeltim);
            this.Controls.Add(this.groupBoxtimTheo);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormTimGV";
            this.Text = "Tìm thông tin giáo viên";
            this.groupBoxtimTheo.ResumeLayout(false);
            this.groupBoxtimTheo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxtimTheo;
        private System.Windows.Forms.RadioButton radioButtonSDT;
        private System.Windows.Forms.RadioButton radioButtonhoTen;
        private System.Windows.Forms.RadioButton radioButtonmaGV;
        private System.Windows.Forms.Label labeltim;
        private System.Windows.Forms.TextBox textBoxstrTim;
        private System.Windows.Forms.Button buttonsearch;
    }
}