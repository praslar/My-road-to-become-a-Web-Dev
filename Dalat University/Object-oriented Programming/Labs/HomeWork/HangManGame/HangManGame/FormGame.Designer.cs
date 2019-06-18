namespace HangManGame
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxtimerclock1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxclock2 = new System.Windows.Forms.PictureBox();
            this.timerclock = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userControlAlphabet1 = new HangManGame.UserControlAlphabet();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelwordlength = new System.Windows.Forms.Label();
            this.labelmissed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtimerclock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclock2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            this.progressBar.ForeColor = System.Drawing.Color.Black;
            this.progressBar.Location = new System.Drawing.Point(64, 332);
            this.progressBar.Maximum = 120;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(224, 23);
            this.progressBar.TabIndex = 0;
            this.progressBar.Value = 120;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBoxtimerclock1
            // 
            this.pictureBoxtimerclock1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxtimerclock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxtimerclock1.Image = global::HangManGame.Properties.Resources.New_Piskel__1_;
            this.pictureBoxtimerclock1.Location = new System.Drawing.Point(19, 332);
            this.pictureBoxtimerclock1.Name = "pictureBoxtimerclock1";
            this.pictureBoxtimerclock1.Size = new System.Drawing.Size(29, 23);
            this.pictureBoxtimerclock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxtimerclock1.TabIndex = 1;
            this.pictureBoxtimerclock1.TabStop = false;
            // 
            // pictureBoxclock2
            // 
            this.pictureBoxclock2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxclock2.Image = global::HangManGame.Properties.Resources.New_Piskel2;
            this.pictureBoxclock2.Location = new System.Drawing.Point(19, 332);
            this.pictureBoxclock2.Name = "pictureBoxclock2";
            this.pictureBoxclock2.Size = new System.Drawing.Size(29, 23);
            this.pictureBoxclock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxclock2.TabIndex = 2;
            this.pictureBoxclock2.TabStop = false;
            // 
            // timerclock
            // 
            this.timerclock.Enabled = true;
            this.timerclock.Interval = 400;
            this.timerclock.Tick += new System.EventHandler(this.timerclock_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelwordlength);
            this.groupBox1.Controls.Add(this.labelmissed);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.pictureBoxclock2);
            this.groupBox1.Controls.Add(this.pictureBoxtimerclock1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-1, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 434);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // userControlAlphabet1
            // 
            this.userControlAlphabet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlAlphabet1.BackgroundImage")));
            this.userControlAlphabet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControlAlphabet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlAlphabet1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControlAlphabet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAlphabet1.Location = new System.Drawing.Point(312, 290);
            this.userControlAlphabet1.Name = "userControlAlphabet1";
            this.userControlAlphabet1.Size = new System.Drawing.Size(540, 136);
            this.userControlAlphabet1.TabIndex = 3;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(16, 376);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 18);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // labelwordlength
            // 
            this.labelwordlength.AutoSize = true;
            this.labelwordlength.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwordlength.Location = new System.Drawing.Point(16, 358);
            this.labelwordlength.Name = "labelwordlength";
            this.labelwordlength.Size = new System.Drawing.Size(102, 18);
            this.labelwordlength.TabIndex = 4;
            this.labelwordlength.Text = "Word Length: ";
            // 
            // labelmissed
            // 
            this.labelmissed.AutoSize = true;
            this.labelmissed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmissed.ForeColor = System.Drawing.Color.White;
            this.labelmissed.Location = new System.Drawing.Point(16, 311);
            this.labelmissed.Name = "labelmissed";
            this.labelmissed.Size = new System.Drawing.Size(57, 18);
            this.labelmissed.TabIndex = 3;
            this.labelmissed.Text = "Missed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userControlAlphabet1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtimerclock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclock2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBoxtimerclock1;
        private System.Windows.Forms.PictureBox pictureBoxclock2;
        private System.Windows.Forms.Timer timerclock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDescription;
        private UserControlAlphabet userControlAlphabet1;
        private System.Windows.Forms.Label labelwordlength;
        private System.Windows.Forms.Label labelmissed;
    }
}

