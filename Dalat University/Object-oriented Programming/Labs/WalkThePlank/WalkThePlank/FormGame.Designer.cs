namespace WalkThePlank
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
            this.pictureBoxloading = new System.Windows.Forms.PictureBox();
            this.groupBoxMakelabels = new System.Windows.Forms.GroupBox();
            this.checkBoxpause = new System.Windows.Forms.CheckBox();
            this.checkBoxsound = new System.Windows.Forms.CheckBox();
            this.pictureBoxclock2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxclock1 = new System.Windows.Forms.PictureBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonrestart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelmissed = new System.Windows.Forms.Label();
            this.userControlAlphabet1 = new WalkThePlank.UserControlAlphabet();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.timerclock = new System.Windows.Forms.Timer(this.components);
            this.labeldescription = new System.Windows.Forms.Label();
            this.labelwordLength = new System.Windows.Forms.Label();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.labelanswer = new System.Windows.Forms.Label();
            this.pictureBoxAnimation = new System.Windows.Forms.PictureBox();
            this.labelnote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloading)).BeginInit();
            this.groupBoxMakelabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxloading
            // 
            this.pictureBoxloading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxloading.Image = global::WalkThePlank.Properties.Resources.Loading;
            this.pictureBoxloading.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxloading.Name = "pictureBoxloading";
            this.pictureBoxloading.Size = new System.Drawing.Size(978, 491);
            this.pictureBoxloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxloading.TabIndex = 0;
            this.pictureBoxloading.TabStop = false;
            this.pictureBoxloading.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBoxMakelabels
            // 
            this.groupBoxMakelabels.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMakelabels.Controls.Add(this.checkBoxpause);
            this.groupBoxMakelabels.Controls.Add(this.checkBoxsound);
            this.groupBoxMakelabels.Controls.Add(this.pictureBoxclock2);
            this.groupBoxMakelabels.Controls.Add(this.pictureBoxclock1);
            this.groupBoxMakelabels.Controls.Add(this.buttonAbout);
            this.groupBoxMakelabels.Controls.Add(this.buttonexit);
            this.groupBoxMakelabels.Controls.Add(this.buttonrestart);
            this.groupBoxMakelabels.Controls.Add(this.progressBar);
            this.groupBoxMakelabels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMakelabels.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMakelabels.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBoxMakelabels.Location = new System.Drawing.Point(542, 12);
            this.groupBoxMakelabels.Name = "groupBoxMakelabels";
            this.groupBoxMakelabels.Size = new System.Drawing.Size(416, 241);
            this.groupBoxMakelabels.TabIndex = 3;
            this.groupBoxMakelabels.TabStop = false;
            // 
            // checkBoxpause
            // 
            this.checkBoxpause.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxpause.AutoSize = true;
            this.checkBoxpause.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxpause.ForeColor = System.Drawing.Color.Black;
            this.checkBoxpause.Location = new System.Drawing.Point(87, 22);
            this.checkBoxpause.Name = "checkBoxpause";
            this.checkBoxpause.Size = new System.Drawing.Size(58, 25);
            this.checkBoxpause.TabIndex = 11;
            this.checkBoxpause.Text = "Pause";
            this.checkBoxpause.UseVisualStyleBackColor = true;
            this.checkBoxpause.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxsound
            // 
            this.checkBoxsound.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxsound.AutoSize = true;
            this.checkBoxsound.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxsound.Checked = true;
            this.checkBoxsound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxsound.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxsound.ForeColor = System.Drawing.Color.Black;
            this.checkBoxsound.Location = new System.Drawing.Point(6, 22);
            this.checkBoxsound.Name = "checkBoxsound";
            this.checkBoxsound.Size = new System.Drawing.Size(75, 25);
            this.checkBoxsound.TabIndex = 11;
            this.checkBoxsound.Text = "Sound on";
            this.checkBoxsound.UseVisualStyleBackColor = false;
            this.checkBoxsound.CheckedChanged += new System.EventHandler(this.checkBoxsound_CheckedChanged);
            // 
            // pictureBoxclock2
            // 
            this.pictureBoxclock2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxclock2.Image")));
            this.pictureBoxclock2.Location = new System.Drawing.Point(11, 188);
            this.pictureBoxclock2.Name = "pictureBoxclock2";
            this.pictureBoxclock2.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxclock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxclock2.TabIndex = 10;
            this.pictureBoxclock2.TabStop = false;
            // 
            // pictureBoxclock1
            // 
            this.pictureBoxclock1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxclock1.Image")));
            this.pictureBoxclock1.Location = new System.Drawing.Point(11, 188);
            this.pictureBoxclock1.Name = "pictureBoxclock1";
            this.pictureBoxclock1.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxclock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxclock1.TabIndex = 9;
            this.pictureBoxclock1.TabStop = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(234, 22);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(77, 25);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.Text = "About Us";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(317, 22);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(77, 25);
            this.buttonexit.TabIndex = 6;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonrestart
            // 
            this.buttonrestart.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrestart.Location = new System.Drawing.Point(151, 22);
            this.buttonrestart.Name = "buttonrestart";
            this.buttonrestart.Size = new System.Drawing.Size(77, 25);
            this.buttonrestart.TabIndex = 5;
            this.buttonrestart.Text = "Restart";
            this.buttonrestart.UseVisualStyleBackColor = true;
            this.buttonrestart.Click += new System.EventHandler(this.buttonrestart_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            this.progressBar.ForeColor = System.Drawing.Color.Black;
            this.progressBar.Location = new System.Drawing.Point(52, 200);
            this.progressBar.Maximum = 120;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(347, 10);
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 120;
            // 
            // labelmissed
            // 
            this.labelmissed.AutoSize = true;
            this.labelmissed.BackColor = System.Drawing.Color.Transparent;
            this.labelmissed.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmissed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelmissed.Location = new System.Drawing.Point(9, 256);
            this.labelmissed.Name = "labelmissed";
            this.labelmissed.Size = new System.Drawing.Size(57, 15);
            this.labelmissed.TabIndex = 8;
            this.labelmissed.Text = "Missed: ";
            // 
            // userControlAlphabet1
            // 
            this.userControlAlphabet1.AutoSize = true;
            this.userControlAlphabet1.BackColor = System.Drawing.Color.Transparent;
            this.userControlAlphabet1.Location = new System.Drawing.Point(323, 334);
            this.userControlAlphabet1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlAlphabet1.Name = "userControlAlphabet1";
            this.userControlAlphabet1.Size = new System.Drawing.Size(578, 158);
            this.userControlAlphabet1.TabIndex = 4;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 1000;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // timerclock
            // 
            this.timerclock.Enabled = true;
            this.timerclock.Interval = 400;
            this.timerclock.Tick += new System.EventHandler(this.timerclock_Tick);
            // 
            // labeldescription
            // 
            this.labeldescription.AutoSize = true;
            this.labeldescription.BackColor = System.Drawing.Color.Transparent;
            this.labeldescription.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldescription.ForeColor = System.Drawing.Color.White;
            this.labeldescription.Location = new System.Drawing.Point(12, 443);
            this.labeldescription.Name = "labeldescription";
            this.labeldescription.Size = new System.Drawing.Size(50, 18);
            this.labeldescription.TabIndex = 0;
            this.labeldescription.Text = "HINT: ";
            // 
            // labelwordLength
            // 
            this.labelwordLength.AutoSize = true;
            this.labelwordLength.BackColor = System.Drawing.Color.Transparent;
            this.labelwordLength.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwordLength.ForeColor = System.Drawing.Color.White;
            this.labelwordLength.Location = new System.Drawing.Point(12, 416);
            this.labelwordLength.Name = "labelwordLength";
            this.labelwordLength.Size = new System.Drawing.Size(118, 18);
            this.labelwordLength.TabIndex = 1;
            this.labelwordLength.Text = "Word Length:";
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonsubmit.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsubmit.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonsubmit.Location = new System.Drawing.Point(931, 325);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(27, 148);
            this.buttonsubmit.TabIndex = 4;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = false;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // labelanswer
            // 
            this.labelanswer.AutoSize = true;
            this.labelanswer.BackColor = System.Drawing.Color.Transparent;
            this.labelanswer.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelanswer.ForeColor = System.Drawing.Color.White;
            this.labelanswer.Location = new System.Drawing.Point(12, 390);
            this.labelanswer.Name = "labelanswer";
            this.labelanswer.Size = new System.Drawing.Size(109, 18);
            this.labelanswer.TabIndex = 0;
            this.labelanswer.Text = "The answer:";
            this.labelanswer.Visible = false;
            // 
            // pictureBoxAnimation
            // 
            this.pictureBoxAnimation.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAnimation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAnimation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnimation.Image")));
            this.pictureBoxAnimation.Location = new System.Drawing.Point(12, 23);
            this.pictureBoxAnimation.Name = "pictureBoxAnimation";
            this.pictureBoxAnimation.Size = new System.Drawing.Size(513, 230);
            this.pictureBoxAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAnimation.TabIndex = 9;
            this.pictureBoxAnimation.TabStop = false;
            // 
            // labelnote
            // 
            this.labelnote.AutoSize = true;
            this.labelnote.BackColor = System.Drawing.Color.Transparent;
            this.labelnote.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnote.ForeColor = System.Drawing.Color.White;
            this.labelnote.Location = new System.Drawing.Point(12, 362);
            this.labelnote.Name = "labelnote";
            this.labelnote.Size = new System.Drawing.Size(250, 18);
            this.labelnote.TabIndex = 1;
            this.labelnote.Text = "Click restart to play again!";
            this.labelnote.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "HURRY UP AND FIND OUT THE HIDDEN WORD FROM ONE OF THOSE PICTURES YOU HAVE SEEN BE" +
    "FORE";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WalkThePlank.Properties.Resources.IMG_403746;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 491);
            this.Controls.Add(this.pictureBoxloading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelnote);
            this.Controls.Add(this.labelwordLength);
            this.Controls.Add(this.labeldescription);
            this.Controls.Add(this.groupBoxMakelabels);
            this.Controls.Add(this.labelmissed);
            this.Controls.Add(this.labelanswer);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.userControlAlphabet1);
            this.Controls.Add(this.pictureBoxAnimation);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloading)).EndInit();
            this.groupBoxMakelabels.ResumeLayout(false);
            this.groupBoxMakelabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxMakelabels;
        private UserControlAlphabet userControlAlphabet1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerProgressBar;
        private System.Windows.Forms.Timer timerclock;
        private System.Windows.Forms.Button buttonrestart;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label labelmissed;
        private System.Windows.Forms.Label labeldescription;
        private System.Windows.Forms.Label labelwordLength;
        private System.Windows.Forms.Button buttonsubmit;
        private System.Windows.Forms.PictureBox pictureBoxloading;
        private System.Windows.Forms.PictureBox pictureBoxclock2;
        private System.Windows.Forms.PictureBox pictureBoxclock1;
        private System.Windows.Forms.CheckBox checkBoxsound;
        private System.Windows.Forms.Label labelanswer;
        private System.Windows.Forms.PictureBox pictureBoxAnimation;
        private System.Windows.Forms.CheckBox checkBoxpause;
        private System.Windows.Forms.Label labelnote;
        private System.Windows.Forms.Label label1;
    }
}

