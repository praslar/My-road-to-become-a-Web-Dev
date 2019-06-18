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

namespace lab2_relearn_1
{
    public partial class Form1 : Form
    {
        QuanLyGiaoVien qlgv = new QuanLyGiaoVien();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string lienhe = "http://www.google.com";
            this.linkLabellienhe.Links.Add(0, lienhe.Length, lienhe);
        }
        private void buttonchon_Click(object sender, EventArgs e)
        {
            int i = this.listBoxdsmh.SelectedItems.Count - 1;
            while (i>=0)
            {
                this.listBoxmonDay.Items.Add(listBoxdsmh.SelectedItems[i]);
                this.listBoxdsmh.Items.Remove(listBoxdsmh.SelectedItems[i]);
                i--;
            }
        }
        private void buttonbochon_Click(object sender, EventArgs e)
        {
            int i = this.listBoxmonDay.SelectedItems.Count - 1;
            while (i>=0)
            {
                this.listBoxdsmh.Items.Add(listBoxmonDay.SelectedItems[i]);
                this.listBoxmonDay.Items.Remove(listBoxmonDay.SelectedItems[i]);
                i--;
            }
        }
        private void linkLabellienhe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        private void Reset()
        {
            for (int i = 0; i < this.checkedListBoxngoaiNgu.Items.Count; i++)
                this.checkedListBoxngoaiNgu.SetItemChecked(i, false);
            foreach (object item in this.listBoxmonDay.Items)
            {
                this.listBoxdsmh.Items.Add(item);
            }
            this.listBoxmonDay.Items.Clear();
        }
        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public GiaoVien GetGiaoVien()
        {
            
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.comboBoxhoTen.Text;
            DanhSachMonHoc dsmh = new DanhSachMonHoc();
            foreach (object item in this.listBoxmonDay.Items)
            {
                dsmh.Add(new MonHoc(item.ToString()));
            }
            gv.dsmh = dsmh;
            string nn = "";
            for (int i = 0; i < this.checkedListBoxngoaiNgu.Items.Count; i++)
                if (this.checkedListBoxngoaiNgu.GetItemChecked(i))
                    nn += checkedListBoxngoaiNgu.Items[i] + ";";
            gv.NgoaiNgu = nn.Split(';');
            return gv;
        }
        private void buttonsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetGiaoVien().ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv = GetGiaoVien();
            GiaoVien kq = qlgv.KiemTra(gv.MaSo, SoSanhTheoMa);
            if(kq!=null)
            {
                MessageBox.Show("Error");
                return;
            }
            else
            {
                MessageBox.Show("ok");
                qlgv.Them(gv);
                Reset();
            }
        }
        private int SoSanhTheoMa(object obj1,object obj2)
        {
            GiaoVien gv = obj2 as GiaoVien;
            return gv.MaSo.CompareTo(obj1);
        }
    }
}
