using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManTester
{
    public partial class HangManTester : Form
    {
        string theword;
        string word = "";
        int missedcount;
        List<Label> labels = new List<Label>();
        //================================================
        public HangManTester()
        {
            InitializeComponent();
        }
        enum BodyParts
        {
            head,
            arms,
            legs
        }
        void DrawPost()
        {
            Graphics g = panelHangMan.CreateGraphics();
            Pen p = new Pen(Color.Black, 10);
            g.DrawLine(p, new Point(170, 290), new Point(170, 10));

        }
        void DrawMan(BodyParts bp)
        {
            Graphics g = panelHangMan.CreateGraphics();
            Pen p = new Pen(Color.BlueViolet, 5);
            if (bp == BodyParts.head)
                g.DrawEllipse(p, 40, 50, 40, 40);
            else if (bp == BodyParts.arms)
                g.DrawEllipse(p, 80, 90, 60, 60);
            else if (bp == BodyParts.legs)
                g.DrawEllipse(p, 10, 100, 20, 20);

        }
        void docfile()
        {
            ReadFile rf = new ReadFile();
            theword = theword = rf.readfile();
        }
        string getRandomWord()
        {
            string[] words = theword.Split('\n');
            Random ran = new Random();
            return words[ran.Next(0, words.Length - 1)];

        }
        void makelabels()
        {
            word = getRandomWord();
            char[] letters = word.ToCharArray();
            int wordsposition = 370 / letters.Length - 1;
            for (int i = 0; i < letters.Length - 1; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * wordsposition + 10), 80);
                labels[i].Text = "_";
                labels[i].Parent = groupBoxWords;
                labels[i].BringToFront();
                labels[i].CreateControl();
            }
            labelWordLength.Text = "Word Length: " + (letters.Length - 1);
        }
        private void HangManTester_Shown(object sender, EventArgs e)
        {
            DrawPost();
            makelabels();
        }
        private void buttonSubmitLetter_Click(object sender, EventArgs e)
        {
            if (textBoxLetters.Text == "")
            {
                MessageBox.Show("You can only sumbit a letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            char letter = textBoxLetters.Text.ToLower().ToCharArray()[0];
            if (!char.IsLetter(letter))
            {
                MessageBox.Show("You can only sumbit a letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                foreach (Label l in labels)
                    if (l.Text == "_") return;
                MessageBox.Show("You Won!", "Congrats");
                ResetGame();
            }
            else
            {
                MessageBox.Show("The letter isn't in the word!", "Sorry");
                labelMissed.Text += " " + letter.ToString() + ",";
                DrawMan((BodyParts)missedcount);
                missedcount++;
                if (missedcount == 4)
                {
                    MessageBox.Show("Sorry but you lost! The answer was: " + word);
                    ResetGame();
                }
            }
        }
        void ResetGame()
        {
            Graphics g = panelHangMan.CreateGraphics();
            g.Clear(panelHangMan.BackColor);
            getRandomWord();
            makelabels();
            DrawPost();
            labelMissed.Text = "Missed: ";
            textBoxLetters.Text = "";
        }
        private void buttonSubmitWord_Click(object sender, EventArgs e)
        {
            if (textBoxSubmit.Text == word)
            {
                MessageBox.Show("You Won!", "Congrats");
                ResetGame();
            }
            else
            {
                MessageBox.Show("Wrong word!", "Sorry");
                DrawMan((BodyParts)missedcount);
                missedcount++;
                if (missedcount == 4)
                {
                    MessageBox.Show("Sorry but you lost! The answer was: " + word);
                    ResetGame();
                }
            }
        }
        private void HangManTester_Load(object sender, EventArgs e)
        {
            docfile();
        }

        private void userControlAlphabet1_Load(object sender, EventArgs e)
        {

        }
    }
}
