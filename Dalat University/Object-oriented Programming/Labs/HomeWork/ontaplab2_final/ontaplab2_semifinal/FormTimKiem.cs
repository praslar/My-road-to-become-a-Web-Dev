using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ontaplab2_semifinal
{
    public partial class FormTimKiem : Form
    {
        RadioButton rdbtncurrent;
        public FormTimKiem()
        {
            InitializeComponent();
        }
        private void radioButtonmaSo_CheckedChanged(object sender, EventArgs e)
        {
            rdbtncurrent = sender as RadioButton;
            this.label1.Text = rdbtncurrent.Text + ":";
            this.OnClick(e);
        }
        public enum KieuTim
        {
            TheoMaSo,
            TheoTen,
            TheoSoDT
        }
        public string GetString
        {
            get { return this.textBox1.Text; }
        }
        public KieuTim kieutim
        {
            get
            {
                if (radioButtonmaSo.Checked == true)
                    return KieuTim.TheoMaSo;
                else
                    if(radioButtonhoTen.Checked == true)
                        return KieuTim.TheoTen;
                return KieuTim.TheoSoDT;               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
