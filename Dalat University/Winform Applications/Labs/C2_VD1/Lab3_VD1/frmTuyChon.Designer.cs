namespace Lab3_VD1
{
    partial class frmTuyChon
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
            this.radioButtonNamSinh = new System.Windows.Forms.RadioButton();
            this.radioButtonTen = new System.Windows.Forms.RadioButton();
            this.radioButtonMasv = new System.Windows.Forms.RadioButton();
            this.groupBoxTim = new System.Windows.Forms.GroupBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.textBoxChuoiTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSX = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNamSinh);
            this.groupBox1.Controls.Add(this.radioButtonTen);
            this.groupBox1.Controls.Add(this.radioButtonMasv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(370, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonNamSinh
            // 
            this.radioButtonNamSinh.AutoSize = true;
            this.radioButtonNamSinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNamSinh.Location = new System.Drawing.Point(213, 25);
            this.radioButtonNamSinh.Name = "radioButtonNamSinh";
            this.radioButtonNamSinh.Size = new System.Drawing.Size(87, 21);
            this.radioButtonNamSinh.TabIndex = 0;
            this.radioButtonNamSinh.Text = "Năm sinh";
            this.radioButtonNamSinh.UseVisualStyleBackColor = true;
            // 
            // radioButtonTen
            // 
            this.radioButtonTen.AutoSize = true;
            this.radioButtonTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTen.Location = new System.Drawing.Point(118, 25);
            this.radioButtonTen.Name = "radioButtonTen";
            this.radioButtonTen.Size = new System.Drawing.Size(52, 21);
            this.radioButtonTen.TabIndex = 0;
            this.radioButtonTen.Text = "Tên";
            this.radioButtonTen.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasv
            // 
            this.radioButtonMasv.AutoSize = true;
            this.radioButtonMasv.Checked = true;
            this.radioButtonMasv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMasv.Location = new System.Drawing.Point(8, 25);
            this.radioButtonMasv.Name = "radioButtonMasv";
            this.radioButtonMasv.Size = new System.Drawing.Size(70, 21);
            this.radioButtonMasv.TabIndex = 0;
            this.radioButtonMasv.TabStop = true;
            this.radioButtonMasv.Text = "Mã SV";
            this.radioButtonMasv.UseVisualStyleBackColor = true;
            // 
            // groupBoxTim
            // 
            this.groupBoxTim.Controls.Add(this.buttonTim);
            this.groupBoxTim.Controls.Add(this.textBoxChuoiTim);
            this.groupBoxTim.Controls.Add(this.label1);
            this.groupBoxTim.Location = new System.Drawing.Point(19, 104);
            this.groupBoxTim.Name = "groupBoxTim";
            this.groupBoxTim.Size = new System.Drawing.Size(370, 67);
            this.groupBoxTim.TabIndex = 1;
            this.groupBoxTim.TabStop = false;
            // 
            // buttonTim
            // 
            this.buttonTim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.Location = new System.Drawing.Point(273, 25);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(84, 23);
            this.buttonTim.TabIndex = 2;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // textBoxChuoiTim
            // 
            this.textBoxChuoiTim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChuoiTim.Location = new System.Drawing.Point(81, 24);
            this.textBoxChuoiTim.Name = "textBoxChuoiTim";
            this.textBoxChuoiTim.Size = new System.Drawing.Size(185, 25);
            this.textBoxChuoiTim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập";
            // 
            // buttonSX
            // 
            this.buttonSX.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSX.Location = new System.Drawing.Point(78, 189);
            this.buttonSX.Name = "buttonSX";
            this.buttonSX.Size = new System.Drawing.Size(84, 26);
            this.buttonSX.TabIndex = 2;
            this.buttonSX.Text = "Sắp xếp";
            this.buttonSX.UseVisualStyleBackColor = true;
            this.buttonSX.Click += new System.EventHandler(this.buttonSX_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(236, 189);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(84, 26);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // frmTuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 236);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonSX);
            this.Controls.Add(this.groupBoxTim);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTuyChon";
            this.Text = "frmTuyChon";
            this.Load += new System.EventHandler(this.frmTuyChon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTim.ResumeLayout(false);
            this.groupBoxTim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNamSinh;
        private System.Windows.Forms.RadioButton radioButtonTen;
        private System.Windows.Forms.RadioButton radioButtonMasv;
        private System.Windows.Forms.GroupBox groupBoxTim;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.TextBox textBoxChuoiTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSX;
        private System.Windows.Forms.Button buttonThoat;
    }
}