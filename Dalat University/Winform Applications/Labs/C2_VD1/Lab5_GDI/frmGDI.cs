using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_GDI
{
    public partial class frmGDI : Form
    {
        Graphics graph;
        Pen pen = Pens.Black;
        Point pBatDau = new Point(0, 0);
        Brush bCoto = new SolidBrush(Color.Blue);
        enum LoaiHinh
        {
            DuongThang,
            HCN,
            Elip,
            Pie
        }

        LoaiHinh loaih = LoaiHinh.DuongThang;

        public frmGDI()
        {
            InitializeComponent();
        }

        private void ucColor1_Load(object sender, EventArgs e)
        {
            
        }

        private void ucColor1_Click(object sender, EventArgs e)
        {
            //this.panel.BackColor = ucColor1.GetColor;
            this.pen = new Pen(ucColor1.GetColor, 2.0f);

        }

        private void frmGDI_Load(object sender, EventArgs e)
        {
            this.graph = this.panel.CreateGraphics();
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(10, 10);
            this.graph.DrawLine(pen, 10, 10, 150, 50);
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            this.pBatDau = new Point(e.X, e.Y);
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolStripStatusLabel.Text = "("+e.X + "," + e.Y + ")";

        }

        private void radioButtonLoaiHinh_Click(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            switch (rd.Name)
            {
                case "radioButtonDT":
                    this.loaih = LoaiHinh.DuongThang;
                    break;
                case "radioButtonHCN":
                    this.loaih = LoaiHinh.HCN;
                    break;
                case "radioButtonElip":
                    this.loaih = LoaiHinh.Elip;
                    break;
            }
        }

        private void radioButtonDT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            Point pKetThuc = new Point(e.X, e.Y);
            int w, h;

            w =Math.Abs( pKetThuc.X - pBatDau.X);
            h=Math.Abs( pKetThuc.Y - pBatDau.Y);


            switch (this.loaih)
            {
                case LoaiHinh.DuongThang:
                    graph.DrawLine(this.pen, pBatDau, pKetThuc);
                    break;
                case LoaiHinh.HCN:
                    //graph.DrawRectangle(this.pen, pBatDau.X, pBatDau.Y, w, h);
                    graph.FillRectangle(this.bCoto, pBatDau.X, pBatDau.Y, w, h);

                    break;
                case LoaiHinh.Elip:
                    graph.DrawEllipse(this.pen, pBatDau.X, pBatDau.Y, w, h);
                    //graph.DrawPie(this.pen, pBatDau.X, pBatDau.Y, w, h, 190, 200);

                    break;
                case LoaiHinh.Pie:
                    break;
                default:
                    break;
            }
           
        }
    }
}
