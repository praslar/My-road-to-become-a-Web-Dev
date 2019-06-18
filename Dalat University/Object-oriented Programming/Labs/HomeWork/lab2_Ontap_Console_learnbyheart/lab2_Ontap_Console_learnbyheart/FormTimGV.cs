using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_Ontap_Console_learnbyheart
{
    public partial class FormTimGV : Form
    {
        public enum KieuTim
        {
            TheoMa,
            TheoHoTen,
            TheoSDT
        }
        public string strTim
        {
            get { return this.textBoxstrTim.Text; }
        }
        public KieuTim kTim
        {
            get
            {
                if (radioButtonmaGV.Checked)
                    return KieuTim.TheoMa;
                else
                    if (radioButtonhoTen.Checked)
                    return KieuTim.TheoHoTen;
                return KieuTim.TheoSDT;               
            }
        }
        public FormTimGV()
        {
            InitializeComponent();
        }
        private void radioButtonmaGV_CheckedChanged(object sender, EventArgs e)
        {
            this.labeltim.Text = this.radioButtonmaGV.Text;
        }
        private void radioButtonhoTen_CheckedChanged(object sender, EventArgs e)
        {
            this.labeltim.Text = this.radioButtonhoTen.Text;
        }
        private void radioButtonSDT_CheckedChanged(object sender, EventArgs e)
        {
            this.labeltim.Text = this.radioButtonSDT.Text;
        }
        private void buttonsearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
