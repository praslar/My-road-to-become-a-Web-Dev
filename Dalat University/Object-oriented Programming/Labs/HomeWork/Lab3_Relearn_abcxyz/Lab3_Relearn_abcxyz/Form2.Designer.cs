namespace Lab3_Relearn_abcxyz
{
    partial class Form2
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
            this.radioButtonhoTen = new System.Windows.Forms.RadioButton();
            this.radioButtonmaSV = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsapXep = new System.Windows.Forms.Button();
            this.buttontim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonngaySinh);
            this.groupBox1.Controls.Add(this.radioButtonhoTen);
            this.groupBox1.Controls.Add(this.radioButtonmaSV);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(491, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonngaySinh
            // 
            this.radioButtonngaySinh.AutoSize = true;
            this.radioButtonngaySinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonngaySinh.Location = new System.Drawing.Point(349, 33);
            this.radioButtonngaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonngaySinh.Name = "radioButtonngaySinh";
            this.radioButtonngaySinh.Size = new System.Drawing.Size(113, 20);
            this.radioButtonngaySinh.TabIndex = 0;
            this.radioButtonngaySinh.Text = "Ngày Tổ Chức";
            this.radioButtonngaySinh.UseVisualStyleBackColor = true;
            this.radioButtonngaySinh.CheckedChanged += new System.EventHandler(this.radioButtonhoTen_CheckedChanged);
            // 
            // radioButtonhoTen
            // 
            this.radioButtonhoTen.AutoSize = true;
            this.radioButtonhoTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonhoTen.Location = new System.Drawing.Point(170, 33);
            this.radioButtonhoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonhoTen.Name = "radioButtonhoTen";
            this.radioButtonhoTen.Size = new System.Drawing.Size(126, 20);
            this.radioButtonhoTen.TabIndex = 0;
            this.radioButtonhoTen.Text = "Tiêu Đề Sự Kiện";
            this.radioButtonhoTen.UseVisualStyleBackColor = true;
            this.radioButtonhoTen.CheckedChanged += new System.EventHandler(this.radioButtonhoTen_CheckedChanged);
            // 
            // radioButtonmaSV
            // 
            this.radioButtonmaSV.AutoSize = true;
            this.radioButtonmaSV.Checked = true;
            this.radioButtonmaSV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonmaSV.Location = new System.Drawing.Point(21, 33);
            this.radioButtonmaSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonmaSV.Name = "radioButtonmaSV";
            this.radioButtonmaSV.Size = new System.Drawing.Size(97, 20);
            this.radioButtonmaSV.TabIndex = 0;
            this.radioButtonmaSV.TabStop = true;
            this.radioButtonmaSV.Text = "Mã Sự Kiện";
            this.radioButtonmaSV.UseVisualStyleBackColor = true;
            this.radioButtonmaSV.CheckedChanged += new System.EventHandler(this.radioButtonhoTen_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sự kiện";
            // 
            // buttonsapXep
            // 
            this.buttonsapXep.Location = new System.Drawing.Point(6, 19);
            this.buttonsapXep.Name = "buttonsapXep";
            this.buttonsapXep.Size = new System.Drawing.Size(75, 23);
            this.buttonsapXep.TabIndex = 4;
            this.buttonsapXep.Text = "Sắp xếp";
            this.buttonsapXep.UseVisualStyleBackColor = true;
            this.buttonsapXep.Click += new System.EventHandler(this.buttonsapXep_Click);
            // 
            // buttontim
            // 
            this.buttontim.Location = new System.Drawing.Point(320, 18);
            this.buttontim.Name = "buttontim";
            this.buttontim.Size = new System.Drawing.Size(75, 23);
            this.buttontim.TabIndex = 5;
            this.buttontim.Text = "Tìm";
            this.buttontim.UseVisualStyleBackColor = true;
            this.buttontim.Click += new System.EventHandler(this.buttontim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttontim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 51);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonsapXep);
            this.groupBox3.Location = new System.Drawing.Point(415, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 51);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 147);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Tùy chọn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonngaySinh;
        private System.Windows.Forms.RadioButton radioButtonhoTen;
        private System.Windows.Forms.RadioButton radioButtonmaSV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsapXep;
        private System.Windows.Forms.Button buttontim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}