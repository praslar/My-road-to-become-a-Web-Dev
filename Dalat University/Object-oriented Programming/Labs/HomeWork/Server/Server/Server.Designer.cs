namespace Server
{
    partial class FormServer
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonserversend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(276, 205);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonserversend
            // 
            this.buttonserversend.Location = new System.Drawing.Point(232, 225);
            this.buttonserversend.Name = "buttonserversend";
            this.buttonserversend.Size = new System.Drawing.Size(57, 23);
            this.buttonserversend.TabIndex = 2;
            this.buttonserversend.Text = "Send";
            this.buttonserversend.UseVisualStyleBackColor = true;
            this.buttonserversend.Click += new System.EventHandler(this.buttonserversend_Click);
            // 
            // FormServer
            // 
            this.AcceptButton = this.buttonserversend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 273);
            this.Controls.Add(this.buttonserversend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "FormServer";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormServer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonserversend;
    }
}

