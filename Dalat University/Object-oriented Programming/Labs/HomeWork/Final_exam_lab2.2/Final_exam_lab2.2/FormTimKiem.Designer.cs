namespace Final_exam_lab2._2
{
    partial class FormTimKiem
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
            this.radioButtonSDT = new System.Windows.Forms.RadioButton();
            this.radioButtonhoTen = new System.Windows.Forms.RadioButton();
            this.radioButtonmaGV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxtim = new System.Windows.Forms.TextBox();
            this.buttonok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSDT);
            this.groupBox1.Controls.Add(this.radioButtonhoTen);
            this.groupBox1.Controls.Add(this.radioButtonmaGV);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonSDT
            // 
            this.radioButtonSDT.AutoSize = true;
            this.radioButtonSDT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSDT.Location = new System.Drawing.Point(289, 32);
            this.radioButtonSDT.Name = "radioButtonSDT";
            this.radioButtonSDT.Size = new System.Drawing.Size(54, 22);
            this.radioButtonSDT.TabIndex = 0;
            this.radioButtonSDT.Text = "SDT";
            this.radioButtonSDT.UseVisualStyleBackColor = true;
            this.radioButtonSDT.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonhoTen
            // 
            this.radioButtonhoTen.AutoSize = true;
            this.radioButtonhoTen.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonhoTen.Location = new System.Drawing.Point(147, 32);
            this.radioButtonhoTen.Name = "radioButtonhoTen";
            this.radioButtonhoTen.Size = new System.Drawing.Size(75, 22);
            this.radioButtonhoTen.TabIndex = 0;
            this.radioButtonhoTen.Text = "Họ Tên";
            this.radioButtonhoTen.UseVisualStyleBackColor = true;
            this.radioButtonhoTen.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonmaGV
            // 
            this.radioButtonmaGV.AutoSize = true;
            this.radioButtonmaGV.Checked = true;
            this.radioButtonmaGV.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonmaGV.Location = new System.Drawing.Point(20, 32);
            this.radioButtonmaGV.Name = "radioButtonmaGV";
            this.radioButtonmaGV.Size = new System.Drawing.Size(70, 22);
            this.radioButtonmaGV.TabIndex = 0;
            this.radioButtonmaGV.TabStop = true;
            this.radioButtonmaGV.Text = "Mã GV";
            this.radioButtonmaGV.UseVisualStyleBackColor = true;
            this.radioButtonmaGV.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã GV";
            // 
            // textBoxtim
            // 
            this.textBoxtim.Location = new System.Drawing.Point(74, 117);
            this.textBoxtim.Name = "textBoxtim";
            this.textBoxtim.Size = new System.Drawing.Size(296, 20);
            this.textBoxtim.TabIndex = 2;
            // 
            // buttonok
            // 
            this.buttonok.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonok.Location = new System.Drawing.Point(380, 111);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(50, 31);
            this.buttonok.TabIndex = 3;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 157);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.textBoxtim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTimKiem";
            this.Text = "FormTimKiem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSDT;
        private System.Windows.Forms.RadioButton radioButtonhoTen;
        private System.Windows.Forms.RadioButton radioButtonmaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxtim;
        private System.Windows.Forms.Button buttonok;
    }
}