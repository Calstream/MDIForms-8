using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MDIForms_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open...";
            ofd.Filter = "Text file|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                closeMenu.Enabled = true;
                closeAllMenu.Enabled = true;
                string filepath = ofd.FileName;
                bool dup = false;
                foreach (Form f in this.MdiChildren)
                    if (f.Text == filepath)
                    {
                        f.Focus();
                        dup = true;
                    }
                if (!dup)
                {
                    ChildForm child = new ChildForm();
                    child.Show();
                    child.MdiParent = this;
                    child.Text = filepath;
                }
                if (this.MdiChildren.Length == 1)
                    windowToolStripMenuItem.Enabled = true;
                if (this.MdiChildren.Length == 2)
                {
                    moveMenu.Enabled = true;
                    addMenu.Enabled = true;
                    swapMenu.Enabled = true;
                }
            }
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            if (this.MdiChildren.Length <= 1)
            {
                moveMenu.Enabled = false;
                addMenu.Enabled = false;
                swapMenu.Enabled = false;
            }
            if (this.MdiChildren.Length == 0)
            {
                closeAllMenu.Enabled = false;
                closeMenu.Enabled = false;
                windowToolStripMenuItem.Enabled = false;
            }
        }

        private void closeAllMenu_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.Close();
            closeAllMenu.Enabled = false;
            closeMenu.Enabled = false;
        }

        private void change_layout(object sender, EventArgs e)
        {
            ToolStripMenuItem m = sender as ToolStripMenuItem;
            string s = m.Name;
            switch (s)
            {
                case "hTile":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
                case "vTile":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
                    break;
                case "arrange":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
                    break;
                case "cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
            }
        }

        private void moveMenu_Click(object sender, EventArgs e)
        {

        }

        private void addMenu_Click(object sender, EventArgs e)
        {

        }

        private void swapMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
