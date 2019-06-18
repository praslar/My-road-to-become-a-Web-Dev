using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace relearn_lab2_abcxyz
{
    public partial class FormTimGV : Form
    {
        RadioButton btn;
        public string strtim
        {
            get { return this.textBox1.Text; }
        }
        public enum TimKiem
        {
            TheoMaSo,
            TheoHoTen,
            TheoSoDT
        }
        public TimKiem Ktim
        {
            get
            {
                if (radioButtonmaSo.Checked)
                    return TimKiem.TheoMaSo;
                if (radioButtonhoTen.Checked)
                    return TimKiem.TheoHoTen;
                return TimKiem.TheoSoDT;
            }
        }
        public FormTimGV()
        {
            InitializeComponent();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            btn = sender as RadioButton;
            this.label1.Text = btn.Text;
            this.OnClick(e);
        }
        private void buttonTim_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
