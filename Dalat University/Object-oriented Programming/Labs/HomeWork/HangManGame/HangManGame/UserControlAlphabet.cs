using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManGame
{
    public partial class UserControlAlphabet : UserControl
    {
        Button btnCurrent;
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
            btnCurrent = sender as Button;
            this.buttonresult.Text = btnCurrent.Text;
            this.OnClick(e);
        }
    }
}
