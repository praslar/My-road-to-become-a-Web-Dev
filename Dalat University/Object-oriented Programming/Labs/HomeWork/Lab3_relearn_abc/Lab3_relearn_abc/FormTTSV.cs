using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_relearn_abc
{
    public partial class FormTTSV : Form
    {
        public QuanLySinhVien qlsv;
        public delegate int SoSanh(object obj1, object obj2);
        public FormTTSV()
        {
            InitializeComponent();
        }
        //======================================================================
        public SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = this.maskedTextBoxmaSo.Text;
            sv.HoTen = this.textBoxhoTen.Text;
            sv.NgaySinh = this.dateTimePickerngaySinh.Value;
            sv.DiaChi = this.textBoxdiaChi.Text;
            sv.Hinh = this.textBoxdiaChiHinh.Text;
            sv.GioiTinh = false;
            if (radioButtonnam.Checked)
                sv.GioiTinh = true;
            List<string> cn = new List<string>();
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                if (this.checkedListBoxchuyenNganh.GetItemChecked(i))
                    cn.Add(this.checkedListBoxchuyenNganh.Items[i].ToString());
            sv.ChuyenNganh = cn;
            sv.Lop = this.comboBoxlop.Text;
            return sv;
        }
        public SinhVien GetSinhVienListView(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;
            string[] cn = lvitem.SubItems[6].Text.Split(',');
            foreach (string chuyennganh in cn)
                sv.ChuyenNganh.Add(chuyennganh);
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
        public void ThietLapThongTin(SinhVien sv)
        {
            this.maskedTextBoxmaSo.Text = sv.MaSo;
            this.textBoxhoTen.Text = sv.HoTen;
            this.dateTimePickerngaySinh.Value = sv.NgaySinh;
            this.textBoxdiaChi.Text = sv.DiaChi;
            this.textBoxdiaChiHinh.Text = sv.Hinh;
            this.pictureBoxsv.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.radioButtonnam.Checked = true;
            else
                this.radioButtonnu.Checked = true;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                this.checkedListBoxchuyenNganh.SetItemChecked(i, false);
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                foreach (string cn in sv.ChuyenNganh)
                    if (cn.CompareTo(this.checkedListBoxchuyenNganh.Items[i]) == 0)
                        this.checkedListBoxchuyenNganh.SetItemChecked(i, true);
            this.comboBoxlop.Text = sv.Lop;

        }
        public void ThemSVListView(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string chuyennganh in sv.ChuyenNganh)
                cn += chuyennganh + ",";
            if(cn.Length >0)
                 cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.listView.Items.Add(lvitem);
        }
        public void LoadListView()
        {
            
            this.listView.Items.Clear();
            foreach (SinhVien sv in qlsv.dssv)
                ThemSVListView(sv);
            int i = this.qlsv.dssv.Count;
            this.toolStripStatusLabel1.Text = "Tổng số sinh viên: " + i;
        }
        public void KiemTraXuat(object obj1,SoSanh ss)
        {
            int i = 0;
            string s = "Số sinh viên tìm thấy trong danh sách: ";
            foreach (SinhVien sv in qlsv.dssv)
            {
                if (ss(obj1, sv) == 0)
                    i++;
            }
            s += i;
            MessageBox.Show(s);
            foreach (SinhVien sv in qlsv.dssv)
            {
                if (ss(obj1, sv) == 0)
                    MessageBox.Show(sv.ToString());
            }
        }
        //======================================================================
        public int SoSanhTheoMa(object obj1,object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }
        public int SoSanhTheoTen(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.HoTen.CompareTo(obj1);
        }
        public int SoSanhTheoNgaySinh(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.NgaySinh.CompareTo(obj1);
        }
        public int SapXepTheoMa(object obj1,object obj2)
        {
            SinhVien sv1 = obj1 as SinhVien;
            SinhVien sv2 = obj2 as SinhVien;
            return sv1.MaSo.CompareTo(sv2.MaSo);
        }
        public int SapXepTheoTen(object obj1, object obj2)
        {
            SinhVien sv1 = obj1 as SinhVien;
            SinhVien sv2 = obj2 as SinhVien;
            return sv1.HoTen.CompareTo(sv2.HoTen);
        }
        public int SapXepTheoNgaySinh(object obj1, object obj2)
        {
            SinhVien sv1 = obj1 as SinhVien;
            SinhVien sv2 = obj2 as SinhVien;
            return sv1.NgaySinh.CompareTo(sv2.NgaySinh);
        }
        //=======================================================================
        private void buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonmacDinh_Click(object sender, EventArgs e)
        {
            this.textBoxhoTen.Text = "";
            this.maskedTextBoxmaSo.Text = "";
            this.dateTimePickerngaySinh.Value = DateTime.Now;
            this.textBoxdiaChi.Text = "";
            this.comboBoxlop.Text = "";
            this.pictureBoxsv.ImageLocation = "";
            this.textBoxdiaChiHinh.Text = "";
            this.radioButtonnam.Checked = true;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                this.checkedListBoxchuyenNganh.SetItemChecked(i, false);

        }
        private void buttonthem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo, SoSanhTheoMa);
            if (kq!=null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công!");
                this.qlsv.dssv.Add(sv);
            }
            this.LoadListView();            
        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = this.listView.SelectedItems.Count ;
            if(i>0)
            {
                ListViewItem lvitem = this.listView.SelectedItems[0];
                SinhVien sv = GetSinhVienListView(lvitem);
                ThietLapThongTin(sv);
            }
        }
        private void buttonxoa_Click(object sender, EventArgs e)
        {
            ListViewItem lvitem;
            for (int i = 0; i < this.listView.Items.Count; i++)

                {
                    lvitem = this.listView.Items[i];
                    if (lvitem.Checked)
                             qlsv.Xoa(this.listView.Items[i].SubItems[0].Text, SoSanhTheoMa);                 
                }
            MessageBox.Show("Xóa thành công!");
            this.LoadListView();
            this.buttonmacDinh.PerformClick();
        }
        private void buttonsua_Click(object sender, EventArgs e)
        {
          
            SinhVien sv = GetSinhVien();
            bool kq = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kq)
            {
                MessageBox.Show("Sửa thành công!");
                this.LoadListView();
            }
            else
                MessageBox.Show("Lỗi mã sinh viên!");
        }
        private void FormTTSV_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.ReadFile();
            LoadListView();
        }
        private void buttondiaChiHinh_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();
            if(dlg == DialogResult.OK)
            {
                this.textBoxdiaChiHinh.Text = this.openFileDialog1.FileName;
                this.pictureBoxsv.ImageLocation = this.openFileDialog1.FileName;
            }
        }
        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.fontDialog1.ShowDialog();
            if(dlg == DialogResult.OK)
            {
                this.listView.Font = this.fontDialog1.Font;
            }
        }
        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.colorDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                this.listView.BackColor = this.colorDialog1.Color;
            }
        }
        private void tìmKiếmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(qlsv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng!");
                return;
            }
            SinhVien kqtim;
            bool kq=false;
            FormTuyChon frm = new FormTuyChon(false);
            frm.ShowDialog();
            FormTuyChon.KieuTuyChon ktc = new FormTuyChon.KieuTuyChon();
            ktc = frm.ktc;
            switch (ktc)
            {
                case FormTuyChon.KieuTuyChon.TheoMa:
                    kqtim = qlsv.Tim(frm.strTim, SoSanhTheoMa);
                    if(kqtim!=null)
                    {
                        MessageBox.Show(kqtim.ToString());
                        kq = true;
                    }
                    break;
                case FormTuyChon.KieuTuyChon.TheoTen:
                    kqtim = qlsv.Tim(frm.strTim, SoSanhTheoTen);
                    if(kqtim!=null)
                    {
                        KiemTraXuat(frm.strTim, SoSanhTheoTen);
                        kq = true;
                    }
                    break;
                case FormTuyChon.KieuTuyChon.TheoNgaySinh:
                    kqtim = qlsv.Tim(DateTime.Parse(frm.strTim), SoSanhTheoNgaySinh);
                    if (kqtim != null)
                    {
                        KiemTraXuat(DateTime.Parse(frm.strTim), SoSanhTheoNgaySinh);
                        kq = true;
                    }
                    break;
                default:
                    break;
            }
            if(!kq)
            {
                MessageBox.Show("Không tìm thấy thông tin");
                return;
            }
        }
        private void sắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (qlsv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng!");
                return;
            }
            FormTuyChon frm = new FormTuyChon(true);
            frm.ShowDialog();
            FormTuyChon.KieuTuyChon ktc = new FormTuyChon.KieuTuyChon();
            ktc = frm.ktc;
            switch (ktc)
            {
                case FormTuyChon.KieuTuyChon.TheoMa:
                    qlsv.SapXep(SapXepTheoMa);
                    break;
                case FormTuyChon.KieuTuyChon.TheoTen:
                    qlsv.SapXep(SapXepTheoTen);
                    break;
                case FormTuyChon.KieuTuyChon.TheoNgaySinh:
                    qlsv.SapXep(SapXepTheoNgaySinh);
                    break;
                default:
                    break;
            }
            this.LoadListView();
        }
    }
}
