using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace WalkThePlank
{
    public partial class FormGame : Form
    {
        //BackgroundMusic
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer playerwrong = new WMPLib.WindowsMediaPlayer();
        //TimerProgressBar
        int thoigian;
        int missedcount;
        //Makelables
        string allwordanddesscription;
        string wordanddescription = "";
        string word;
        List<Label> labels = new List<Label>();
        //FormHintPictures
        int group = 0;
        enum groups
        {
            animal,
            job,
            ocean,
            sport,
            character
        }
        //Animation 
        enum walk
        {
            step1, step2, step3, step4, step5,
        }
        void DrawDeadSteps(walk step)
        {
            if (step == walk.step1)
                pictureBoxAnimation.Image = Image.FromFile("step0.png");
            else if (step == walk.step2)
                pictureBoxAnimation.Image = Image.FromFile("step1.png");
            else if (step == walk.step3)
                pictureBoxAnimation.Image = Image.FromFile("step2.png");
            else if (step == walk.step4)
                pictureBoxAnimation.Image = Image.FromFile("step3.png");
            else if (step == walk.step5)
                pictureBoxAnimation.Image = Image.FromFile("step4.png");
        }
        public FormGame()
        {
            InitializeComponent();
            player.URL = "backgroundloading.wav";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

        }
        //ResetGame
        public void Reset()
        {
            this.labelanswer.Visible = false;
            this.labelnote.Visible = false;
            this.buttonsubmit.Enabled = true;
            missedcount = 0;
            player.controls.stop();
            player.URL = "music.mp3";
            player.controls.play();
            GetRandomWordandDescription();
            MakeLables();
            thoigian = 120;
            this.progressBar.Value = thoigian;
            this.timerProgressBar.Start();
            this.labelmissed.Text = "Missed: ";
            this.checkBoxsound.Text = "Sound On";
            this.checkBoxsound.Checked = true;
            this.buttonrestart.Visible = false;
            this.pictureBoxAnimation.Image = Image.FromFile("step0.png");
            if (group == 0)
            {
                FormHintPictures frmhint = new FormHintPictures();
                frmhint.Show();
            }
            else
                if (group == 1)
            {
                FormHintPictures1 frmhint1 = new FormHintPictures1();
                frmhint1.Show();
            }
            else
                if (group == 2)
            {
                FormHintPictures2 frmhint2 = new FormHintPictures2();
                frmhint2.Show();
            }
            else
                if (group == 3)
            {
                FormHintPictures3 frmhint3 = new FormHintPictures3();
                frmhint3.Show();
            }
            else
            {
                FormHintPictures4 frmhint4 = new FormHintPictures4();
                frmhint4.Show();
            }
            this.timerclock.Start();
        }
        //ReadFile
        private void ReadFile()
        {
            ReadFile rf = new WalkThePlank.ReadFile();
            allwordanddesscription = rf.readfile();
        }
        string GetRandomWordandDescription()
        {
            string[] wordandescription = allwordanddesscription.Split('\n');
            Random rd = new Random();
            return wordandescription[rd.Next(0, wordandescription.Length - 1)];
        }
        //Makelabels
        void MakeLables()
        {
            wordanddescription = GetRandomWordandDescription();
            string[] wd = wordanddescription.Split('*');
            word = wd[0];
            this.labeldescription.Text = "HINT: " + wd[1].ToString();
            group = int.Parse(wd[2]);
            char[] letters = wd[0].ToCharArray();
            int wordposition = 300 / letters.Length - 1;
            for (int i = 0; i < letters.Length; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * wordposition) + 10, 90);
                labels[i].Text = "_";
                labels[i].Parent = groupBoxMakelabels;
                labels[i].BringToFront();
                labels[i].CreateControl();
            }
            labelwordLength.Text = "Word Length: " + (wd[0].Length).ToString();
        }
        //TimerProgressBar
        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            thoigian--;
            int t = thoigian * 100 / 120;
            t = t > 0 ? t : 0;
            this.progressBar.Value = thoigian > 0 ? thoigian : 0;
            if (thoigian <= 0)
            {
                DrawDeadSteps((walk)4);
                this.buttonsubmit.Enabled = false;
                this.timerclock.Stop();
                this.labelanswer.Visible = true;
                this.labelanswer.Text = "The answer was: " + word.ToString();
                player.controls.stop();
                player.URL = "Lose.mp3";
                player.controls.play();
                FormLose frmlose = new FormLose();
                frmlose.Show();
                this.timerProgressBar.Stop();
                this.buttonrestart.Visible = true;
                this.labelnote.Visible = true;
            }
        }
        //TimerClockAnimation
        private void timerclock_Tick(object sender, EventArgs e)
        {
            this.pictureBoxclock2.Visible = this.pictureBoxclock2.Visible == true ? false : true;
        }
        private void buttonrestart_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //ReadfileFormLoad
        private void FormGame_Load(object sender, EventArgs e)
        {
            ReadFile();
            player.controls.play();
        }
        //Sumbitword
        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            string text = userControlAlphabet1.GetString();
            if (text == "")
            {
                MessageBox.Show("You can only sumbit a letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            char letter = userControlAlphabet1.GetString().ToLower().ToCharArray()[0];
            if (word.Contains(letter))
            {
                char[] answer = word.ToCharArray();
                for (int i = 0; i < answer.Length; i++)
                {
                    if (letter == answer[i])
                    {
                        labels[i].Text = letter.ToString();
                    }
                }
                for (int i = 0; i < word.Length; i++)
                {
                    if (labels[i].Text == "_")
                        return;
                }
                //foreach (Label l in labels)
                //    if (l.Text == "_")
                //        return;
                //soundeffect             
                player.controls.stop();
                player.URL = "Win.mp3";
                player.controls.play();
                //loadform
                this.timerclock.Stop();
                this.buttonsubmit.Enabled = false;
                this.labelnote.Visible = true;
                FormWin frmwin = new FormWin();
                frmwin.Show();
                this.timerProgressBar.Stop();
                this.buttonrestart.Visible = true;
            }
            else
            {

                missedcount++;
                DrawDeadSteps((walk)missedcount);
                if (missedcount <= 4)
                {
                    playerwrong.URL = "WalkThePlank.mp3";
                    playerwrong.controls.play();
                }
                labelmissed.Text += " " + letter.ToString().ToUpper() + ";";
                thoigian = thoigian - 20;
                if (missedcount == 5)
                {
                    //loadformlose
                    FormLose frmlose = new FormLose();
                    frmlose.Show();
                    //soundeffect
                    player.controls.stop();
                    player.URL = "Lose.mp3";
                    player.controls.play();
                    //
                    this.buttonsubmit.Enabled = false;
                    this.labelnote.Visible = true;
                    this.timerclock.Stop();
                    this.labelanswer.Visible = true;
                    this.labelanswer.Text = "The answer was: " + word.ToString();
                    this.buttonrestart.Visible = true;
                    this.timerProgressBar.Stop();
                    this.buttonrestart.Visible = true;
                }
            }
        }
        //pictureboxloading
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBoxloading.Visible = false;
            Reset();
        }
        //BackgroundSound
        private void checkBoxsound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxsound.Checked)
            {
                player.controls.play();
                this.checkBoxsound.Text = "Sound On";
            }
            else
            {
                player.controls.stop();
                this.checkBoxsound.Text = "Sound Off";
            }
        }
        //AboutUs
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are: Phạm Xuân Thắng & Võ Nguyễn Minh Quân \nWe are student just like you in case you can't tell and we are your classmate, I bet you don't know. \nWe like to do shit. \nWe have hope and dream too. \nI am the one who write this for you to read. \nThis is just something for fun, it has nothing to do with the game. \nThank you for time and efforts.\nHope you have a great day. \nThe wanderer. ", "About Us");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpause.Checked)
            {
                timerProgressBar.Stop();
                checkBoxsound.Checked = false;
                this.buttonsubmit.Enabled = false;
                this.checkBoxpause.Text = "Continue";
            }
            else
            {
                timerProgressBar.Start();
                checkBoxsound.Checked = true;
                this.buttonsubmit.Enabled = true;
                this.checkBoxpause.Text = "Pause";
            }
        }
    }
}
