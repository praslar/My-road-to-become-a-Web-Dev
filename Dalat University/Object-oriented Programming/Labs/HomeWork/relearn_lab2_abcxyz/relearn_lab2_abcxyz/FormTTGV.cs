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

namespace relearn_lab2_abcxyz
{
    public partial class FormTTGV : Form
    {
        public delegate int SoSanh(object obj1, object obj2);
        public QuanLyGiaoVien qlgv = new QuanLyGiaoVien();
        //=================================================================
        public FormTTGV()
        {
            InitializeComponent();
        }
        private void FormTTGV_Load(object sender, EventArgs e)
        {
            this.comboBoxmaSo.SelectedItem = comboBoxmaSo.Items[0];
            string lienhe = "http://www.google.com";
            this.linkLabel1.Links.Add(0, lienhe.Length, lienhe);
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        public void Reset()
        {
            this.comboBoxmaSo.SelectedItem = comboBoxmaSo.Items[0];
            this.textBoxhoTen.Text = "";
            this.dateTimePickerngaySinh.Value = DateTime.Now;
            this.radioButtonnam.Checked = true;
            this.maskedTextBoxsoDT.Text = "";
            this.textBoxmail.Text = "";
            for (int i = 0; i < this.checkedListBoxngoaiNgu.Items.Count; i++)
                this.checkedListBoxngoaiNgu.SetItemChecked(i, false);
            foreach (object item in this.listBoxmhgvd.Items)
                this.listBoxdsmh.Items.Add(item);
            this.listBoxmhgvd.Items.Clear();
        }
        private void buttonselect_Click(object sender, EventArgs e)
        {
            int i = this.listBoxdsmh.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.listBoxmhgvd.Items.Add(listBoxdsmh.SelectedItems[i]);
                this.listBoxdsmh.Items.Remove(listBoxdsmh.SelectedItems[i]);
                i--;
            }
        }
        private void buttonunselect_Click(object sender, EventArgs e)
        {
            int i = this.listBoxmhgvd.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.listBoxdsmh.Items.Add(listBoxmhgvd.SelectedItems[i]);
                this.listBoxmhgvd.Items.Remove(listBoxmhgvd.SelectedItems[i]);
                i--;
            }
        }
        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public GiaoVien GetGiaoVien()
        {
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.comboBoxmaSo.Text;
            gv.HoTen = this.textBoxhoTen.Text;
            gv.NgaySinh = this.dateTimePickerngaySinh.Value;
            string gt = "Nam";
            if (this.radioButtonnu.Checked == true)
                gt = "Nữ";
            gv.GioiTinh = gt;
            gv.SoDT = this.maskedTextBoxsoDT.Text;
            gv.Mail = this.textBoxmail.Text;
            DanhSachMonHoc dsmh = new DanhSachMonHoc();
            foreach (object item in this.listBoxmhgvd.Items)
                dsmh.Add(new MonHoc(item.ToString()));
            gv.dsmh = dsmh;
            DanhSachNgoaiNgu dsnn = new DanhSachNgoaiNgu();
            for (int i = 0; i < this.checkedListBoxngoaiNgu.Items.Count; i++)
                if (this.checkedListBoxngoaiNgu.GetItemChecked(i))
                    dsnn.Add(new NgoaiNgu(checkedListBoxngoaiNgu.Items[i].ToString()));
            gv.dsnn = dsnn;
            return gv;
        }
        private void buttonsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetGiaoVien().ToString());
        }
        //=====================================================================================
        private void KiemTraXuat(object obj1,SoSanh ss)
        {
            GiaoVien gvresult = null;
            foreach (GiaoVien gv in qlgv.dsgv)
            {
                if (ss(obj1,gv)==0)
                {
                    MessageBox.Show(gv.ToString());
                }
            }
        }
        private void buttonadd_Click(object sender, EventArgs e)
        {
            GiaoVien gv = GetGiaoVien();
            GiaoVien kq = qlgv.KiemTra(gv.MaSo, SoSanhTheoMa);
            if (kq!=null)
            {
                MessageBox.Show("Mã giáo viên đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công!");
                qlgv.Add(gv);
                Reset();
            }
        }
        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (qlgv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (qlgv.Xoa(this.comboBoxmaSo.Text))
            {
                MessageBox.Show("Xóa thành công");
                Reset();
            }
            else
            {
                MessageBox.Show("Mã không tồn tại trong danh sách!");
                return;
;            }
        }
        private void buttonsearch_Click(object sender, EventArgs e)
        {
            if (qlgv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormTimGV frm = new FormTimGV();
            frm.ShowDialog();
            FormTimGV.TimKiem KieuTim = new FormTimGV.TimKiem();
            KieuTim = frm.Ktim;
            bool kq = false;
            GiaoVien kqtim;
            switch (KieuTim)
            {
                case FormTimGV.TimKiem.TheoMaSo:
                    kqtim = qlgv.KiemTra(frm.strtim, SoSanhTheoMa);
                    if (kqtim!=null)
                    {
                        MessageBox.Show(kqtim.ToString());
                        kq = true;
                    }
                    break;
                case FormTimGV.TimKiem.TheoHoTen:
                    kqtim = qlgv.KiemTra(frm.strtim, SoSanhTheoTen);
                    if (kqtim != null)
                    {
                        KiemTraXuat(frm.strtim, SoSanhTheoTen);
                        kq = true;
                    }
                    break;
                case FormTimGV.TimKiem.TheoSoDT:
                    kqtim = qlgv.KiemTra(frm.strtim, SoSanhTheoSoDT);
                    if (kqtim != null)
                    {
                        KiemTraXuat(frm.strtim, SoSanhTheoSoDT);
                        kq = true;
                    }
                    break;
                default:
                    break;
            }
            if (!kq)
            {
                MessageBox.Show("Không tìm thấy thông tin giáo viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public int SoSanhTheoMa(object obj1,object obj2)
        {
            GiaoVien gv = obj2 as GiaoVien;
            return gv.MaSo.CompareTo(obj1);
        }
        public int SoSanhTheoTen(object obj1, object obj2)
        {
            GiaoVien gv = obj2 as GiaoVien;
            return gv.HoTen.CompareTo(obj1);
        }
        public int SoSanhTheoSoDT(object obj1, object obj2)
        {
            GiaoVien gv = obj2 as GiaoVien;
            return gv.SoDT.CompareTo(obj1);
        }
    }
}
