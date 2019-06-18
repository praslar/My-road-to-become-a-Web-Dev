namespace Lab5_Ontap
{
    partial class Form1
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
            this.paneldraw = new System.Windows.Forms.Panel();
            this.userControlColor1 = new Lab5_Ontap.UserControlColor();
            this.userControl11 = new Lab5_Ontap.UserControl1();
            this.paneldraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldraw
            // 
            this.paneldraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldraw.BackColor = System.Drawing.Color.White;
            this.paneldraw.Controls.Add(this.userControl11);
            this.paneldraw.Location = new System.Drawing.Point(12, 115);
            this.paneldraw.Name = "paneldraw";
            this.paneldraw.Size = new System.Drawing.Size(502, 168);
            this.paneldraw.TabIndex = 0;
            // 
            // userControlColor1
            // 
            this.userControlColor1.BackColor = System.Drawing.Color.White;
            this.userControlColor1.Location = new System.Drawing.Point(12, 12);
            this.userControlColor1.Name = "userControlColor1";
            this.userControlColor1.Size = new System.Drawing.Size(493, 97);
            this.userControlColor1.TabIndex = 1;
            this.userControlColor1.Load += new System.EventHandler(this.userControlColor1_Load);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(73, 67);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(150, 150);
            this.userControl11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 362);
            this.Controls.Add(this.userControlColor1);
            this.Controls.Add(this.paneldraw);
            this.Name = "Form1";
            this.Text = "GDI";
            this.paneldraw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldraw;
        private UserControlColor userControlColor1;
        private UserControl1 userControl11;
    }
}

