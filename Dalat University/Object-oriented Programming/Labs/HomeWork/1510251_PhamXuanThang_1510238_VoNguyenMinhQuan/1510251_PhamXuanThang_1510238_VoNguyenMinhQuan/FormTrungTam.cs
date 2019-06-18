using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1510251_PhamXuanThang_1510238_VoNguyenMinhQuan
{
    public partial class FormTrungTam : Form
    {
        public FormTrungTam()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Application.
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.RESET();
        }

        private void RESET()
        {
            this.comboboxMaHV.Text = "";
            this.textBoxHoTen.Text = "";
            this.dateTimePickerNgayDangKy.Value = DateTime.Now;
            this.radioButtonNam.Checked = true;
            this.checkBoxTiengAnhA.Checked = false;
            this.checkBoxTiengAnhB.Checked = false;
            this.checkBoxTinHocA.Checked = false;
            this.checkBoxTinHocB.Checked = false;
            this.textBoxTongTien.Text = "";
        }

        private void buttonTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (checkBoxTinHocA.Checked)
                s += int.Parse(labelTHA.Text.Split('.')[0]);
            if (checkBoxTinHocB.Checked)
                s += int.Parse(labelTHB.Text.Split('.')[0]);
            if (checkBoxTiengAnhA.Checked)
                s += int.Parse(labelTAA.Text.Split('.')[0]);
            if (checkBoxTiengAnhB.Checked)
                s += int.Parse(labelTAB.Text.Split('.')[0]);
            this.textBoxTongTien.Text = s + ".000 đồng";
        }
    }
}
