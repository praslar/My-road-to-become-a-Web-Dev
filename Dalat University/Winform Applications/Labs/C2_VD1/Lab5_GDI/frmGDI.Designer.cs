namespace Lab5_GDI
{
    partial class frmGDI
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
            this.panel = new System.Windows.Forms.Panel();
            this.buttonPaint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonElip = new System.Windows.Forms.RadioButton();
            this.radioButtonHCN = new System.Windows.Forms.RadioButton();
            this.radioButtonDT = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ucColor1 = new Lab5_GDI.UCColor();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(13, 140);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(807, 251);
            this.panel.TabIndex = 1;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // buttonPaint
            // 
            this.buttonPaint.Location = new System.Drawing.Point(735, 39);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(75, 23);
            this.buttonPaint.TabIndex = 2;
            this.buttonPaint.Text = "Vẽ";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonElip);
            this.groupBox1.Controls.Add(this.radioButtonHCN);
            this.groupBox1.Controls.Add(this.radioButtonDT);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(427, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại hình";
            // 
            // radioButtonElip
            // 
            this.radioButtonElip.AutoSize = true;
            this.radioButtonElip.Location = new System.Drawing.Point(166, 33);
            this.radioButtonElip.Name = "radioButtonElip";
            this.radioButtonElip.Size = new System.Drawing.Size(46, 19);
            this.radioButtonElip.TabIndex = 0;
            this.radioButtonElip.TabStop = true;
            this.radioButtonElip.Text = "Elip";
            this.radioButtonElip.UseVisualStyleBackColor = true;
            this.radioButtonElip.Click += new System.EventHandler(this.radioButtonLoaiHinh_Click);
            // 
            // radioButtonHCN
            // 
            this.radioButtonHCN.AutoSize = true;
            this.radioButtonHCN.Location = new System.Drawing.Point(110, 33);
            this.radioButtonHCN.Name = "radioButtonHCN";
            this.radioButtonHCN.Size = new System.Drawing.Size(52, 19);
            this.radioButtonHCN.TabIndex = 0;
            this.radioButtonHCN.TabStop = true;
            this.radioButtonHCN.Text = "HCN";
            this.radioButtonHCN.UseVisualStyleBackColor = true;
            this.radioButtonHCN.Click += new System.EventHandler(this.radioButtonLoaiHinh_Click);
            // 
            // radioButtonDT
            // 
            this.radioButtonDT.AutoSize = true;
            this.radioButtonDT.Location = new System.Drawing.Point(7, 32);
            this.radioButtonDT.Name = "radioButtonDT";
            this.radioButtonDT.Size = new System.Drawing.Size(97, 19);
            this.radioButtonDT.TabIndex = 0;
            this.radioButtonDT.TabStop = true;
            this.radioButtonDT.Text = "Đường thẳng";
            this.radioButtonDT.UseVisualStyleBackColor = true;
            this.radioButtonDT.CheckedChanged += new System.EventHandler(this.radioButtonDT_CheckedChanged);
            this.radioButtonDT.Click += new System.EventHandler(this.radioButtonLoaiHinh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(832, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // ucColor1
            // 
            this.ucColor1.Location = new System.Drawing.Point(3, 12);
            this.ucColor1.Name = "ucColor1";
            this.ucColor1.Size = new System.Drawing.Size(418, 95);
            this.ucColor1.TabIndex = 0;
            this.ucColor1.Click += new System.EventHandler(this.ucColor1_Click);
            // 
            // frmGDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 423);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPaint);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.ucColor1);
            this.Name = "frmGDI";
            this.Text = "Demo Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGDI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCColor ucColor1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonElip;
        private System.Windows.Forms.RadioButton radioButtonHCN;
        private System.Windows.Forms.RadioButton radioButtonDT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

