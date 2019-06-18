using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_ontap
{
    public partial class FormTiemKiem_SapXep : Form
    {
        public FormTiemKiem_SapXep(bool kieutuychon)
        {
            InitializeComponent();
            if (kieutuychon)
            {
                this.groupBoxsearch.Enabled = false;
                this.buttonsort.Enabled = true;
                this.maskedTextBox1.Enabled = false;
            }
            else
            {
                this.groupBoxsort.Enabled = false;
                this.buttonsearch.Enabled = true;
            }
        }
        public enum Kieu
        {
            TheoMa,
            TheoTen,
            TheoNgaySinh
        }
        public string strTim
        {
            get { return this.maskedTextBox1.Text; }
        }
        public Kieu kieu
        {
            get
            {
                if (radioButtonhoTen.Checked)
                    return Kieu.TheoTen;
                else
                    if (radioButtonmaSV.Checked)
                    return Kieu.TheoMa;
                return Kieu.TheoNgaySinh;
            }
        }
        private void buttonsearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonsort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radioButtonngaySinh_CheckedChanged(object sender, EventArgs e)
        {
            this.maskedTextBox1.Mask = "00/00/0000";
        }
        private void radioButtonmaSV_CheckedChanged(object sender, EventArgs e)
        {
            this.maskedTextBox1.Mask = "SV.00000";
        }
        private void radioButtonhoTen_CheckedChanged(object sender, EventArgs e)
        {
            this.maskedTextBox1.Mask = "";
        }
        private void buttoncancel_Click(object sender, EventArgs e)
        {
            var dlg = MessageBox.Show("Yes or No!", "Cancel", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
