using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_ADControls
{
    public partial class frmAdControls : Form
    {
        public frmAdControls()
        {
            InitializeComponent();
        }

        private void frmAdControls_Load(object sender, EventArgs e)
        {
            this.labelTimer.Text = DateTime.Now.ToLongTimeString();
            this.timer.Start();
            this.timerTitle.Start();

           // this.progressBar.Increment(80);

            // this.progressBar.PerformStep();
            this.labelValue.Text = this.progressBar.Value.ToString() + "%";

            this.textBoxColor.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.labelTimer.Text = DateTime.Now.ToLongTimeString();

            //this.progressBar.PerformStep();
            //this.progressBar.Increment(10);

            //this.progressBar.Value=this.progressBar.Value - 10;
            this.labelValue.Text = this.progressBar.Value.ToString() + "%";
        }

        private void timerTitle_Tick(object sender, EventArgs e)
        {
            char s = this.Text[this.Text.Length - 1];
            this.Text = s + this.Text.Substring(0, this.Text.Length - 1);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int r, g, b;
            r = this.trackBarRed.Value;
            g = this.trackBarGreen.Value;
            b = this.trackBarBlue.Value;
            this.textBoxColor.BackColor = Color.FromArgb(r, g, b);
            this.labelColor.Text = "(" + r + "," + g + "," + b + ")";
        }

        private void textBoxMail_Validated(object sender, EventArgs e)
        {
            if (this.textBoxMail.Text.Contains("gmail.com"))
                this.errorProvider.SetError(textBoxMail, "");
            else
                this.errorProvider.SetError(textBoxMail, "Dia chi mail sai (aaa@gmail.com)");
        }

        //private void trackBarGreen_Scroll(object sender, EventArgs e)
        //{
        //    int r, g, b;
        //    r = this.trackBarRed.Value;
        //    g = this.trackBarGreen.Value;
        //    b = this.trackBarBlue.Value;
        //    this.textBoxColor.BackColor = Color.FromArgb(r, g, b);
        //    this.labelColor.Text = "(" + r + "," + g + "," + b + ")";
        //}

        //private void trackBarBlue_Scroll(object sender, EventArgs e)
        //{
        //    int r, g, b;
        //    r = this.trackBarRed.Value;
        //    g = this.trackBarGreen.Value;
        //    b = this.trackBarBlue.Value;
        //    this.textBoxColor.BackColor = Color.FromArgb(r, g, b);
        //    this.labelColor.Text = "(" + r + "," + g + "," + b + ")";
        //}
    }
}
