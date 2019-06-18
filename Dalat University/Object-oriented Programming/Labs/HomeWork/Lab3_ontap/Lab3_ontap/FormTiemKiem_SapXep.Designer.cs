namespace Lab3_ontap
{
    partial class FormTiemKiem_SapXep
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonngaySinh = new System.Windows.Forms.RadioButton();
            this.radioButtonmaSV = new System.Windows.Forms.RadioButton();
            this.radioButtonhoTen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonsort = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.groupBoxsearch = new System.Windows.Forms.GroupBox();
            this.groupBoxsort = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxsearch.SuspendLayout();
            this.groupBoxsort.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonngaySinh);
            this.groupBox1.Controls.Add(this.radioButtonmaSV);
            this.groupBox1.Controls.Add(this.radioButtonhoTen);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(511, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonngaySinh
            // 
            this.radioButtonngaySinh.AutoSize = true;
            this.radioButtonngaySinh.Location = new System.Drawing.Point(322, 23);
            this.radioButtonngaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonngaySinh.Name = "radioButtonngaySinh";
            this.radioButtonngaySinh.Size = new System.Drawing.Size(83, 20);
            this.radioButtonngaySinh.TabIndex = 0;
            this.radioButtonngaySinh.Text = "Ngày Sinh";
            this.radioButtonngaySinh.UseVisualStyleBackColor = true;
            this.radioButtonngaySinh.CheckedChanged += new System.EventHandler(this.radioButtonngaySinh_CheckedChanged);
            // 
            // radioButtonmaSV
            // 
            this.radioButtonmaSV.AutoSize = true;
            this.radioButtonmaSV.Location = new System.Drawing.Point(187, 23);
            this.radioButtonmaSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonmaSV.Name = "radioButtonmaSV";
            this.radioButtonmaSV.Size = new System.Drawing.Size(63, 20);
            this.radioButtonmaSV.TabIndex = 0;
            this.radioButtonmaSV.Text = "Mã SV";
            this.radioButtonmaSV.UseVisualStyleBackColor = true;
            this.radioButtonmaSV.CheckedChanged += new System.EventHandler(this.radioButtonmaSV_CheckedChanged);
            // 
            // radioButtonhoTen
            // 
            this.radioButtonhoTen.AutoSize = true;
            this.radioButtonhoTen.Checked = true;
            this.radioButtonhoTen.Location = new System.Drawing.Point(35, 23);
            this.radioButtonhoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonhoTen.Name = "radioButtonhoTen";
            this.radioButtonhoTen.Size = new System.Drawing.Size(67, 20);
            this.radioButtonhoTen.TabIndex = 0;
            this.radioButtonhoTen.TabStop = true;
            this.radioButtonhoTen.Text = "Họ Tên";
            this.radioButtonhoTen.UseVisualStyleBackColor = true;
            this.radioButtonhoTen.CheckedChanged += new System.EventHandler(this.radioButtonhoTen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(141, 26);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(347, 23);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // buttoncancel
            // 
            this.buttoncancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttoncancel.Location = new System.Drawing.Point(636, 15);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(25, 128);
            this.buttoncancel.TabIndex = 4;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttonsort
            // 
            this.buttonsort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsort.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonsort.Location = new System.Drawing.Point(11, 23);
            this.buttonsort.Name = "buttonsort";
            this.buttonsort.Size = new System.Drawing.Size(74, 27);
            this.buttonsort.TabIndex = 4;
            this.buttonsort.Text = "Sort";
            this.buttonsort.UseVisualStyleBackColor = true;
            this.buttonsort.Click += new System.EventHandler(this.buttonsort_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonsearch.Location = new System.Drawing.Point(13, 18);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(74, 27);
            this.buttonsearch.TabIndex = 4;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // groupBoxsearch
            // 
            this.groupBoxsearch.Controls.Add(this.buttonsearch);
            this.groupBoxsearch.Location = new System.Drawing.Point(532, 13);
            this.groupBoxsearch.Name = "groupBoxsearch";
            this.groupBoxsearch.Size = new System.Drawing.Size(98, 53);
            this.groupBoxsearch.TabIndex = 5;
            this.groupBoxsearch.TabStop = false;
            // 
            // groupBoxsort
            // 
            this.groupBoxsort.Controls.Add(this.buttonsort);
            this.groupBoxsort.Location = new System.Drawing.Point(534, 73);
            this.groupBoxsort.Name = "groupBoxsort";
            this.groupBoxsort.Size = new System.Drawing.Size(98, 70);
            this.groupBoxsort.TabIndex = 6;
            this.groupBoxsort.TabStop = false;
            // 
            // FormTiemKiem_SapXep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 149);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxsearch);
            this.Controls.Add(this.groupBoxsort);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTiemKiem_SapXep";
            this.Text = "FormTiemKiem_SapXep";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxsearch.ResumeLayout(false);
            this.groupBoxsort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonngaySinh;
        private System.Windows.Forms.RadioButton radioButtonmaSV;
        private System.Windows.Forms.RadioButton radioButtonhoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonsort;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.GroupBox groupBoxsearch;
        private System.Windows.Forms.GroupBox groupBoxsort;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}