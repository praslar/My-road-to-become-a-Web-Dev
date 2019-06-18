using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Relearn_abcxyz
{
    public partial class Form2 : Form
    {
        RadioButton rdbtn;
        public Form2(bool kieutuychon)
        {
            InitializeComponent();
            if(kieutuychon)
            {
                this.groupBox2.Enabled = false;
            }
            else
            {
                this.groupBox3.Enabled = false;
            }
        }
        private void radioButtonhoTen_CheckedChanged(object sender, EventArgs e)
        {
            rdbtn = sender as RadioButton;
            this.label1.Text = rdbtn.Text;
            this.OnClick(e);
        }
        public enum Kieu
        {
            TheoMa,
            TheoTen,
            TheoNgay
        }
        public Kieu kieu
        {
            get
            {
                if (this.radioButtonmaSV.Checked)
                    return Kieu.TheoMa;
                if (this.radioButtonhoTen.Checked)
                    return Kieu.TheoTen;
                return Kieu.TheoNgay;
            }
        }
        public string strTim
        {
            get { return this.textBox1.Text; }
        }
        private void buttontim_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Hãy nhập thông tin");
                return;
            }
            this.Close();
        }
        private void buttonsapXep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
