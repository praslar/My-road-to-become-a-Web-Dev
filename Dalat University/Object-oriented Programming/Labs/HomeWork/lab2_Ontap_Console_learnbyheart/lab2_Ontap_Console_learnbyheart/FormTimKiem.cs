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
    public partial class FormTimKiem : Form
    {
        public FormTimKiem()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = e.ToString();
        }
    }
}
