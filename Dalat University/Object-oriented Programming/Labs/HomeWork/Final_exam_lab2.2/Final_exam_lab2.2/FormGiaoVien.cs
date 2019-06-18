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

namespace Final_exam_lab2._2
{
    public partial class FormGiaoVien : Form
    {
        public delegate int SoSanh(object obj1, object obj2);
        QuanLyGiaoVien qlgv = new QuanLyGiaoVien();
        public FormGiaoVien()
        {
            InitializeComponent();
        }
        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            this.comboBoxmaSo.SelectedItem = comboBoxmaSo.Items[0];
            string s = "http://www.google.com";
            this.linkLabel1.Links.Add(0,s.Length,s);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        private void Reset()
        {
            this.comboBoxmaSo.Text = "";
            this.textBoxhoTen.Text = "";
            this.dateTimePickerngaySinh.Value = DateTime.Now;
            this.radioButtonnam.Checked = true;
            this.maskedTextBox1.Text = "";
            this.textBoxmail.Text = "";
            for (int i = 0; i < this.checkedListBoxngoaiNgu.Items.Count; i++)
                this.checkedListBoxngoaiNgu.SetItemChecked(i, false);
            foreach (var item in this.listBoxmhgvd.Items)
                this.listBoxdsmh.Items.Add(item);
            this.listBoxmhgvd.Items.Clear();
        }
        private void buttonselect_Click(object sender, EventArgs e)
        {
            int i = this.listBoxdsmh.SelectedItems.Count-1;
            while (i>=0)
            {
                this.listBoxmhgvd.Items.Add(listBoxdsmh.SelectedItems[i]);
                this.listBoxdsmh.Items.Remove(listBoxdsmh.SelectedItems[i]);
                i--;
            }
        }
        private void buttonremove_Click(object sender, EventArgs e)
        {
            int i = this.listBoxmhgvd.SelectedItems.Count-1;
            while (i >= 0)
            {
                this.listBoxdsmh.Items.Add(listBoxmhgvd.SelectedItems[i]);
                this.listBoxmhgvd.Items.Remove(listBoxmhgvd.SelectedItems[i]);
                i--;
            }
        }
        public GiaoVien GetGiaoVien()
        {
            string gt = "Nữ";
            if (this.radioButtonnam.Checked == true)
                gt = "Nam";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.comboBoxmaSo.Text;
            gv.HoTen = this.textBoxhoTen.Text;
            gv.NgaySinh = this.dateTimePickerngaySinh.Value;
           
            gv.GioiTinh = gt;
            gv.SoDT = this.maskedTextBox1.Text;
            gv.Mail = this.textBoxmail.Text;
            string nn = "";
            for (int i = 0; i < this.checkedListBoxngoaiNgu.Items.Count; i++)
                if (this.checkedListBoxngoaiNgu.GetItemChecked(i))
                    nn += checkedListBoxngoaiNgu.Items[i] + ";";
            gv.NgoaiNgu = nn.Split(';');
            DanhSachMonHoc mh = new DanhSachMonHoc();
            foreach (var item in this.listBoxmhgvd.Items)
              mh.dsmh.Add(new MonHoc(item.ToString()));
            gv.dsmh = mh;
            return gv;
        }
        private void buttonluu_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv = GetGiaoVien();
            MessageBox.Show(gv.ToString());
        }
        private void buttonthem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv = GetGiaoVien();
            GiaoVien kq = qlgv.KiemTra(gv.MaSo,SoSanhTheoMa);
            if (kq!=null)
            {
                MessageBox.Show("Mã giáo viên đã tồn tại","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công!");
                qlgv.Them(gv);
                Reset();
            }
        }
        public int SoSanhTheoMa(object obj1,object obj2)
        {
            GiaoVien gv = obj2 as GiaoVien;
            return gv.MaSo.CompareTo(obj1);
        }
        public int SoSanhTheoTen(object obj1,object obj2)
        {
            GiaoVien gv = obj2 as GiaoVien;
            return gv.HoTen.CompareTo(obj1);
        }
        public int SoSanhTheoSDT(object obj1,object obj2)
        {
            GiaoVien gv = obj2 as GiaoVien;
            return gv.SoDT.CompareTo(obj1);
        }
        public void TimXuat(object obj1,SoSanh ss)
        {
            foreach (GiaoVien gv in qlgv.dsgv)
            {
                if (ss(obj1,gv)==0)
                {
                    MessageBox.Show(gv.ToString());
                }
            }

        }
        private void buttontim_Click(object sender, EventArgs e)
        {
            if (qlgv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GiaoVien kqtim;
            bool kq = false;
            FormTimKiem frmTim = new FormTimKiem();
            frmTim.ShowDialog();
            FormTimKiem.KieuTim ktim = new FormTimKiem.KieuTim();
            ktim = frmTim.kTim;
            switch (ktim)
            {
                case FormTimKiem.KieuTim.TheoTen:
                    kqtim = qlgv.KiemTra(frmTim.strTim, SoSanhTheoTen);
                    if (kqtim!=null)
                    {
                        TimXuat(frmTim.strTim, SoSanhTheoTen);
                        kq = true;
                    }
                    break;
                case FormTimKiem.KieuTim.TheoMaSo:
                    kqtim = qlgv.KiemTra(frmTim.strTim, SoSanhTheoMa);
                    if(kqtim!=null)
                    {
                        MessageBox.Show(kqtim.ToString());
                        kq = true;
                    }
                    break;
                case FormTimKiem.KieuTim.TheoSDT:
                    kqtim = qlgv.KiemTra(frmTim.strTim, SoSanhTheoSDT);
                    if (kqtim != null)
                    {
                        TimXuat(frmTim.strTim, SoSanhTheoSDT);
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (qlgv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (qlgv.Xoa(this.comboBoxmaSo.Text))
                MessageBox.Show("Xóa thành công!");
            else
            { 
                MessageBox.Show("Thành viên không tồn tại.");
                return;
            }
        }
    }
}
