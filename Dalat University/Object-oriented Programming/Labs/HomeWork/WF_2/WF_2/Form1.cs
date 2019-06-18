using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        private void Reset()
        {
            this.comboBoxMaHocVien.Text = "";
            this.textBoxHoTen.Text = "";
            this.dateTimePickerNgayDanhKy.Value = DateTime.Now;
            this.radioButtonGioiTinhNam.Checked = true;
            this.checkBoxTiengAnhA.Checked = false;
            this.checkBoxTiengAnhB.Checked = false;
            this.checkBoxTinHocA.Checked = false;
            this.checkBoxTinHocB.Checked = false;
            this.textBoxTongTien.Text = "";
        }

        private void textBoxTongTien_TextChanged(object sender, EventArgs e)
        {
            int s = 0;
            if(checkBoxTinHocA.Checked)
                s+= int.Parse()
        }
    }
}
