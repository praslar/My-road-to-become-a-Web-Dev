namespace Client
{
    partial class Client
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
            this.buttonclientsend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonclientsend
            // 
            this.buttonclientsend.Location = new System.Drawing.Point(223, 226);
            this.buttonclientsend.Name = "buttonclientsend";
            this.buttonclientsend.Size = new System.Drawing.Size(57, 23);
            this.buttonclientsend.TabIndex = 5;
            this.buttonclientsend.Text = "Send";
            this.buttonclientsend.UseVisualStyleBackColor = true;
            this.buttonclientsend.Click += new System.EventHandler(this.buttonclientsend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(4, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(276, 205);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Client
            // 
            this.AcceptButton = this.buttonclientsend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonclientsend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonclientsend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
    }
}

