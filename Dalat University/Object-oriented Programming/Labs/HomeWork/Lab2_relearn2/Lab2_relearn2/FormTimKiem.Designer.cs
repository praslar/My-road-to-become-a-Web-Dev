namespace Lab2_relearn2
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
            this.radioButtonmaSo = new System.Windows.Forms.RadioButton();
            this.radioButtonhoTen = new System.Windows.Forms.RadioButton();
            this.radioButtonsoDT = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonsoDT);
            this.groupBox1.Controls.Add(this.radioButtonhoTen);
            this.groupBox1.Controls.Add(this.radioButtonmaSo);
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonmaSo
            // 
            this.radioButtonmaSo.AutoSize = true;
            this.radioButtonmaSo.Checked = true;
            this.radioButtonmaSo.Location = new System.Drawing.Point(44, 36);
            this.radioButtonmaSo.Name = "radioButtonmaSo";
            this.radioButtonmaSo.Size = new System.Drawing.Size(54, 17);
            this.radioButtonmaSo.TabIndex = 0;
            this.radioButtonmaSo.TabStop = true;
            this.radioButtonmaSo.Text = "Mã số";
            this.radioButtonmaSo.UseVisualStyleBackColor = true;
            this.radioButtonmaSo.CheckedChanged += new System.EventHandler(this.radioButtonmaSo_CheckedChanged);
            // 
            // radioButtonhoTen
            // 
            this.radioButtonhoTen.AutoSize = true;
            this.radioButtonhoTen.Location = new System.Drawing.Point(161, 36);
            this.radioButtonhoTen.Name = "radioButtonhoTen";
            this.radioButtonhoTen.Size = new System.Drawing.Size(57, 17);
            this.radioButtonhoTen.TabIndex = 0;
            this.radioButtonhoTen.Text = "Họ tên";
            this.radioButtonhoTen.UseVisualStyleBackColor = true;
            // 
            // radioButtonsoDT
            // 
            this.radioButtonsoDT.AutoSize = true;
            this.radioButtonsoDT.Location = new System.Drawing.Point(301, 36);
            this.radioButtonsoDT.Name = "radioButtonsoDT";
            this.radioButtonsoDT.Size = new System.Drawing.Size(56, 17);
            this.radioButtonsoDT.TabIndex = 0;
            this.radioButtonsoDT.Text = "Số ĐT";
            this.radioButtonsoDT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã số";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(350, 121);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 3;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 154);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.RadioButton radioButtonsoDT;
        private System.Windows.Forms.RadioButton radioButtonhoTen;
        private System.Windows.Forms.RadioButton radioButtonmaSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonsearch;
    }
}