using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Ontap
{
    public partial class TimTTGiaoVien : Form
    {
        public enum KieuTim
        {
            TheoMa,
            TheoHoTen,
            TheoSDT
        }
        public string strTim
        {
            get { return this.textBoxTim.Text; }
        }
        public KieuTim KTim
        {
            get
            {
                if (radioButtonhoTen.Checked)
                {
                    return KieuTim.TheoHoTen;
                }
                if (radioButtonSDT.Checked)
                {
                    return KieuTim.TheoSDT;
                }
                return KieuTim.TheoMa;
            }
        }
        public TimTTGiaoVien()
        {
            InitializeComponent();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonmaGV_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = this.radioButtonmaGV.Text;
        }

        private void radioButtonhoTen_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = this.radioButtonhoTen.Text;
        }

        private void radioButtonSDT_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = this.radioButtonSDT.Text;
        }
    }
}
