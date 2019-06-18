using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C2_VD1
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        //private void buttonExit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();

        //}

        //private void buttonBackColor_Click(object sender, EventArgs e)
        //{
        //    //this.BackColor = Color.FromArgb(240, 200, 140);
        //    this.BackColor = Color.Violet;
        //}

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name == "buttonExit")
            {
                DialogResult dlg= MessageBox.Show("Ban co tat chuong trinh khong?",
                    "Hoi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                    );
                if (dlg== DialogResult.Yes)
                {
                    Application.Exit();
                }
                
            }
            else
            {
                this.BackColor = Color.Violet;
                frmSinhVien frm = new frmSinhVien();
                //frm.Show();
                frm.ShowDialog();
            }
        }

        private void buttonBackColor_MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonBackColor.ForeColor = Color.Red;
            this.Cursor = Cursors.Cross;
        }

        private void buttonBackColor_MouseLeave(object sender, EventArgs e)
        {
            this.buttonBackColor.ForeColor = Color.Blue;
            this.Cursor = Cursors.Default;
        }

        private void buttonExit_MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonExit.Visible = false;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            this.buttonExit.Visible = true;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.Text = "Chuong trinh dau tien!";
            this.buttonBackColor.BackColor = Color.White;
            this.MinimizeBox = false;
            this.MaximizeBox = false;                    
         
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.None:
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.UserClosing:
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.ApplicationExitCall:
                    //
                    MessageBox.Show("ApplicationExitCall");
                    break;
                default:
                    break;
            }
        }
    }
}
