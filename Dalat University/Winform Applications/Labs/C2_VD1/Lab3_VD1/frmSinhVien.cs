using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_VD1
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien ql = new QuanLySinhVien();
        char kt = ',';
        public frmSinhVien()
        {
            InitializeComponent();
        }
        private void ThemSV(SinhVien sv)
        {            
            ListViewItem item = new ListViewItem(sv.MaSo);
            item.SubItems.Add(sv.HoTen);
            item.SubItems.Add(sv.NgaySinh.ToShortDateString());
            item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");

            item.SubItems.Add(sv.Hinh);
            string cn = "";
            for (int j = 0; j < sv.ChuyenNganh.Count; j++)
            {
                cn += sv.ChuyenNganh[j] + kt;
            }
            item.SubItems.Add(cn);
            this.listViewSinhVien.Items.Add(item);
        }
        private void LoadDS()
        {
            this.listViewSinhVien.Items.Clear();
            for (int i = 0; i < ql.Count; i++)
            {
                ThemSV(ql[i]);
            }
        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            ql.DocTuFile();
            LoadDS();
            
           
            /*Mạng truyền thông
            Công nghệ phần mềm
            Khoa học máy tính
            Trí tuệ nhân tạo
            Hệ thống thông tin
            Tin học ứng dụng
             */
            /* ListViewItem item = new ListViewItem(new string[] {"SV.01000", "2/3/2000", "Nam", "Sinhvien.png",
             "Mạng truyền thông,Khoa học máy tính"});
             this.listViewSinhVien.Items.Add(item);

             item = new ListViewItem("SV.00001");
             item.SubItems.Add("3/5/1999");
             item.SubItems.Add("Nữ");
             item.SubItems.Add("sinhvien1.png");
             item.SubItems.Add("Khoa học máy tính,Tin học ứng dụng,Trí tuệ nhân tạo");
             this.listViewSinhVien.Items.Add(item);

             this.toolStripStatusLabelDS.Text =
                 "Tong so sinh vien:" + this.listViewSinhVien.Items.Count;

             //this.openFileDialog.Filter = "All file|*.*"+
             //                            "|png File|*.png;*.PNG";
      */

        }

        private void listViewSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlg= this.openFileDialog.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                this.textBoxHinh.Text = this.openFileDialog.FileName;
                this.pictureBoxHinh.ImageLocation = this.openFileDialog.FileName;
            }

        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.colorDialog.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                this.listViewSinhVien.BackColor = this.colorDialog.Color;
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.fontDialog.ShowDialog();
            if (dlg == DialogResult.OK)
            {

                this.listViewSinhVien.Font =
                    this.fontDialog.Font;
                this.listViewSinhVien.ForeColor =
                    this.fontDialog.Color;
            }

        }
        private void ExitCT()
        {
            DialogResult dlg = MessageBox.Show("Thong bao", "Ban co muon thoat chuong trinh hay ko?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(dlg== DialogResult.OK)
                Application.Exit();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            ExitCT();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            this.buttonExit.PerformClick();
        }
        private SinhVien GetSV()
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = this.maskedTextBoxMaSV.Text;
            sv.NgaySinh = this.dateTimePickerNgaySinh.Value;
            sv.Hinh = this.textBoxHinh.Text;
            return sv;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            //LoadDS();
            SinhVien sv = GetSV();

            //SinhVien kq = ql.Tim(sv.MaSo, delegate(object obj1, object obj2)
            // {
            //     return (obj2 as SinhVien).MaSo.CompareTo(obj1);
            // });

            SinhVien kq = ql.Tim(sv.MaSo, SoSanhTheoMa);
            if (kq != null)
            {
                MessageBox.Show("Sinh vien da ton tai!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1 );
            }
            else
            {
                ql.Them(sv);
                LoadDS();
            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }
        private int SoSanhSXTheoMaSV(object obj1, object obj2)
        {
            SinhVien sv1 = obj1 as SinhVien;
            SinhVien sv2 = obj2 as SinhVien;
            return sv1.MaSo.CompareTo(sv2.MaSo);
        }
        private int SoSanhSXTheoTen(object obj1, object obj2)
        {
            SinhVien sv1 = obj1 as SinhVien;
            SinhVien sv2 = obj2 as SinhVien;
           

            return -sv1.Ten.CompareTo(sv2.Ten);
        }
        private void sortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon(false);
            frm.ShowDialog();
            switch (frm.KieuTuyChon)
            {
                case frmTuyChon.Kieu.TheoMaSV:
                    ql.SapXep(SoSanhSXTheoMaSV);
                    break;
                case frmTuyChon.Kieu.TheoTen:
                    ql.SapXep(SoSanhSXTheoTen);
                    break;
                case frmTuyChon.Kieu.TheoNamSinh:
                    break;
                default:
                    break;
            }
            LoadDS();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon(true);
            frm.ShowDialog();
            MessageBox.Show(frm.ChuoiTim);
        }
    }
}
