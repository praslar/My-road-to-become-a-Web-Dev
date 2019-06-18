using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam_Labthree
{
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }
        private void buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonmacdinh_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        public void Reset()
        {
            this.maskedTextBoxmaSo.Text = "";
            this.textBoxhoTen.Text = "";
            this.dateTimePicker1.Value = DateTime.Now;
            this.textBoxdiaChi.Text = "";
            this.comboBoxlop.Text = "";
            this.textBoxhinh.Text = "";
            this.pictureBoxsinhVien.ImageLocation = "";
            this.radioButtonnam.Checked = true;
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                this.checkedListBox1.SetItemChecked(i, false);
        }
    }
}
