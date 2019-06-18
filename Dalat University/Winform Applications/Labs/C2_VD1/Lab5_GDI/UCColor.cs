using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_GDI
{
    public partial class UCColor : UserControl
    {
        Button btnCurrent;
        public Color GetColor
        {
            get { return this.buttonColor.BackColor; }
        }
        public UCColor()
        {
            InitializeComponent();
        }

        private void buttonColors_Click(object sender, EventArgs e)
        {
            btnCurrent = sender as Button;            
            this.buttonColor.BackColor= btnCurrent.BackColor;
            this.OnClick(e);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.colorDialog.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                this.btnCurrent.BackColor = this.colorDialog.Color;
            }
        }
    }
}
