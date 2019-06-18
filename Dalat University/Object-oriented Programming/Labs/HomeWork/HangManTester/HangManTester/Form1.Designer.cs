namespace HangManTester
{
    partial class HangManTester
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
            this.groupBoxAnimation = new System.Windows.Forms.GroupBox();
            this.panelHangMan = new System.Windows.Forms.Panel();
            this.groupBoxAnswer = new System.Windows.Forms.GroupBox();
            this.labelWordLength = new System.Windows.Forms.Label();
            this.textBoxSubmit = new System.Windows.Forms.TextBox();
            this.textBoxLetters = new System.Windows.Forms.TextBox();
            this.buttonSubmitWord = new System.Windows.Forms.Button();
            this.buttonSubmitLetter = new System.Windows.Forms.Button();
            this.groupBoxWords = new System.Windows.Forms.GroupBox();
            this.labelMissed = new System.Windows.Forms.Label();
            this.groupBoxAlphabet = new System.Windows.Forms.GroupBox();
            this.panelAlphabet = new System.Windows.Forms.Panel();
            this.userControlAlphabet1 = new HangManTester.UserControlAlphabet();
            this.groupBoxAnimation.SuspendLayout();
            this.groupBoxAnswer.SuspendLayout();
            this.groupBoxWords.SuspendLayout();
            this.groupBoxAlphabet.SuspendLayout();
            this.panelAlphabet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAnimation
            // 
            this.groupBoxAnimation.Controls.Add(this.panelHangMan);
            this.groupBoxAnimation.Location = new System.Drawing.Point(390, 12);
            this.groupBoxAnimation.Name = "groupBoxAnimation";
            this.groupBoxAnimation.Size = new System.Drawing.Size(178, 312);
            this.groupBoxAnimation.TabIndex = 0;
            this.groupBoxAnimation.TabStop = false;
            this.groupBoxAnimation.Text = "groupBoxAnimation";
            // 
            // panelHangMan
            // 
            this.panelHangMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHangMan.Location = new System.Drawing.Point(3, 16);
            this.panelHangMan.Name = "panelHangMan";
            this.panelHangMan.Size = new System.Drawing.Size(172, 293);
            this.panelHangMan.TabIndex = 0;
            // 
            // groupBoxAnswer
            // 
            this.groupBoxAnswer.Controls.Add(this.labelWordLength);
            this.groupBoxAnswer.Controls.Add(this.textBoxSubmit);
            this.groupBoxAnswer.Controls.Add(this.textBoxLetters);
            this.groupBoxAnswer.Controls.Add(this.buttonSubmitWord);
            this.groupBoxAnswer.Controls.Add(this.buttonSubmitLetter);
            this.groupBoxAnswer.Location = new System.Drawing.Point(12, 263);
            this.groupBoxAnswer.Name = "groupBoxAnswer";
            this.groupBoxAnswer.Size = new System.Drawing.Size(375, 61);
            this.groupBoxAnswer.TabIndex = 1;
            this.groupBoxAnswer.TabStop = false;
            this.groupBoxAnswer.Text = "groupBoxAnswer";
            // 
            // labelWordLength
            // 
            this.labelWordLength.AutoSize = true;
            this.labelWordLength.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordLength.Location = new System.Drawing.Point(248, 15);
            this.labelWordLength.Name = "labelWordLength";
            this.labelWordLength.Size = new System.Drawing.Size(92, 14);
            this.labelWordLength.TabIndex = 0;
            this.labelWordLength.Text = "Word Length:";
            // 
            // textBoxSubmit
            // 
            this.textBoxSubmit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubmit.Location = new System.Drawing.Point(251, 32);
            this.textBoxSubmit.MaxLength = 20;
            this.textBoxSubmit.Name = "textBoxSubmit";
            this.textBoxSubmit.Size = new System.Drawing.Size(117, 23);
            this.textBoxSubmit.TabIndex = 3;
            // 
            // textBoxLetters
            // 
            this.textBoxLetters.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLetters.Location = new System.Drawing.Point(121, 33);
            this.textBoxLetters.MaxLength = 1;
            this.textBoxLetters.Name = "textBoxLetters";
            this.textBoxLetters.Size = new System.Drawing.Size(17, 23);
            this.textBoxLetters.TabIndex = 1;
            // 
            // buttonSubmitWord
            // 
            this.buttonSubmitWord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitWord.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmitWord.Location = new System.Drawing.Point(144, 33);
            this.buttonSubmitWord.Name = "buttonSubmitWord";
            this.buttonSubmitWord.Size = new System.Drawing.Size(101, 23);
            this.buttonSubmitWord.TabIndex = 2;
            this.buttonSubmitWord.Text = "Submit Word";
            this.buttonSubmitWord.UseVisualStyleBackColor = true;
            this.buttonSubmitWord.Click += new System.EventHandler(this.buttonSubmitWord_Click);
            // 
            // buttonSubmitLetter
            // 
            this.buttonSubmitLetter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitLetter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSubmitLetter.Location = new System.Drawing.Point(6, 32);
            this.buttonSubmitLetter.Name = "buttonSubmitLetter";
            this.buttonSubmitLetter.Size = new System.Drawing.Size(109, 23);
            this.buttonSubmitLetter.TabIndex = 0;
            this.buttonSubmitLetter.Text = "Submit Letter";
            this.buttonSubmitLetter.UseVisualStyleBackColor = true;
            this.buttonSubmitLetter.Click += new System.EventHandler(this.buttonSubmitLetter_Click);
            // 
            // groupBoxWords
            // 
            this.groupBoxWords.Controls.Add(this.labelMissed);
            this.groupBoxWords.Location = new System.Drawing.Point(12, 12);
            this.groupBoxWords.Name = "groupBoxWords";
            this.groupBoxWords.Size = new System.Drawing.Size(375, 245);
            this.groupBoxWords.TabIndex = 2;
            this.groupBoxWords.TabStop = false;
            this.groupBoxWords.Text = "groupBoxWords";
            // 
            // labelMissed
            // 
            this.labelMissed.AutoSize = true;
            this.labelMissed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMissed.Location = new System.Drawing.Point(7, 213);
            this.labelMissed.Name = "labelMissed";
            this.labelMissed.Size = new System.Drawing.Size(61, 16);
            this.labelMissed.TabIndex = 0;
            this.labelMissed.Text = "Missed: ";
            // 
            // groupBoxAlphabet
            // 
            this.groupBoxAlphabet.Controls.Add(this.panelAlphabet);
            this.groupBoxAlphabet.Location = new System.Drawing.Point(12, 330);
            this.groupBoxAlphabet.Name = "groupBoxAlphabet";
            this.groupBoxAlphabet.Size = new System.Drawing.Size(553, 173);
            this.groupBoxAlphabet.TabIndex = 3;
            this.groupBoxAlphabet.TabStop = false;
            this.groupBoxAlphabet.Text = "groupBoxAlphabet";
            // 
            // panelAlphabet
            // 
            this.panelAlphabet.Controls.Add(this.userControlAlphabet1);
            this.panelAlphabet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlphabet.Location = new System.Drawing.Point(3, 16);
            this.panelAlphabet.Name = "panelAlphabet";
            this.panelAlphabet.Size = new System.Drawing.Size(547, 154);
            this.panelAlphabet.TabIndex = 0;
            // 
            // userControlAlphabet1
            // 
            this.userControlAlphabet1.Location = new System.Drawing.Point(7, 17);
            this.userControlAlphabet1.Name = "userControlAlphabet1";
            this.userControlAlphabet1.Size = new System.Drawing.Size(474, 134);
            this.userControlAlphabet1.TabIndex = 1;
            // 
            // HangManTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 515);
            this.Controls.Add(this.groupBoxAlphabet);
            this.Controls.Add(this.groupBoxWords);
            this.Controls.Add(this.groupBoxAnswer);
            this.Controls.Add(this.groupBoxAnimation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HangManTester";
            this.Text = "HangManTester - Póp";
            this.Load += new System.EventHandler(this.HangManTester_Load);
            this.Shown += new System.EventHandler(this.HangManTester_Shown);
            this.groupBoxAnimation.ResumeLayout(false);
            this.groupBoxAnswer.ResumeLayout(false);
            this.groupBoxAnswer.PerformLayout();
            this.groupBoxWords.ResumeLayout(false);
            this.groupBoxWords.PerformLayout();
            this.groupBoxAlphabet.ResumeLayout(false);
            this.panelAlphabet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAnimation;
        private System.Windows.Forms.Panel panelHangMan;
        private System.Windows.Forms.GroupBox groupBoxAnswer;
        private System.Windows.Forms.TextBox textBoxLetters;
        private System.Windows.Forms.Button buttonSubmitWord;
        private System.Windows.Forms.Button buttonSubmitLetter;
        private System.Windows.Forms.GroupBox groupBoxWords;
        private System.Windows.Forms.Label labelWordLength;
        private System.Windows.Forms.TextBox textBoxSubmit;
        private System.Windows.Forms.Label labelMissed;
        private System.Windows.Forms.GroupBox groupBoxAlphabet;
        private System.Windows.Forms.Panel panelAlphabet;
        private HangManTester.UserControlAlphabet userControlAlphabet1;
    }
}

