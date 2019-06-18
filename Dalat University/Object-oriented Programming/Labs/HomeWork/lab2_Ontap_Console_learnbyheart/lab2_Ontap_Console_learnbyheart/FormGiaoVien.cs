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

namespace lab2_Ontap_Console_learnbyheart
{
    public partial class FormGiaoVien : Form
    {
        public delegate int SoSanh(object a, object b);
        public QuanLyGiaoVien qlgv = new QuanLyGiaoVien();
        public GiaoVien gv = new GiaoVien();
        //=======================================================================================
        public FormGiaoVien()
        {
            InitializeComponent();
        }
        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "http://dlu.edu.vn";
            this.linkLabellienHe.Links.Add(0, lienhe.Length, lienhe);
            this.comboBoxmaSo.SelectedItem = this.comboBoxmaSo.Items[0];
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linkLabellienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            this.comboBoxmaSo.SelectedItem = comboBoxmaSo.Items[0];
            this.textBoxhoTen.Text = "";
            this.dateTimePicker1.Text = DateTime.Now.ToShortTimeString();
            this.radioButtonNam.Checked=true;
            this.maskedTextBoxSDT.Text = "";
            this.textBoxMail.Text = "";
            for (int i = 0; i < checkedListBoxngoaiNgu.Items.Count; i++)
            {
                checkedListBoxngoaiNgu.SetItemChecked(i, false);
            }
            foreach (object ob in this.listBoxMHGVD.Items)
                this.listBoxDSMH.Items.Add(ob);
            this.listBoxMHGVD.Items.Clear();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            FormTTGV formThongBao = new FormTTGV();
            formThongBao.SetText(GetGiaoVien().ToString());
            formThongBao.ShowDialog();
        }
        public GiaoVien GetGiaoVien()
        {
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.comboBoxmaSo.Text;
            gv.HoTen = this.textBoxhoTen.Text;
            gv.NgaySinh = this.dateTimePicker1.Value;
            string gt = "Nam";
            if (radioButtonNu.Checked)
                gt = "Nữ";
            gv.GioiTinh = gt;
            gv.SoDT = this.maskedTextBoxSDT.Text;
            gv.Mail = this.textBoxMail.Text;
            DanhSachNgoaiNgu ngoaingu = new DanhSachNgoaiNgu();
            for (int i = 0; i < checkedListBoxngoaiNgu.Items.Count; i++)
            {
                if (checkedListBoxngoaiNgu.GetItemChecked(i))
                    ngoaingu.Them(new NgoaiNgu(checkedListBoxngoaiNgu.Items[i].ToString()));
            }
            gv.DSNgoaiNgu = ngoaingu;
            DanhSachMonHoc monhoc = new DanhSachMonHoc();
            foreach (object mh in this.listBoxMHGVD.Items)
                monhoc.Them(new MonHoc(mh.ToString()));
            gv.DSMonHoc = monhoc;
            return gv;
        }
        private void buttonChon_Click(object sender, EventArgs e)
        {
            int i = this.listBoxDSMH.SelectedItems.Count - 1;
            while(i>=0)
            {
                this.listBoxMHGVD.Items.Add(listBoxDSMH.SelectedItems[i]);
                this.listBoxDSMH.Items.Remove(listBoxDSMH.SelectedItems[i]);
                i--;
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int i = listBoxMHGVD.SelectedItems.Count - 1;
            while(i>=0)
            {
                this.listBoxDSMH.Items.Add(listBoxMHGVD.SelectedItems[i]);
                this.listBoxMHGVD.Items.Remove(listBoxMHGVD.SelectedItems[i]);
                i--;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv = GetGiaoVien();
            GiaoVien kq = qlgv.KiemTra(gv.MaSo, SoSanhTheoMa);
            if(kq!=null)
            {
                MessageBox.Show("Mã giáo viên đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công");
                this.qlgv.Them(gv);
                Reset();
            }
        }
        private int SoSanhTheoMa(object obj1,object obj2)
        {
            GiaoVien gv = obj2 as GiaoVien;
            return gv.MaSo.CompareTo(obj1);
        }
        private int SoSanhTheoHoTen(object obj1,object obj2)
        {
            GiaoVien gv = obj2 as GiaoVien;
            return gv.HoTen.CompareTo(obj1);
        }
        private int SoSanhTheoSDT(object obj1,object obj2)
        {
            GiaoVien gv = obj2 as GiaoVien;
            return gv.SoDT.CompareTo(obj1);
        }
        private void TimXuat(object obj, SoSanh ss)
        {
            GiaoVien gvresult = null; 
            foreach (GiaoVien gv in qlgv.DSGiaoVien)
            {
                if (ss(obj, gv) == 0)
                {
                    gvresult = gv;
                    MessageBox.Show(gvresult.ToString());
                }
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.qlgv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.qlgv.Xoa(this.comboBoxmaSo.Text))
            {
                MessageBox.Show("Xóa thành công","Success",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thành viên không tồn tại trong danh sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (this.qlgv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GiaoVien kqtim;
            bool kq = false;
            FormTimGV formtimGV = new FormTimGV();
            formtimGV.ShowDialog();
            FormTimGV.KieuTim kieutim = new FormTimGV.KieuTim();
            kieutim = formtimGV.kTim;
            switch (kieutim)
            {
                case FormTimGV.KieuTim.TheoMa:
                    kqtim = qlgv.KiemTra(formtimGV.strTim, SoSanhTheoMa);
                    if (kqtim!=null)
                    {
                        kqtim = qlgv.KiemTra(formtimGV.strTim, SoSanhTheoMa);
                        MessageBox.Show(kqtim.ToString());
                        kq = true;
                    }
                    break;
                case FormTimGV.KieuTim.TheoHoTen:
                    kqtim = qlgv.KiemTra(formtimGV.strTim, SoSanhTheoHoTen);
                    if(kqtim!=null)
                    {
                        TimXuat(formtimGV.strTim, SoSanhTheoHoTen);
                        kq = true;
                    }
                    break;
                case FormTimGV.KieuTim.TheoSDT:
                    kqtim = qlgv.KiemTra(formtimGV.strTim, SoSanhTheoSDT);
                    if(kqtim!=null)
                    {
                        TimXuat(formtimGV.strTim, SoSanhTheoSDT);
                        kq = true;
                    }
                    break;
                default:
                    break;
            }
            if (kq==false)
            {
                MessageBox.Show("Không tìm thấy thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
