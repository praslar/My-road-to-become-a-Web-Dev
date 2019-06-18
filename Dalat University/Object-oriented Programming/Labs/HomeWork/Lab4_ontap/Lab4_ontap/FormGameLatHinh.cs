using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_ontap
{
    public partial class FormGameLatHinh : Form
    {
        private int thoigian;
        private int dem = 0;
        private string hinhchon { get; set; }
        private int cstruoc { get; set; }
        private string defaultpicture = "HoaMacDinh.jpg";
        public List<string> dshinhchoi = new List<string>();
        public FormGameLatHinh()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            this.hinhchon = "";
            cstruoc = -1;
            thoigian = 120;
            Random rd = new Random();
            int[] danhdau = new int[12];
            for (int i = 0; i < 12; i++)
            {
                danhdau[i] = 0;
            }
            for (int i = 0; i < 24; i++)
            {
                PictureBox pt = new PictureBox();
                int c;
                do
                {
                    c = rd.Next(0, 12);
                } while (danhdau[c] == 2);
                danhdau[c]++;
                string filename = "Hoa" + c + ".jpg";
                this.dshinhchoi.Add(filename);
            }
            this.pictureBox1.ImageLocation = defaultpicture;
            this.pictureBox2.ImageLocation = defaultpicture;
            this.pictureBox3.ImageLocation = defaultpicture;
            this.pictureBox4.ImageLocation = defaultpicture;
            this.pictureBox5.ImageLocation = defaultpicture;
            this.pictureBox6.ImageLocation = defaultpicture;
            this.pictureBox7.ImageLocation = defaultpicture;
            this.pictureBox8.ImageLocation = defaultpicture;
            this.pictureBox9.ImageLocation = defaultpicture;
            this.pictureBox10.ImageLocation = defaultpicture;
            this.pictureBox11.ImageLocation = defaultpicture;
            this.pictureBox12.ImageLocation = defaultpicture;
            this.pictureBox13.ImageLocation = defaultpicture;
            this.pictureBox14.ImageLocation = defaultpicture;
            this.pictureBox15.ImageLocation = defaultpicture;
            this.pictureBox16.ImageLocation = defaultpicture;
            this.pictureBox17.ImageLocation = defaultpicture;
            this.pictureBox18.ImageLocation = defaultpicture;
            this.pictureBox19.ImageLocation = defaultpicture;
            this.pictureBox20.ImageLocation = defaultpicture;
            this.pictureBox21.ImageLocation = defaultpicture;
            this.pictureBox22.ImageLocation = defaultpicture;
            this.pictureBox23.ImageLocation = defaultpicture;
            this.pictureBox24.ImageLocation = defaultpicture;
            this.timer1.Start();
            this.buttonrestart.Visible = false;
            this.progressBar1.Value = thoigian;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            thoigian--;
            int t = thoigian * 100 / 120;
            t = t > 0 ? t : 0;
            this.progressBar1.Value = thoigian > 0 ? thoigian : 0;
            this.label1.Text = t + "%";
            if (thoigian == 0)
            {
                timer1.Stop();
                MessageBox.Show("YOU DIE");
                this.buttonrestart.Visible = true;
            }
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormGameLatHinh_Load(object sender, EventArgs e)
        {           
            Reset();
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pt = sender as PictureBox;
            string s = pt.Name;
            MessageBox.Show(s.ToString());
            string a = s.Substring(s.LastIndexOf('x') + 1, s.Length - s.LastIndexOf('x') - 1);
            int v = int.Parse(a);
            v = v - 1;
            pt.ImageLocation = this.dshinhchoi[v];
            if (cstruoc != v)
            {
                if (this.hinhchon.CompareTo(pt.ImageLocation)==0)
                {
                    dem++;
                    cstruoc = -1;
                    this.hinhchon = "";
                    if (dem==12)
                    {
                        timer1.Stop();
                        MessageBox.Show("VICTORY!");
                        this.buttonrestart.Visible = true;
                    }
                }
                else
                {
                    switch (cstruoc)
                    {
                        case 0:
                            this.pictureBox1.ImageLocation = defaultpicture;
                            break;
                        case 1:
                            this.pictureBox2.ImageLocation = defaultpicture;
                            break;
                        case 2:
                            this.pictureBox3.ImageLocation = defaultpicture;
                            break;
                        case 3 :
                            this.pictureBox4.ImageLocation = defaultpicture;
                            break;
                        case 4:
                            this.pictureBox5.ImageLocation = defaultpicture;
                            break;
                        case 5:
                            this.pictureBox6.ImageLocation = defaultpicture;
                            break;
                        case 6:
                            this.pictureBox7.ImageLocation = defaultpicture;
                            break;
                        case 7:
                            this.pictureBox8.ImageLocation = defaultpicture;
                            break;
                        case 8:
                            this.pictureBox9.ImageLocation = defaultpicture;
                            break;
                        case 9:
                            this.pictureBox10.ImageLocation = defaultpicture;
                            break;
                        case 10:
                            this.pictureBox11.ImageLocation = defaultpicture;
                            break;
                        case 11:
                            this.pictureBox12.ImageLocation = defaultpicture;
                            break;
                        case 12:
                            this.pictureBox13.ImageLocation = defaultpicture;
                            break;
                        case 13:
                            this.pictureBox14.ImageLocation = defaultpicture;
                            break;
                        case 14:
                            this.pictureBox15.ImageLocation = defaultpicture;
                            break;
                        case 15:
                            this.pictureBox16.ImageLocation = defaultpicture;
                            break;
                        case 16:
                            this.pictureBox17.ImageLocation = defaultpicture;
                            break;
                        case 17:
                            this.pictureBox18.ImageLocation = defaultpicture;
                            break;
                        case 18:
                            this.pictureBox19.ImageLocation = defaultpicture;
                            break;
                        case 19:
                            this.pictureBox20.ImageLocation = defaultpicture;
                            break;
                        case 20:
                            this.pictureBox21.ImageLocation = defaultpicture;
                            break;
                        case 21:
                            this.pictureBox22.ImageLocation = defaultpicture;
                            break;
                        case 22:
                            this.pictureBox23.ImageLocation = defaultpicture;
                            break;
                        case 23:
                            this.pictureBox24.ImageLocation = defaultpicture;
                            break;
                        case -1:
                            break;
                    }
                    cstruoc = v;
                    this.hinhchon = pt.ImageLocation;
                }

            }
        }
    }
}
