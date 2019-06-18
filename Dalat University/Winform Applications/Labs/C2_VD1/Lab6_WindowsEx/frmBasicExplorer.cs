using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_WindowsEx
{
    public partial class frmBasicExplorer : Form
    {
        TreeNode tnCurrent;
        public frmBasicExplorer()
        {
            InitializeComponent();
        }

        private void frmBasicExplorer_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo item in DriveInfo.GetDrives())
            {
                TreeNode tn = new TreeNode(item.Name, 0, 2);
                this.treeView.Nodes.Add(tn);
            }
        }

        private void treeView_MouseDown(object sender, MouseEventArgs e)
        {
            tnCurrent = this.treeView.GetNodeAt(e.X, e.Y);
            if (tnCurrent != null)
            {
                this.toolStripStatusLabel1.Text = tnCurrent.FullPath;
                DirectoryInfo dir = new DirectoryInfo(tnCurrent.FullPath);
                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    tnCurrent.Nodes.Add(d.Name);
                }

                foreach (FileInfo file in dir.GetFiles())
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.CreationTime.ToShortDateString());
                    item.SubItems.Add(file.Length.ToString());

                    this.listView.Items.Add(item);
                }
           }
        }
    }
}
