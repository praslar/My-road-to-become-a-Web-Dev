using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ontaplab2_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (checkBox1.Checked)
                s += int.Parse(label1.Text.Split('.')[0]);

            if (checkBox2.Checked)
                s += int.Parse(label2.Text.Split('.')[0]);

            if (checkBox3.Checked)
                s += int.Parse(label3.Text.Split('.')[0]);

            if (checkBox4.Checked)
                s += int.Parse(label4.Text.Split('.')[0]);
            this.textBox1.Text = s + ".000 đồng";
        }
    }
}
