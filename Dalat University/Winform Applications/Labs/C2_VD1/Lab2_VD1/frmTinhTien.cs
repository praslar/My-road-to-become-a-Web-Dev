using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_VD1
{
    public partial class frmTinhTien : Form
    {
        public frmTinhTien()
        {
            InitializeComponent();
        }

        private void buttonThongTin_Click(object sender, EventArgs e)
        {
            string str = this.textBoxHoTen.Text;
            str +="\n\r sdt:"+ this.maskedTextBoxSoDT.Text;
            str += "\n\r Hoc lop:" + this.comboBoxLop.Text;
            str += "\n\r Ngay:" + this.dateTimePickerNgayDK.Value.ToShortDateString();
            string gt = "Nữ";
            if (this.radioButtonNam.Checked)
                gt = "Nam";

            str += "\n\r GT:" + gt;
            string mh = "\n\r Mon hoc:";
            for (int i = 0; i < this.checkedListBoxMonHoc.Items.Count; i++)
            {
                if (this.checkedListBoxMonHoc.GetItemChecked(i))
                   mh+=this.checkedListBoxMonHoc.Items[i].ToString()+",";
            }

            str += mh;
            MessageBox.Show(str);
        }

        private void frmTinhTien_Load(object sender, EventArgs e)
        {
            this.comboBoxLop.Items.Add("CTK38");

            this.comboBoxLop.Items.RemoveAt(0);

            int n = this.checkedListBoxMonHoc.Items.Count;
            for (int i = 0; i < n; i++)
            {
                this.checkedListBoxMonHoc.SetItemChecked(i, true);
            }

            //add strURL cho linklabel
            string str = "D://Lab2_WindowsApplication_Controls.pdf";// "http://dlu.edu.vn";
            this.linkLabelLienHe.Links.Add(0, str.Length, str);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int n = this.listBoxLop.SelectedItems.Count;
            for (int i = 0; i < n; i++)
            {
                this.comboBoxLop.Items.Add(this.listBoxLop.SelectedItems[i].ToString());
                this.listBoxLop.Items.Remove(this.listBoxLop.SelectedItems[i].ToString());
                n--;

            }
        }

        private void buttonTinhTien_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            //string temp = this.labelTHA.Text;//300.000 dong
            //temp = temp.Split('.')[0];
            if (this.checkBoxTHA.Checked)
                tongtien += int.Parse(this.labelTHA.Text.Split('.')[0]);

            this.textBoxTongTien.Text = tongtien.ToString() + ".000 đồng";

            
          

        }

        private void linkLabelLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string str = e.Link.LinkData.ToString();
            //MessageBox.Show(str);
            if (str.Length > 0)
                Process.Start(str);
        }
    }
}
