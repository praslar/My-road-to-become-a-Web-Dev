using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_exam_lab2._2
{
    public partial class FormTimKiem : Form
    {
        RadioButton btnrd;
        public enum KieuTim
        {
            TheoTen,
            TheoMaSo,
            TheoSDT
        }
        public KieuTim kTim
        {
            get
            {
                if (this.radioButtonhoTen.Checked == true)
                    return KieuTim.TheoTen;
                if (this.radioButtonmaGV.Checked == true)
                    return KieuTim.TheoMaSo;
                return KieuTim.TheoSDT;
            }
        }
        public FormTimKiem()
        {
            InitializeComponent();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            btnrd = sender as RadioButton;
            this.label1.Text = btnrd.Text;
        }
        public string strTim
        {
            get { return this.textBoxtim.Text; }
        }
        private void buttonok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
