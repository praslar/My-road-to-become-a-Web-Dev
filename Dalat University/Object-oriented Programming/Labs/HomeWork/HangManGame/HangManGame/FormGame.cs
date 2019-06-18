using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HangManGame
{
    public partial class Form1 : Form
    {
        private Point MouseDownPos;
        int thoigian;
        int missedcount;
        public Form1()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            //timer
            thoigian = 120;
            this.progressBar.Value = thoigian;
            this.timer.Start();
        }
        //TIMER
        private void timer_Tick(object sender, EventArgs e)
        {
            thoigian--;
            int t = thoigian * 100 / 120;
            t = t > 0 ? t : 0;
            this.progressBar.Value = thoigian > 0 ? thoigian : 0;
            if(thoigian==0)
            {
                MessageBox.Show("YOU DIE!");
                this.timer.Stop();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //timer
            Reset();
        }
        //CLOCK ANIMATIOn
        private void timerclock_Tick(object sender, EventArgs e)
        {
            this.pictureBoxclock2.Visible = this.pictureBoxclock2.Visible == true ? false : true;
        }
        //FORM DRAG
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(!MouseDownPos.IsEmpty)
            {
                int dx = e.Location.X - MouseDownPos.X;
                int dy = e.Location.Y - MouseDownPos.Y;
                Point NewPos = new Point(this.Location.X + dx, this.Location.Y + dy);
                this.Location = NewPos;
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.MouseDownPos = e.Location;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseDownPos = Point.Empty;
        }
    }
}
