using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoLaiLab2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem listview = new ListViewItem();
            listview.SubItems.Add(sv.MaSo);
            listview.SubItems.Add(sv.HoTen);
            listview.SubItems.Add(sv.NgaySinh.ToShortDateString());
            listview.SubItems.Add(sv.DiaChi);
            listview.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            listview.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            cn = cn.Substring(0, cn.Length - 1);
            listview.SubItems.Add(cn);
            listview.SubItems.Add(sv.Hinh);
            this.listViewdssv.Items.Add
        }
    }
}
