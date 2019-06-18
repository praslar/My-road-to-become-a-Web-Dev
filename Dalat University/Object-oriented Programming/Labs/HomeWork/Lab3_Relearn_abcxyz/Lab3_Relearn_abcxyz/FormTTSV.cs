using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Relearn_abcxyz
{
    public partial class FormTTSV : Form
    {
        public delegate int SoSanh(object obj1, object obj2);
        public QuanLySinhVien qlsv;
        public FormTTSV()
        {
            InitializeComponent();
        }
        public NhanVien GetSinhVien()
        {
            NhanVien sv = new NhanVien();
            sv.MaNhanVien = this.maskedTextBoxmaSo.Text;
            sv.HoTen = this.textBoxhoTen.Text;
            sv.NgaySinh = this.dateTimePickerngaySinh.Value;
            sv.DiaChi = this.textBoxdiaChi.Text;
            sv.EventManager = this.comboBoxlop.Text;
            sv.Hinh = this.textBoxdiaChiHinh.Text;
            sv.GioiTinh = false;
            if (radioButtonnam.Checked)
                sv.GioiTinh = true;
            
            List<string> cn = new List<string>();
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                if (this.checkedListBoxchuyenNganh.GetItemChecked(i))
                    cn.Add(checkedListBoxchuyenNganh.Items[i].ToString());
            sv.ChuyenMon = cn;
            return sv;
        }
        public NhanVien GetSinhVienListView(ListViewItem lvitem)
        {
            NhanVien sv = new NhanVien();
            sv.MaNhanVien = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.EventManager = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;
            
            List<string> cn = new List<string>();
            string[] t = lvitem.SubItems[6].Text.Split(',');
            foreach (string item in t)
                cn.Add(item);
            sv.ChuyenMon = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
        public void ThietLapThongTin(NhanVien sv)
        {
            this.maskedTextBoxmaSo.Text = sv.MaNhanVien;
            this.textBoxhoTen.Text = sv.HoTen;
            this.dateTimePickerngaySinh.Value = sv.NgaySinh;
            this.textBoxdiaChi.Text = sv.DiaChi;
            this.comboBoxlop.Text = sv.EventManager;
            this.textBoxdiaChiHinh.Text = sv.Hinh;
            this.pictureBoxsv.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.radioButtonnam.Checked = true;
            else
                this.radioButtonnu.Checked = true;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                this.checkedListBoxchuyenNganh.SetItemChecked(i, false);
            foreach (string item in sv.ChuyenMon)
                for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)               
                    if (item.CompareTo(this.checkedListBoxchuyenNganh.Items[i]) == 0)
                        this.checkedListBoxchuyenNganh.SetItemChecked(i, true);
        }
        public void ThemSinhVienListView(NhanVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaNhanVien);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.EventManager);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string t in sv.ChuyenMon)
                cn += t + ",";
            if (cn.Length > 0)
            {
                cn = cn.Substring(0, cn.Length - 1);
            }
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.listView.Items.Add(lvitem);
        }
        public void LoadListView()
        {
            this.listView.Items.Clear();
            foreach (NhanVien sv in qlsv.dssv)
                ThemSinhVienListView(sv);
            int i = this.qlsv.dssv.Count;
            this.toolStripStatusLabel1.Text = "Tổng số sinh viên: " + i;
        }
        //=======================================================================
        public int SoSanhTheoMa(object obj1, object obj2)
        {
            NhanVien sv = obj2 as NhanVien;
            return sv.MaNhanVien.CompareTo(obj1.ToString());
        }
        public int SoSanhTheoTen(object obj1,object obj2)
        {
            NhanVien sv = obj2 as NhanVien;
            return sv.HoTen.CompareTo(obj1);
        }
        public int SoSanhTheoNgay(object obj1,object obj2)
        {
            NhanVien sv = obj2 as NhanVien;
            return sv.NgaySinh.CompareTo(obj1);
        }
        public int SapXepTheoMa(object obj1,object obj2)
        {
            NhanVien sv1 = obj1 as NhanVien;
            NhanVien sv2 = obj2 as NhanVien;
            return sv1.MaNhanVien.CompareTo(sv2.MaNhanVien);
        }
        public int SapXepTheoTen(object obj1, object obj2)
        {
            NhanVien sv1 = obj1 as NhanVien;
            NhanVien sv2 = obj2 as NhanVien;
            return sv1.HoTen.CompareTo(sv2.HoTen);
        }
        public int SapXepTheoNgaySinh(object obj1, object obj2)
        {
            NhanVien sv1 = obj1 as NhanVien;
            NhanVien sv2 = obj2 as NhanVien;
            return sv1.NgaySinh.CompareTo(sv2.NgaySinh);
        }
        public int TimXuat(object obj1,SoSanh ss)
        {
            int i = 0;
            foreach (NhanVien sv in qlsv.dssv)
            {
                if (ss(obj1,sv)==0)
                {
                    i++;
                    MessageBox.Show(sv.ToString());
                }
            }
            return i;
        }
        //=====================================================================
        private void buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonmacDinh_Click(object sender, EventArgs e)
        {
            this.maskedTextBoxmaSo.Text = "";
            this.textBoxhoTen.Text = "";
            this.dateTimePickerngaySinh.Value = DateTime.Now;
            this.textBoxdiaChi.Text = "";
            this.comboBoxlop.Text = "";
            this.pictureBoxsv.ImageLocation = "";
            this.textBoxdiaChiHinh.Text = "";
            this.radioButtonnam.Checked = true;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                this.checkedListBoxchuyenNganh.SetItemChecked(i, false);
        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = this.listView.SelectedItems.Count;
            if (i>0)
            {
                ListViewItem lvitem = this.listView.SelectedItems[0];
                NhanVien sv = GetSinhVienListView(lvitem);
                ThietLapThongTin(sv);
            }
        }
        private void buttonthem_Click(object sender, EventArgs e)
        {
            NhanVien sv = GetSinhVien();
            NhanVien kq = qlsv.Tim(sv.MaNhanVien, SoSanhTheoMa);
            if (kq!=null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công!");
                this.qlsv.Them(sv);
                LoadListView();
            }
            
        }       
        private void buttonxoa_Click(object sender, EventArgs e)
        {
            ListViewItem lvitem;
            for (int i = 0; i < this.listView.Items.Count; i++)
            {
                lvitem = this.listView.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.buttonmacDinh.PerformClick();
        }
        private void buttonsua_Click(object sender, EventArgs e)
        {
            NhanVien sv = GetSinhVien();
            bool kq = qlsv.Sua(sv, sv.MaNhanVien, SoSanhTheoMa);
            if (kq)
            {
                MessageBox.Show("Sửa thông tin thành công");
                this.LoadListView();
            }
            else
                MessageBox.Show("Lỗi");

        }
        private void FormTTSV_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.ReadFile();
            LoadListView();
        }
        private void buttondiaChiHinh_Click(object sender, EventArgs e)
        {
            DialogResult dlg = openFileDialog1.ShowDialog();
            if (dlg==DialogResult.OK)
            {
                this.pictureBoxsv.ImageLocation = this.openFileDialog1.FileName;
                this.textBoxdiaChiHinh.Text = this.openFileDialog1.FileName;
            }
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = fontDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                this.listView.Font = this.fontDialog1.Font;
                this.listView.ForeColor = this.fontDialog1.Color;
            }            
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = colorDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                this.listView.BackColor = this.colorDialog1.Color;
            }
        }
        private void tìmKiếmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i;
            string s = "Số sinh viên tìm thấy: ";
            if (qlsv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form2 frm = new Form2(false);
            frm.ShowDialog();
            Form2.Kieu tuychon = new Form2.Kieu();
            tuychon = frm.kieu;
            NhanVien kqtim;
            bool kq = false;
            switch (tuychon)
            {
                case Form2.Kieu.TheoMa:
                    kqtim = qlsv.Tim(frm.strTim, SoSanhTheoMa);
                    if (kqtim!=null)
                    {
                        MessageBox.Show("Số sinh viên tìm thấy: 1");
                        MessageBox.Show(kqtim.ToString());
                        kq = true;
                    }
                    break;
                case Form2.Kieu.TheoTen:
                    kqtim = qlsv.Tim(frm.strTim, SoSanhTheoTen);
                    if(kqtim!=null)
                    {
                        i = TimXuat(frm.strTim, SoSanhTheoTen);
                        s += s + i;
                        MessageBox.Show(s);
                        kq = true;
                    }
                    break;
                case Form2.Kieu.TheoNgay:
                    kqtim = qlsv.Tim(DateTime.Parse(frm.strTim), SoSanhTheoNgay);
                    if(kqtim!=null)
                    {
                        i = TimXuat(DateTime.Parse(frm.strTim), SoSanhTheoNgay);
                        s += s + i;
                        MessageBox.Show(s);
                        kq = true;
                    }
                    break;
                default:
                    break;
            }
            if (!kq)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
                return;
            }

        }
        private void sắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (qlsv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form2 frm = new Form2(true);
            frm.ShowDialog();
            Form2.Kieu tuychon = new Form2.Kieu();
            tuychon = frm.kieu;
            switch (tuychon)
            {
                case Form2.Kieu.TheoMa:
                    qlsv.SapXep(SapXepTheoMa);
                    break;
                case Form2.Kieu.TheoTen:
                    qlsv.SapXep(SapXepTheoTen);
                    break;
                case Form2.Kieu.TheoNgay:
                    qlsv.SapXep(SapXepTheoNgaySinh);
                    break;
                default:
                    break;
            }
            this.LoadListView();
        }
    }
}
