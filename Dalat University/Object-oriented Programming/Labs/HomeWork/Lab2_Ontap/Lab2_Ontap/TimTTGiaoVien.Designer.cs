namespace Lab2_Ontap
{
    partial class TimTTGiaoVien
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
            this.radioButtonmaGV = new System.Windows.Forms.RadioButton();
            this.radioButtonhoTen = new System.Windows.Forms.RadioButton();
            this.radioButtonSDT = new System.Windows.Forms.RadioButton();
            this.groupBoxTimTTGiaoVien = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.groupBoxTimTTGiaoVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonmaGV
            // 
            this.radioButtonmaGV.AutoSize = true;
            this.radioButtonmaGV.Location = new System.Drawing.Point(27, 23);
            this.radioButtonmaGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.radioButtonhoTen.Location = new System.Drawing.Point(206, 24);
            this.radioButtonhoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.radioButtonSDT.Location = new System.Drawing.Point(371, 24);
            this.radioButtonSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSDT.Name = "radioButtonSDT";
            this.radioButtonSDT.Size = new System.Drawing.Size(101, 20);
            this.radioButtonSDT.TabIndex = 0;
            this.radioButtonSDT.TabStop = true;
            this.radioButtonSDT.Text = "Số điện thoại";
            this.radioButtonSDT.UseVisualStyleBackColor = true;
            this.radioButtonSDT.CheckedChanged += new System.EventHandler(this.radioButtonSDT_CheckedChanged);
            // 
            // groupBoxTimTTGiaoVien
            // 
            this.groupBoxTimTTGiaoVien.Controls.Add(this.radioButtonSDT);
            this.groupBoxTimTTGiaoVien.Controls.Add(this.radioButtonhoTen);
            this.groupBoxTimTTGiaoVien.Controls.Add(this.radioButtonmaGV);
            this.groupBoxTimTTGiaoVien.Location = new System.Drawing.Point(14, 16);
            this.groupBoxTimTTGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTimTTGiaoVien.Name = "groupBoxTimTTGiaoVien";
            this.groupBoxTimTTGiaoVien.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTimTTGiaoVien.Size = new System.Drawing.Size(481, 66);
            this.groupBoxTimTTGiaoVien.TabIndex = 1;
            this.groupBoxTimTTGiaoVien.TabStop = false;
            this.groupBoxTimTTGiaoVien.Text = "Tìm theo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm";
            // 
            // textBoxTim
            // 
            this.textBoxTim.Location = new System.Drawing.Point(131, 94);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(273, 23);
            this.textBoxTim.TabIndex = 3;
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(420, 94);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 4;
            this.buttonTim.Text = "Search";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // TimTTGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 140);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBoxTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTimTTGiaoVien);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TimTTGiaoVien";
            this.Text = "TimTTGiaoVien";
            this.groupBoxTimTTGiaoVien.ResumeLayout(false);
            this.groupBoxTimTTGiaoVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonmaGV;
        private System.Windows.Forms.RadioButton radioButtonhoTen;
        private System.Windows.Forms.RadioButton radioButtonSDT;
        private System.Windows.Forms.GroupBox groupBoxTimTTGiaoVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.Button buttonTim;
    }
}