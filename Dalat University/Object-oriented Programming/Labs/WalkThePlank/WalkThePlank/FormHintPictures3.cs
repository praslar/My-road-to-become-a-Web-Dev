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
    public partial class FormHintPictures3 : Form
    {
        int time = 10;
        public FormHintPictures3()
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

        private void FormHintPictures3_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
