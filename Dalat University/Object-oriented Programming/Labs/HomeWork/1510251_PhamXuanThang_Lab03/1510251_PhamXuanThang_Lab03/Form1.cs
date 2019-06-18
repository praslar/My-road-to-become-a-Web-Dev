using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1510251_PhamXuanThang_Lab03
{
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }
        QuanLySinhVien quanLySinhVien;
        //Lấy thông tin sinh viên từ controls thông tin SV
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gioiTinh = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.maskedTextBoxMS.Text;
            sv.HoTen = this.textBoxhoTen.Text;
            sv.NgaySinh = this.dateTimePickerngaySinh.Value;
            sv.DiaChi = this.textBoxdiaChi.Text;
            sv.Lop = this.comboBoxlop.Text;
            sv.Hinh = this.textBoxhinh.Text;
            if (radioButtonNu.Checked)
                gioiTinh = false;
            sv.GioiTinh = gioiTinh;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                if (checkedListBoxchuyenNganh.GetItemChecked(i))
                    cn.Add(checkedListBoxchuyenNganh.Items[i].ToString());
            sv.ChuyenNganh = cn;
            return sv;            
        }
        //Lấy thông tin sinh viên từ ListView
        private SinhVien GetSinhVienListView(ListViewItem listViewItem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = listViewItem.SubItems[0].Text;
            sv.HoTen = listViewItem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(listViewItem.SubItems[2].Text);
            sv.DiaChi = listViewItem.SubItems[3].Text;
            sv.Lop = listViewItem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (listViewItem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;
            List<string> chuyenNganh = new List<string>();
            string[] chuyennganh = listViewItem.SubItems[6].Text.Split(',');
            foreach (string item in chuyennganh)
                chuyenNganh.Add(item);
            sv.ChuyenNganh = chuyenNganh;
            sv.Hinh = listViewItem.SubItems[7].Text;
            return sv;
        }
        //Thiêt lập các thông tin lên controls sinh viên
       private void ThietLapThongTin(SinhVien sv)
        {
            this.maskedTextBoxMS.Text = sv.MaSo;
            this.textBoxhoTen.Text = sv.HoTen;
            this.dateTimePickerngaySinh.Value = sv.NgaySinh;
            this.textBoxdiaChi.Text = sv.DiaChi;
            this.comboBoxlop.Text = sv.Lop;
            this.textBoxhinh.Text = sv.Hinh;
            this.pictureBoxhinhSV.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.radioButtonNam.Checked = true;
            else
                this.radioButtonNu.Checked = true;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
            {
                this.checkedListBoxchuyenNganh.SetItemChecked(i, false);
            }
            foreach (string item in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                    if (item.CompareTo(this.checkedListBoxchuyenNganh.Items[i]) == 0)
                        this.checkedListBoxchuyenNganh.SetItemChecked(i, true);
            }
        }
        //Thêm sinh viên vào listview
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvItem = new ListViewItem(sv.MaSo);
            lvItem.SubItems.Add(sv.HoTen);
            lvItem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvItem.SubItems.Add(sv.DiaChi);
            lvItem.SubItems.Add(sv.Lop);
            string gioiTinh = "Nữ";
            if (sv.GioiTinh)
                gioiTinh = "Nam";
            lvItem.SubItems.Add(gioiTinh);
            string cn = "";
            foreach (string item in sv.ChuyenNganh)
                cn += item + ",";
            cn = cn.Substring(0,cn.Length);
            lvItem.SubItems.Add(cn);
            lvItem.SubItems.Add(sv.Hinh);
            this.listView1.Items.Add(lvItem);
        }
        private void LoadListView()
        {

            this.listView1.Items.Clear();
            foreach(SinhVien sv in quanLySinhVien.DanhSach)
            {
                ThemSV(sv);
            }
            this.toolStripStatusLabel.Text = "Tổng Sinh Vien: " + this.listView1.Items.Count;
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            quanLySinhVien = new QuanLySinhVien();
            quanLySinhVien.DocTuFile();
            LoadListView();
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.listView1.SelectedItems.Count;
            if(count > 0)
            {
                ListViewItem lvitem = this.listView1.SelectedItems[0];
                SinhVien sv = GetSinhVienListView(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = quanLySinhVien.Tim(sv.MaSo, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm sinh viên",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.quanLySinhVien.Them(sv);
                this.LoadListView();
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.listView1.Items.Count - 1;
            for (i = count  ; i >=0; i--)
            {
                lvitem = this.listView1.Items[i];
                if (lvitem.Checked)
                    quanLySinhVien.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.buttonmacDinh.PerformClick();
        }

        private void buttonmacDinh_Click(object sender, EventArgs e)
        {
            this.maskedTextBoxMS.Text = "";
            this.textBoxhoTen.Text = "";
            this.dateTimePickerngaySinh.Value = DateTime.Now;
            this.textBoxdiaChi.Text = "";
            this.comboBoxlop.Text = this.comboBoxlop.Items[0].ToString();
            this.textBoxhinh.Text = "";
            this.pictureBoxhinhSV.ImageLocation = "";
            this.radioButtonNam.Checked = true;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count - 1; i++)
                this.checkedListBoxchuyenNganh.SetItemChecked(i, false);
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = quanLySinhVien.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if(kqsua)
            {
                this.LoadListView();
            }
        }

        private void buttonhinh_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxhinh.Text = openFileDialog.FileName;
                this.pictureBoxhinhSV.ImageLocation = openFileDialog.FileName;
            }
        }

        private void toolStripStatusLabel_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabel.Text = "Tổng Sinh Viên: " + this.listView1.Items.Count;
        }

        private void toolStripStatusLabel_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripStatusLabel.Text = "Tổng Sinh Viên: " + this.listView1.Items.Count;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            this.listView1.Font = fontDialog.Font;
            this.listView1.ForeColor = fontDialog.Color;
        }

        private void fontDialog_Apply(object sender, EventArgs e)
        {
            this.listView1.Font = fontDialog.Font;
            this.listView1.ForeColor = fontDialog.Color;
        }

        private void màuChữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            this.listView1.BackColor = colorDialog.Color;
        }

        

        
    }
}
