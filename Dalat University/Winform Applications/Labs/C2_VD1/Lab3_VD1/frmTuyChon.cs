using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_VD1
{
    public partial class frmTuyChon : Form
    {
        public enum Kieu
        {
           TheoMaSV,
           TheoTen,
           TheoNamSinh
        }
        public string ChuoiTim
        {
            get { return this.textBoxChuoiTim.Text; }
        }
        public Kieu KieuTuyChon
        {
            get {
                Kieu k = Kieu.TheoMaSV;
                if (this.radioButtonTen.Checked)
                    k = Kieu.TheoTen;
                else
                    if (this.radioButtonNamSinh.Checked)
                    k = Kieu.TheoNamSinh;
                return k;
            }
        }
    
        public Kieu GetTuyChon()
        {
            Kieu k = Kieu.TheoMaSV;
            if (this.radioButtonTen.Checked)
                k = Kieu.TheoTen;
            else
                if (this.radioButtonNamSinh.Checked)
                k = Kieu.TheoNamSinh;
            return k;
        }

        public frmTuyChon()
        {
            InitializeComponent();
        }
        public frmTuyChon(bool timkiem)
        {
            InitializeComponent();

            if (timkiem)
            {
                this.buttonSX.Enabled = false;
                this.groupBoxTim.Enabled = true;
            }
            else
            {
                this.groupBoxTim.Enabled = false;
                this.buttonSX.Enabled = true;
            }
        }

        private void frmTuyChon_Load(object sender, EventArgs e)
        {

        }

        private void buttonSX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (this.ChuoiTim.Length == 0)
            {
                MessageBox.Show("Nhap chuoi can tim!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
                this.Close();
        }
    }
}
