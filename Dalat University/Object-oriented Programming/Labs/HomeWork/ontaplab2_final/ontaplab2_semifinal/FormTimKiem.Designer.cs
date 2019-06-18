namespace ontaplab2_semifinal
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
            this.groupBoxsearch = new System.Windows.Forms.GroupBox();
            this.radioButtonmaSo = new System.Windows.Forms.RadioButton();
            this.radioButtonhoTen = new System.Windows.Forms.RadioButton();
            this.radioButtonsoDT = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxsearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxsearch
            // 
            this.groupBoxsearch.Controls.Add(this.radioButtonsoDT);
            this.groupBoxsearch.Controls.Add(this.radioButtonhoTen);
            this.groupBoxsearch.Controls.Add(this.radioButtonmaSo);
            this.groupBoxsearch.Location = new System.Drawing.Point(45, 27);
            this.groupBoxsearch.Name = "groupBoxsearch";
            this.groupBoxsearch.Size = new System.Drawing.Size(469, 75);
            this.groupBoxsearch.TabIndex = 0;
            this.groupBoxsearch.TabStop = false;
            this.groupBoxsearch.Text = "Tìm theo";
            // 
            // radioButtonmaSo
            // 
            this.radioButtonmaSo.AutoSize = true;
            this.radioButtonmaSo.Checked = true;
            this.radioButtonmaSo.Location = new System.Drawing.Point(49, 33);
            this.radioButtonmaSo.Name = "radioButtonmaSo";
            this.radioButtonmaSo.Size = new System.Drawing.Size(60, 20);
            this.radioButtonmaSo.TabIndex = 0;
            this.radioButtonmaSo.TabStop = true;
            this.radioButtonmaSo.Text = "Mã số";
            this.radioButtonmaSo.UseVisualStyleBackColor = true;
            this.radioButtonmaSo.CheckedChanged += new System.EventHandler(this.radioButtonmaSo_CheckedChanged);
            // 
            // radioButtonhoTen
            // 
            this.radioButtonhoTen.AutoSize = true;
            this.radioButtonhoTen.Location = new System.Drawing.Point(193, 33);
            this.radioButtonhoTen.Name = "radioButtonhoTen";
            this.radioButtonhoTen.Size = new System.Drawing.Size(63, 20);
            this.radioButtonhoTen.TabIndex = 0;
            this.radioButtonhoTen.Text = "Họ tên";
            this.radioButtonhoTen.UseVisualStyleBackColor = true;
            this.radioButtonhoTen.CheckedChanged += new System.EventHandler(this.radioButtonmaSo_CheckedChanged);
            // 
            // radioButtonsoDT
            // 
            this.radioButtonsoDT.AutoSize = true;
            this.radioButtonsoDT.Location = new System.Drawing.Point(327, 33);
            this.radioButtonsoDT.Name = "radioButtonsoDT";
            this.radioButtonsoDT.Size = new System.Drawing.Size(101, 20);
            this.radioButtonsoDT.TabIndex = 0;
            this.radioButtonsoDT.Text = "Số điện thoại";
            this.radioButtonsoDT.UseVisualStyleBackColor = true;
            this.radioButtonsoDT.CheckedChanged += new System.EventHandler(this.radioButtonmaSo_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã số: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxsearch);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTimKiem";
            this.Text = "FormTimKiem";
            this.groupBoxsearch.ResumeLayout(false);
            this.groupBoxsearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxsearch;
        private System.Windows.Forms.RadioButton radioButtonsoDT;
        private System.Windows.Forms.RadioButton radioButtonhoTen;
        private System.Windows.Forms.RadioButton radioButtonmaSo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}