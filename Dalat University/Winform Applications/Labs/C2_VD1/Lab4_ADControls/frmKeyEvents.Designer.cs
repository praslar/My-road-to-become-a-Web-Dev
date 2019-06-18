namespace Lab4_ADControls
{
    partial class frmKeyEvents
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
            this.labelChar = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelChar
            // 
            this.labelChar.AutoSize = true;
            this.labelChar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChar.ForeColor = System.Drawing.Color.Navy;
            this.labelChar.Location = new System.Drawing.Point(92, 9);
            this.labelChar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChar.Name = "labelChar";
            this.labelChar.Size = new System.Drawing.Size(63, 24);
            this.labelChar.TabIndex = 1;
            this.labelChar.Text = "label1";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.Navy;
            this.labelInfo.Location = new System.Drawing.Point(23, 61);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(63, 24);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 114);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 126);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // frmKeyEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelChar);
            this.Name = "frmKeyEvents";
            this.Text = "frmKeyEvents";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKeyEvents_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmKeyEvents_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChar;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}