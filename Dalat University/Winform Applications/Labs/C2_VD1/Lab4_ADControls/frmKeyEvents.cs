using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_ADControls
{
    public partial class frmKeyEvents : Form
    {
        public frmKeyEvents()
        {
            InitializeComponent();
        }

        private void frmKeyEvents_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.labelChar.Text = e.KeyChar.ToString();
        }

        private void frmKeyEvents_KeyDown(object sender, KeyEventArgs e)
        {
            this.labelInfo.Text = e.Shift ? "yes " : "no "
                +( e.Control ? "yes" : "no");
        }
    }
}
