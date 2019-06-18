using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkThePlank
{
    public partial class FormHintPictures2 : Form
    {
        int time = 10;
        public FormHintPictures2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            this.label4.Text = time.ToString();
            if (time == 0)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void FormHintPictures2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
