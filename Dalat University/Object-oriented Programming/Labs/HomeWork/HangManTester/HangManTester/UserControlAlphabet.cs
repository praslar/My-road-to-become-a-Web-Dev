using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManTester
{
    public partial class UserControlAlphabet : UserControl
    {
        Button btnresult;
        public UserControlAlphabet()
        {
            InitializeComponent();
        }
        public string GetString
        {
            get { return this.buttonresult.Text; }
        }
        private void button_Click(object sender, EventArgs e)
        {
            btnresult = sender as Button;
            this.buttonresult.Text = btnresult.Text;
            this.OnClick(e);
        }
    }
}
