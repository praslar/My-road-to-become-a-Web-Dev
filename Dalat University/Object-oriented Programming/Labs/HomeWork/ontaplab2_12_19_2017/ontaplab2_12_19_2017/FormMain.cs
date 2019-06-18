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

namespace ontaplab2_12_19_2017
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string s = "http://www.google.com";
            this.linkLabel1.Links.Add(0, s.Length, s);
            this.comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
            int i = this.listBoxdsmh.SelectedItems.Count-1;
            while (i>=0)
            {
                this.listBox2.Items.Add(listBoxdsmh.SelectedItems[i]);
                this.listBoxdsmh.Items.Remove(listBoxdsmh.SelectedItems[i]);
                i--;
            }
        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            int i = this.listBox2.SelectedItems.Count-1;
            while (i >= 0)
            {
                this.listBoxdsmh.Items.Add(this.listBox2.SelectedItems[i]);
                this.listBox2.Items.Remove(this.listBox2.SelectedItems[i]);
                i--;
            }
        }
    }
}
