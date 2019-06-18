using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_ontap
{
    public partial class Form1 : Form
    {

        public delegate int SoSanh(object a, object b);
        QuanLySinhVien qlsv;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttondefault_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            this.maskedTextBoxMS.Text = "";
            this.textBoxhoTen.Text = "";
            this.dateTimePickerngaySinh.Text = DateTime.Now.ToString();
            this.textBoxdiaChi.Text = "";
            this.comboBoxlop.Text = "";
            this.textBoxhinh.Text = "";
            this.pictureBoxSV.ImageLocation = "";
            this.radioButtonnam.Checked = true;
            for (int i = 0; i < checkedListBoxchuyenNganh.Items.Count; i++)
                checkedListBoxchuyenNganh.SetItemChecked(i, false);
        }
        private SinhVien GetSinhVien()
        {
            bool gt = true;
            List<string> cn = new List<string>();
            SinhVien sv = new SinhVien();
            sv.MaSo = this.maskedTextBoxMS.Text;
            sv.HoTen = this.textBoxhoTen.Text;
            sv.NgaySinh = this.dateTimePickerngaySinh.Value;
            sv.DiaChi = this.textBoxdiaChi.Text;
            sv.Lop = this.comboBoxlop.Text;
            sv.Hinh = this.textBoxhinh.Text;
            if (radioButtonnu.Checked)
            {
                gt = false;
            }
            sv.GioiTinh = gt;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                if (checkedListBoxchuyenNganh.GetItemChecked(i))
                {
                    cn.Add(checkedListBoxchuyenNganh.Items[i].ToString());
                }
            sv.ChuyenNganh = cn;
            return sv;
        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
            {
                sv.GioiTinh = true;
            }
            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s)
                cn.Add(t);
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
        private void ThietLapThongTinSV(SinhVien sv)
        {
            this.maskedTextBoxMS.Text = sv.MaSo;
            this.textBoxhoTen.Text = sv.HoTen;
            this.dateTimePickerngaySinh.Value = sv.NgaySinh;
            this.textBoxdiaChi.Text = sv.DiaChi;
            this.comboBoxlop.Text = sv.Lop;
            this.textBoxhinh.Text = sv.Hinh;
            this.pictureBoxSV.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
            {
                this.radioButtonnam.Checked = true;
            }
            else
                this.radioButtonnu.Checked = true;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                this.checkedListBoxchuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < checkedListBoxchuyenNganh.Items.Count; i++)
                    if (s.CompareTo(this.checkedListBoxchuyenNganh.Items[i]) == 0)
                        this.checkedListBoxchuyenNganh.SetItemChecked(i, true);
            }
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
            {
                gt = "Nam";
            }
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.listViewDSSV.Items.Add(lvitem);
        }
        private void LoadListView()
        {
            this.listViewDSSV.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
            this.toolStripStatusLabeltongSoSV.Text = "Tổng số sinh viên: " + listViewDSSV.Items.Count;
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }
        private void listViewDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.listViewDSSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.listViewDSSV.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTinSV(sv);
            }
        }
        private void buttonthem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.KiemTra(sv.MaSo, SoSanhTheoMa);
            if (kq != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Errorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
                this.buttondefault.PerformClick();
            }
        }
        private void buttonxoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.listViewDSSV.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.listViewDSSV.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.buttondefault.PerformClick();
        }
        private void buttonsua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if(kqsua)
            {
                this.LoadListView();
            }
        }
        private void buttonHinh_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();
            if(dlg == DialogResult.OK)
            {
                this.textBoxhinh.Text = this.openFileDialog1.FileName;
                this.pictureBoxSV.ImageLocation = this.openFileDialog1.FileName;
            }
        }
        private void buttonFont_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.fontDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                this.listViewDSSV.Font = this.fontDialog1.Font;
                this.listViewDSSV.ForeColor = this.fontDialog1.Color;
            }
        }
        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            this.listViewDSSV.Font = this.fontDialog1.Font;
            this.listViewDSSV.ForeColor = this.fontDialog1.Color;
        }
        private void buttonColor_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.colorDialog1.ShowDialog();
            if (dlg==DialogResult.OK)
            {
                this.listViewDSSV.BackColor = this.colorDialog1.Color;
            }
        }
        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTiemKiem_SapXep form2 = new FormTiemKiem_SapXep(false);
            form2.ShowDialog();
            if (qlsv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SinhVien kqtim;
            bool kq = false;
            FormTiemKiem_SapXep.Kieu kieutim = new FormTiemKiem_SapXep.Kieu();
            kieutim = form2.kieu;
            switch (kieutim)
            {
                case FormTiemKiem_SapXep.Kieu.TheoMa:
                    kqtim = qlsv.KiemTra(form2.strTim, SoSanhTheoMa);
                    if (kqtim != null)
                    {
                        MessageBox.Show(kqtim.ToString());
                        kq = true;
                    }
                    break;
                case FormTiemKiem_SapXep.Kieu.TheoTen:
                    kqtim = qlsv.KiemTra(form2.strTim, SoSanhTheoHoTen);
                    if (kqtim != null)
                    {
                        TimXuat(form2.strTim, SoSanhTheoHoTen);
                        kq = true;
                    }
                    break;
                case FormTiemKiem_SapXep.Kieu.TheoNgaySinh:
                    kqtim = qlsv.KiemTra(DateTime.Parse(form2.strTim), SoSanhTheoNgaySinh);
                    if (kqtim != null)
                    {
                        TimXuat(DateTime.Parse(form2.strTim), SoSanhTheoNgaySinh);
                        kq = true;
                    }
                    break;
                default:
                    break;
            }
            if (kq == false)
            {
                MessageBox.Show("Không tìm thấy thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }
        private int SoSanhTheoHoTen(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.HoTen.CompareTo(obj1);
        }
        private int SoSanhTheoNgaySinh(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.NgaySinh.CompareTo(obj1);
        }
        private int SoSanhSapXepTheoMa(object obj1, object obj2)
        {
            SinhVien sv1 = obj1 as SinhVien;
            SinhVien sv2 = obj2 as SinhVien;
            return sv1.MaSo.CompareTo(sv2.MaSo);
        }
        private int SoSanhSapXepTheoTen(object obj1, object obj2)
        {
            SinhVien sv1 = obj1 as SinhVien;
            SinhVien sv2 = obj2 as SinhVien;
            return sv1.HoTen.CompareTo(sv2.HoTen);
        }
        private int SoSanhSapXepTheoNgaySinh(object obj1, object obj2)
        {
            SinhVien sv1 = obj1 as SinhVien;
            SinhVien sv2 = obj2 as SinhVien;
            return sv1.NgaySinh.CompareTo(sv2.NgaySinh);
        }
        private void TimXuat(object obj1, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                if (ss(obj1, sv) == 0)
                {
                    svresult = sv;
                    MessageBox.Show(svresult.ToString());
                }
            }
        }
        private void sortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTiemKiem_SapXep form2 = new FormTiemKiem_SapXep(true);
            form2.ShowDialog();
            if (qlsv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormTiemKiem_SapXep.Kieu kieutim = new FormTiemKiem_SapXep.Kieu();
            kieutim = form2.kieu;
            switch (kieutim)
            {
                case FormTiemKiem_SapXep.Kieu.TheoMa:
                    qlsv.SapXep(SoSanhSapXepTheoMa);
                    break;
                case FormTiemKiem_SapXep.Kieu.TheoTen:
                    qlsv.SapXep(SoSanhSapXepTheoTen);
                    break;
                case FormTiemKiem_SapXep.Kieu.TheoNgaySinh:
                    qlsv.SapXep(SoSanhSapXepTheoNgaySinh);
                    break;
                default:
                    break;
            }
            LoadListView();
        }
    }
}
