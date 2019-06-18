using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_Relearn
{
    public partial class FormTTSV : Form
    {
        public delegate int SoSanh(object obj1, object obj2);
        QuanLySinhVien qlsv;
        public FormTTSV()
        {
            InitializeComponent();
        }
        public SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.maskedTextBoxmaSo.Text;
            sv.HoTen = this.textBoxhoTen.Text;
            sv.NgaySinh = this.dateTimePickerngaySinh.Value;
            sv.DiaChi = this.textBoxdiaChi.Text;
            sv.Lop = this.comboBoxlop.Text;
            sv.Hinh = this.textBoxdiaChiHinh.Text;
            if (radioButtonnu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                if (this.checkedListBoxchuyenNganh.GetItemChecked(i))
                    cn.Add(checkedListBoxchuyenNganh.Items[i].ToString());
            sv.ChuyenNganh = cn;
            return sv;
        }
        public SinhVien GetSinhVienListView(ListViewItem listviewitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = listviewitem.SubItems[0].Text;
            sv.HoTen = listviewitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(listviewitem.SubItems[2].Text);
            sv.DiaChi = listviewitem.SubItems[3].Text;
            sv.Lop = listviewitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (listviewitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;
            List<string> cn = new List<string>();
            string[] s = listviewitem.SubItems[6].Text.Split(',');
            foreach (string chuyennganh in s)
                cn.Add(chuyennganh);
            sv.ChuyenNganh = cn;
            sv.Hinh = listviewitem.SubItems[7].Text;
            return sv;
        }
        public void ThietLapThongTin(SinhVien sv)
        {
            this.maskedTextBoxmaSo.Text = sv.MaSo;
            this.textBoxhoTen.Text = sv.HoTen;
            this.dateTimePickerngaySinh.Value = sv.NgaySinh;
            this.textBoxdiaChi.Text = sv.DiaChi;
            this.comboBoxlop.Text = sv.Lop;
            this.textBoxdiaChiHinh.Text = sv.Hinh;
            this.pictureBoxsv.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.radioButtonnam.Checked = true;
            else
                this.radioButtonnu.Checked = true;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                this.checkedListBoxchuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                    if (s.CompareTo(checkedListBoxchuyenNganh.Items[i]) == 0)
                        this.checkedListBoxchuyenNganh.SetItemChecked(i, true);
            }

        }
        public void ThemSinhVienListView(SinhVien sv)
        {
            ListViewItem viewitem = new ListViewItem(sv.MaSo);
            
            viewitem.SubItems.Add(sv.HoTen);
            viewitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            viewitem.SubItems.Add(sv.DiaChi);
            viewitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            viewitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            cn = cn.Substring(0, cn.Length - 1);
            viewitem.SubItems.Add(cn);
            viewitem.SubItems.Add(sv.Hinh);
            this.listViewdssv.Items.Add(viewitem);

        }
        public void LoadListView()
        {
            this.listViewdssv.Items.Clear();
            foreach (SinhVien sv in qlsv.dssv)
            {
                ThemSinhVienListView(sv);
            }
        }
        public int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }
//=================================================================================
        private void listViewdssv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = this.listViewdssv.SelectedItems.Count;
            if (i>0)
            {
                ListViewItem viewitem = this.listViewdssv.SelectedItems[0];
                SinhVien sv = GetSinhVienListView(viewitem);
                ThietLapThongTin(sv);
            }
        }
        private void buttonthem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.KiemTra(sv.MaSo, SoSanhTheoMa);
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!");
            else
            {
                this.qlsv.Them(sv);
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
            count = this.listViewdssv.Items.Count-1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.listViewdssv.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.buttonmacdinh.PerformClick();
        }
        private void buttonmacdinh_Click(object sender, EventArgs e)
        {
            this.maskedTextBoxmaSo.Text = "";
            this.textBoxhoTen.Text = "";
            this.dateTimePickerngaySinh.Value = DateTime.Now;
            this.textBoxdiaChi.Text = "";
            this.comboBoxlop.Text = this.comboBoxlop.Items[0].ToString();
            this.textBoxdiaChiHinh.Text = "";
            this.pictureBoxsv.ImageLocation = "";
            this.radioButtonnam.Checked = true;
            for (int i = 0; i < this.checkedListBoxchuyenNganh.Items.Count; i++)
                this.checkedListBoxchuyenNganh.SetItemChecked(i, false);
        }
        private void buttonsua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
                this.LoadListView();
        }
        private void FormTTSV_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.ReadFile();
            LoadListView();
        }
    }
}
