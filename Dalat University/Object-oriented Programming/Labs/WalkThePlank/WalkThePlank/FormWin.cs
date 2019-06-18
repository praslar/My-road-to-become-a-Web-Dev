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
    public partial class FormWin : Form
    {
        int thoigian = 10;
        public FormWin()
        {

            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            thoigian--;
            this.Opacity *= 5;
        }
        private void FormWin_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
