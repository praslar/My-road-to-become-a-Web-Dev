namespace lab2_Ontap_Console_learnbyheart
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.radioButtonmaSo = new System.Windows.Forms.RadioButton();
            this.groupBoxkieutim = new System.Windows.Forms.GroupBox();
            this.radioButtonhoTen = new System.Windows.Forms.RadioButton();
            this.radioButtonsoDT = new System.Windows.Forms.RadioButton();
            this.groupBoxkieutim.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm theo: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 23);
            this.textBox1.TabIndex = 1;
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(427, 118);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 2;
            this.buttonTim.Text = "OK";
            this.buttonTim.UseVisualStyleBackColor = true;
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
            this.groupBoxkieutim.Location = new System.Drawing.Point(15, 12);
            this.groupBoxkieutim.Name = "groupBoxkieutim";
            this.groupBoxkieutim.Size = new System.Drawing.Size(487, 83);
            this.groupBoxkieutim.TabIndex = 4;
            this.groupBoxkieutim.TabStop = false;
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
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 158);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxkieutim);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTimKiem";
            this.Text = "FormTimKiem";
            this.groupBoxkieutim.ResumeLayout(false);
            this.groupBoxkieutim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.RadioButton radioButtonmaSo;
        private System.Windows.Forms.GroupBox groupBoxkieutim;
        private System.Windows.Forms.RadioButton radioButtonsoDT;
        private System.Windows.Forms.RadioButton radioButtonhoTen;
    }
}