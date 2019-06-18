namespace relearn_lab2_abcxyz
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
            this.buttonTim = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonmaSo = new System.Windows.Forms.RadioButton();
            this.groupBoxkieutim = new System.Windows.Forms.GroupBox();
            this.radioButtonsoDT = new System.Windows.Forms.RadioButton();
            this.radioButtonhoTen = new System.Windows.Forms.RadioButton();
            this.groupBoxkieutim.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(424, 117);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 7;
            this.buttonTim.Text = "OK";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Số";
            // 
            // radioButtonmaSo
            // 
            this.radioButtonmaSo.AutoSize = true;
            this.radioButtonmaSo.Checked = true;
            this.radioButtonmaSo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonmaSo.Location = new System.Drawing.Point(33, 34);
            this.radioButtonmaSo.Name = "radioButtonmaSo";
            this.radioButtonmaSo.Size = new System.Drawing.Size(70, 23);
            this.radioButtonmaSo.TabIndex = 3;
            this.radioButtonmaSo.TabStop = true;
            this.radioButtonmaSo.Text = "Mã Số";
            this.radioButtonmaSo.UseVisualStyleBackColor = true;
            this.radioButtonmaSo.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxkieutim
            // 
            this.groupBoxkieutim.Controls.Add(this.radioButtonsoDT);
            this.groupBoxkieutim.Controls.Add(this.radioButtonhoTen);
            this.groupBoxkieutim.Controls.Add(this.radioButtonmaSo);
            this.groupBoxkieutim.Location = new System.Drawing.Point(12, 12);
            this.groupBoxkieutim.Name = "groupBoxkieutim";
            this.groupBoxkieutim.Size = new System.Drawing.Size(487, 83);
            this.groupBoxkieutim.TabIndex = 8;
            this.groupBoxkieutim.TabStop = false;
            // 
            // radioButtonsoDT
            // 
            this.radioButtonsoDT.AutoSize = true;
            this.radioButtonsoDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonsoDT.Location = new System.Drawing.Point(364, 34);
            this.radioButtonsoDT.Name = "radioButtonsoDT";
            this.radioButtonsoDT.Size = new System.Drawing.Size(71, 23);
            this.radioButtonsoDT.TabIndex = 3;
            this.radioButtonsoDT.Text = "Số ĐT";
            this.radioButtonsoDT.UseVisualStyleBackColor = true;
            this.radioButtonsoDT.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonhoTen
            // 
            this.radioButtonhoTen.AutoSize = true;
            this.radioButtonhoTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonhoTen.Location = new System.Drawing.Point(188, 34);
            this.radioButtonhoTen.Name = "radioButtonhoTen";
            this.radioButtonhoTen.Size = new System.Drawing.Size(79, 23);
            this.radioButtonhoTen.TabIndex = 3;
            this.radioButtonhoTen.Text = "Họ Tên";
            this.radioButtonhoTen.UseVisualStyleBackColor = true;
            this.radioButtonhoTen.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // FormTimGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 152);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxkieutim);
            this.Name = "FormTimGV";
            this.Text = "FormTimGV";
            this.groupBoxkieutim.ResumeLayout(false);
            this.groupBoxkieutim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonmaSo;
        private System.Windows.Forms.GroupBox groupBoxkieutim;
        private System.Windows.Forms.RadioButton radioButtonsoDT;
        private System.Windows.Forms.RadioButton radioButtonhoTen;
    }
}