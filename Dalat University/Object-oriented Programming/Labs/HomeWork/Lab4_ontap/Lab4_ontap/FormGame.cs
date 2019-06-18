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

namespace Lab4_ontap
{
    public partial class FormGame : Form
    {
        int thoigian, vitrgo;
        char kytugo;
        char kytutext;
        int length;
        public FormGame()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            thoigian = 120;
            vitrgo = 0;
            Random rd = new Random();
            string filename = "BaiGo" + rd.Next(1, 4) + ".txt";
            StreamReader sr = new StreamReader(File.OpenRead(filename));
            this.richTextBox1.Text = sr.ReadToEnd();
            length = this.richTextBox1.Text.Length;
            this.richTextBox1.Select(vitrgo, 1);
            this.progressBar1.Value = thoigian;
            this.timer1.Start();
            this.button1.Visible = false;
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void FormGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Restart?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                Reset();
            }
            else
            {
                Application.Exit();
            }
        }
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            kytugo = e.KeyChar;
            kytutext = this.richTextBox1.Text[vitrgo];
            if (kytutext == kytugo)
            {
                vitrgo++;
                if (vitrgo == length)
                {
                    this.timer1.Stop();
                    MessageBox.Show("Win");
                    this.button1.Visible = true;           
                    this.richTextBox1.Text = "";
                }
                else
                    richTextBox1.Select(vitrgo, 1);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            thoigian--;
            int t = thoigian * 100 / 120;
            t = t > 0 ? t : 0;
            this.progressBar1.Value = thoigian > 0 ? thoigian : 0;
            this.label1.Text = t + "%";
            if (thoigian == 0)
            {
                MessageBox.Show("Lose");
                this.timer1.Stop();
                this.button1.Visible = true;
                this.richTextBox1.Text = "";
            }
        }
    }
}
