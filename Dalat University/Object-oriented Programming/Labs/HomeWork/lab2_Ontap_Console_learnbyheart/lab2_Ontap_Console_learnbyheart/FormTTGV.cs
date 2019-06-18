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
    public partial class FormTTGV : Form
    {
        public FormTTGV()
        {
            InitializeComponent();
        }
        public void SetText(string s)
        {
            this.label1.Text = s;
        }
    }
}
