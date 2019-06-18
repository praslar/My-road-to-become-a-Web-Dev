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

namespace Lab2_Ontap
{
    public partial class FormGiaoVien : Form
    {
        public delegate int SoSanh(object a, object b);
        public QuanLyGiaoVien qlgv = new QuanLyGiaoVien();
        GiaoVien gv = new GiaoVien();
        public FormGiaoVien()
        {
            InitializeComponent();
        }
        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            this.linkLabel1.Links.Add(0, lienhe.Length, lienhe);
            this.comboBoxmaSo.SelectedItem = this.comboBoxmaSo.Items[0];
        }
        private void buttonChon_Click(object sender, EventArgs e)
        {
            int i = this.listBoxDSMH.SelectedItems.Count - 1;
            while(i >= 0)
            {
                this.listBoxMHGV.Items.Add(listBoxDSMH.SelectedItems[i]);
                this.listBoxDSMH.Items.Remove(listBoxDSMH.SelectedItems[i]);
                i--;
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int i = this.listBoxMHGV.SelectedItems.Count - 1;
            while(i >=0)
            {
                this.listBoxDSMH.Items.Add(listBoxMHGV.SelectedItems[i]);
                this.listBoxMHGV.Items.Remove(listBoxMHGV.SelectedItems[i]);
                i--;
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Reset()
        {
            this.comboBoxmaSo.Text = "";
            this.textBoxhoTen.Text = "";
            this.radioButtonnam.Checked = true;
            this.maskedTextBoxsoDT.Text = "";
            this.textBoxMail.Text = "";
            this.dateTimePickerngaySinh.Text = "";
            for (int i = 0; i < checkedListBoxngoaiNgu.Items.Count; i++)
                checkedListBoxngoaiNgu.SetItemChecked(i, false);
            foreach (object ob in this.listBoxMHGV.Items)
                this.listBoxDSMH.Items.Add(ob);
            this.listBoxMHGV.Items.Clear();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.comboBoxmaSo.Text == "")
            {
                MessageBox.Show("Chưa nhập MSSV", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.radioButtonnam.Checked == false && this.radioButtonNu.Checked == false)
            {
                MessageBox.Show("Chưa chọn giới tính", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.textBoxhoTen.Text == "")
            {
                MessageBox.Show("Chưa nhập tên", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((this.maskedTextBoxsoDT.Text).CompareTo("(02633).  .  .") == 0)
            {
                MessageBox.Show("Chưa nhập SDT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.textBoxMail.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ mail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.checkedListBoxngoaiNgu.CheckedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn ngoại ngữ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.listBoxDSMH.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn môn giảng dạy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormTBGiaoVien form = new FormTBGiaoVien();
            form.SetText(GetGiaoVien().ToString());
            form.ShowDialog();
        }
        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (radioButtonNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.comboBoxmaSo.Text;
            gv.HoTen = this.textBoxhoTen.Text;
            gv.GioiTinh = gt;
            gv.NgaySinh = this.dateTimePickerngaySinh.Value;
            gv.Mail = this.textBoxMail.Text;
            gv.SoDT = this.maskedTextBoxsoDT.Text;
            DanhMucNgoaiNgu nn = new DanhMucNgoaiNgu();
            for (int i = 0; i < checkedListBoxngoaiNgu.Items.Count; i++)
                if (checkedListBoxngoaiNgu.GetItemChecked(i))
                    nn.Them(new NgoaiNgu(checkedListBoxngoaiNgu.Items[i].ToString()));
            gv.dsNgoaiNgu = nn;
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in listBoxMHGV.Items)
                mh.Them(new MonHoc(ob.ToString()));
            gv.dsMonHoc = mh;
            return gv;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (this.comboBoxmaSo.Text == "")
            {
                MessageBox.Show("Chưa nhập MSSV", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.radioButtonnam.Checked == false && this.radioButtonNu.Checked == false)
            {
                MessageBox.Show("Chưa chọn giới tính", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.textBoxhoTen.Text == "")
            {
                MessageBox.Show("Chưa nhập tên", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((this.maskedTextBoxsoDT.Text).CompareTo("(02633).  .  .") == 0)
            {
                MessageBox.Show("Chưa nhập SDT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.textBoxMail.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ mail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.checkedListBoxngoaiNgu.CheckedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn ngoại ngữ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.listBoxMHGV.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn môn giảng dạy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //=========================================
            string gt = "Nam";
            if (radioButtonNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.comboBoxmaSo.Text;
            gv.HoTen = this.textBoxhoTen.Text;
            gv.GioiTinh = gt;
            gv.NgaySinh = this.dateTimePickerngaySinh.Value;
            gv.Mail = this.textBoxMail.Text;
            gv.SoDT = this.maskedTextBoxsoDT.Text;
            DanhMucNgoaiNgu nn = new DanhMucNgoaiNgu();
            for (int i = 0; i < checkedListBoxngoaiNgu.Items.Count; i++)
                if (checkedListBoxngoaiNgu.GetItemChecked(i))
                    nn.Them(new NgoaiNgu(checkedListBoxngoaiNgu.Items[i].ToString()));
            gv.dsNgoaiNgu = nn;
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in listBoxMHGV.Items)
                mh.Them(new MonHoc(ob.ToString()));
            gv.dsMonHoc = mh;
            //=========================================================
            GiaoVien kq = qlgv.Tim(gv.MaSo, SoSanhTheoMa);   
            if (kq!=null)
            {
                MessageBox.Show("Lỗi giáo viên đã tồn tại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công");
                this.qlgv.Them(gv);
                Reset();
            }

        }
        public void TimXuat(object obj, SoSanh ss)
        {
            GiaoVien gvresult = null;
            foreach (GiaoVien gv in qlgv.dsGiaoVien)
            {
                if (ss(obj, gv) == 0)
                {
                    gvresult = gv;
                    MessageBox.Show(gvresult.ToString());
                }
            }
            
        }
        private void buttonTim_Click(object sender, EventArgs e)
        {
            GiaoVien kqtim;
            bool kq = false;
            int i;
            if (this.qlgv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TimTTGiaoVien formTim = new TimTTGiaoVien();
            formTim.ShowDialog();
            TimTTGiaoVien.KieuTim kieutiem = new TimTTGiaoVien.KieuTim();
            kieutiem = formTim.KTim;
            //==========================================================
            switch (kieutiem)
            {

                case TimTTGiaoVien.KieuTim.TheoMa:
                    kqtim = qlgv.Tim(formTim.strTim, SoSanhTheoMa);
                    if (kqtim != null)
                    {
                        MessageBox.Show(kqtim.ToString());
                        kq = true;
                    }
                    break;
                case TimTTGiaoVien.KieuTim.TheoHoTen:
                    kqtim = qlgv.Tim(formTim.strTim, SoSanhTheoHoTen);
                    if (kqtim != null)
                    {
                        TimXuat(formTim.strTim, SoSanhTheoHoTen);
                        kq = true;
                    }
                    break;
                case TimTTGiaoVien.KieuTim.TheoSDT:
                    kqtim = qlgv.Tim(formTim.strTim, SoSanhTheoSDT);
                    if (kqtim != null)
                    {
                        TimXuat(formTim.strTim, SoSanhTheoSDT);
                        kq = true;
                    }
                    break;
                default:
                    break;
            }
            if (kq == false)
                MessageBox.Show("Không tìm thấy thông tin", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.qlgv.Xoa(this.comboBoxmaSo.Text) == true)
            {
                MessageBox.Show("Xóa thành công", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Lỗi xóa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
