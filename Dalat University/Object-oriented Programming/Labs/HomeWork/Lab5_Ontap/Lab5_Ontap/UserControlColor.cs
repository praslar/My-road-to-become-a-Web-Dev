using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Ontap
{
    public partial class UserControlColor : UserControl
    {
        Button btnCurrent;
        public UserControlColor()
        {
            InitializeComponent();
        }
        public Color GetColorDrawPen
        {
            get { return this.buttonColor1.BackColor; }
        }
        public Color GetColorPainPen
        {
            get { return this.buttoncolor2.BackColor; }
        }
        private void button_Click(object sender, EventArgs e)
        {
            btnCurrent = sender as Button;
            this.buttonColor1.BackColor = btnCurrent.BackColor;
            this.OnClick(e);
        }
        private void button31_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.colorDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                this.buttonColor1.BackColor = this.colorDialog1.Color;
                this.buttoncolor2.BackColor = this.colorDialog1.Color;
            }
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnCurrent = sender as Button;
            this.buttoncolor2.BackColor = btnCurrent.BackColor;
        }
    }
}
