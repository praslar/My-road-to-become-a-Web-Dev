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

namespace Lab2_relearn2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "http://www.google.com.vn";
            this.linkLabellienHe.Links.Add(0,s.Length,s);
            this.comboBoxmaSo.SelectedItem = this.comboBoxmaSo.Items[0];
        }
        private void linkLabellienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        private void buttonpick_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            
        }
        public void Reset()
        {
            
        }
        private void buttoncancel_Click(object sender, EventArgs e)
        {
         
        }
        
        private void buttonsave_Click(object sender, EventArgs e)
        {
        
        }
        private void buttonadd_Click(object sender, EventArgs e)
        {
        
        }
       private void buttondelete_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {

           
        }
    }
}
