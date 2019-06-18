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

namespace ontaplab2_semifinal
{
    public partial class FormTTGV : Form
    {
        QuanLyGiaoVien qlgv = new QuanLyGiaoVien();
        public delegate int SoSanh(object obj1, object obj2);
        public FormTTGV()
        {
            InitializeComponent();
        }
        private void buttonsua_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linkLabellienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        private void FormTTGV_Load(object sender, EventArgs e)
        {
            this.comboBoxmaSo.SelectedItem = this.comboBoxmaSo.Items[0];
            string lienhe = "http://it.dlu.edu.vn";
            this.linkLabellienHe.Links.Add(0, lienhe.Length, lienhe);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int i = this.listBoxdsmh.SelectedItems.Count - 1;
            while(i>=0)
            {
                this.listBoxmhgvd.Items.Add(listBoxdsmh.SelectedItems[i]);
                this.listBoxdsmh.Items.Remove(listBoxdsmh.SelectedItems[i]);
                i--;
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int i = this.listBoxmhgvd.SelectedItems.Count - 1;
            while(i>=0)
            {
                this.listBoxdsmh.Items.Add(listBoxmhgvd.SelectedItems[i]);
                this.listBoxmhgvd.Items.Remove(listBoxmhgvd.SelectedItems[i]);
                i--;
            }
        }
        private void buttoncancel_Click(object sender, EventArgs e)
        {
            ReSet();
        }
        private void ReSet()
        {
            this.comboBoxmaSo.SelectedItem = this.comboBoxmaSo.Items[0];
            this.textBoxten.Text = "";
            this.radioButtonnam.Checked = true;
            this.dateTimePickerngaySinh.Value = DateTime.Now;
            this.maskedTextBoxsoDT.Text = "";
            this.textBoxmail.Text = "";
            for (int i = 0; i < checkedListBoxngoaiNgu.Items.Count; i++)
                this.checkedListBoxngoaiNgu.SetItemChecked(i, false);
            foreach (object item in this.listBoxmhgvd.Items)
            {
                this.listBoxdsmh.Items.Add(item);
            }
            this.listBoxmhgvd.Items.Clear();
        }       
        public TTGV GetTTGV()
        {
            TTGV gv = new TTGV();
            gv.Hoten = this.textBoxten.Text;
            gv.Maso = this.comboBoxmaSo.Text;
            gv.Ngaysinh = this.dateTimePickerngaySinh.Value;
            string gt = "Nam";
            if (this.radioButtonnu.Checked)
                gt = "Nữ";
            gv.Gioitinh = gt;
            gv.SoDT = this.maskedTextBoxsoDT.Text;
            gv.Mail = this.textBoxmail.Text;
            DanhSachNgoaiNgu dsnn = new DanhSachNgoaiNgu();
            for (int i = 0; i < checkedListBoxngoaiNgu.Items.Count; i++)
                if (checkedListBoxngoaiNgu.GetItemChecked(i))
                    dsnn.Add(new NgoaiNgu(checkedListBoxngoaiNgu.Items[i].ToString()));
            DanhSachMonHoc dsmh = new DanhSachMonHoc();
            foreach (object mh in listBoxmhgvd.Items)
            {
                dsmh.Add(new MonHoc(mh.ToString()));
            }
            gv.Danhsachmonhoc = dsmh;
            gv.Danhsachngoaingu = dsnn;
            return gv;
        }
        private void buttonluu_Click(object sender, EventArgs e)
        {
            string s = GetTTGV().ToString();
            MessageBox.Show(s,"Thông tin giáo viên");
        }
        public void TimXuat(object obj1,SoSanh ss)
        {
            TTGV gvresult = null;
            foreach(TTGV gv in qlgv.dsgiaovien)
            {
                if (ss(obj1, gv) == 0)
                {
                    gvresult = gv;
                    MessageBox.Show(gvresult.ToString());
                }
            }

        }
        private void buttontim_Click(object sender, EventArgs e)
        {
            if (qlgv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormTimKiem frmsearch = new FormTimKiem();
            frmsearch.Show();
            FormTimKiem.KieuTim kieutim = new FormTimKiem.KieuTim();
            kieutim = frmsearch.kieutim;
            switch (kieutim)
            {
                case FormTimKiem.KieuTim.TheoMaSo:

                    break;
                case FormTimKiem.KieuTim.TheoTen:
                    break;
                case FormTimKiem.KieuTim.TheoSoDT:
                    break;
                default:
                    break;
            }

        }
        private void buttonthem_Click(object sender, EventArgs e)
        {

            TTGV gv = new TTGV();
            gv = GetTTGV();
            TTGV kq = qlgv.KiemTra(gv.Maso, SoSanhTheoMa);
            if(kq!=null)
            {
                MessageBox.Show("Mã giáo viên đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công!");
                qlgv.Add(gv);
                ReSet();
            }
        }
        private int SoSanhTheoMa(object obj1,object obj2)
        {
            TTGV gv = obj2 as TTGV;
            return gv.Maso.CompareTo(obj1);
        }
        private int SoSanhTheoTen(object obj1, object obj2)
        {
            TTGV gv = obj2 as TTGV;
            return gv.Hoten.CompareTo(obj1);
        }
        private int SoSanhTheoSoDT(object obj1,object obj2)
        {
            TTGV gv = obj2 as TTGV;
            return gv.SoDT.CompareTo(obj1);
        }
        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (qlgv.KiemTraRong())
            {
                MessageBox.Show("Danh sách rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (qlgv.Xoa(this.comboBoxmaSo.Text))
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Mã số không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
