using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_relearn_abc
{
    public partial class FormTuyChon : Form
    {
        RadioButton btn;
        public FormTuyChon(bool tuychon)
        {
            InitializeComponent();
            if (tuychon)
                this.groupBox2.Enabled = false;
            else
                this.groupBox3.Enabled = false;
        }
        public enum KieuTuyChon
        {
            TheoMa,
            TheoTen,
            TheoNgaySinh
        }
        public KieuTuyChon ktc
        {
            get
            {
                if (this.radioButtonmaSo.Checked)
                    return KieuTuyChon.TheoMa;
                if (this.radioButtonhoTen.Checked)
                    return KieuTuyChon.TheoTen;
                return KieuTuyChon.TheoNgaySinh;
            }
        }
        public string strTim
        {
            get { return this.textBox1.Text; }
        }
        private void radioButtonmaSo_CheckedChanged(object sender, EventArgs e)
        {
            btn = sender as RadioButton;
            this.label1.Text = btn.Text;
            this.OnClick(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
