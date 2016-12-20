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
        object current_layout = MdiLayout.Cascade;
        public Form1()
        {
            InitializeComponent();
            hTile.Tag = MdiLayout.TileHorizontal;
            vTile.Tag = MdiLayout.TileVertical;
            cascade.Tag = MdiLayout.Cascade;
            arrange.Tag = MdiLayout.ArrangeIcons;
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open...";
            ofd.Filter = "Text file|*.txt";
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                closeMenu.Enabled = true;
                closeAllMenu.Enabled = true;
                string filepath = ofd.FileName;
                if (!File.Exists(filepath))
                File.Create(filepath);
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
            current_layout = (sender as ToolStripMenuItem).Tag;
            LayoutMdi((MdiLayout)(current_layout));
        }

        private void moveMenu_Click(object sender, EventArgs e)
        {
            var f = this.ActiveMdiChild;
            f.MdiParent = null;
            f.MdiParent = this;
            LayoutMdi((MdiLayout)(current_layout));
        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            TextBox tb = (this.ActiveMdiChild as ChildForm).textBox1;
            TextBox tb1 = (this.ActiveMdiChild as ChildForm).textBox1;
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i] == this.ActiveMdiChild)
                {
                    var c = i+1;
                    if (i == this.MdiChildren.Length - 1)
                        c = 0;
                    tb1 = (this.MdiChildren[c] as ChildForm).textBox1;
                }
            tb.AppendText(tb1.Text);
        }

        private void swapMenu_Click(object sender, EventArgs e)
        {
            TextBox tb = (this.ActiveMdiChild as ChildForm).textBox1;
            TextBox tb1 = (this.ActiveMdiChild as ChildForm).textBox1;
            for (int i = 0; i < this.MdiChildren.Length; ++i)
                if (this.MdiChildren[i] == this.ActiveMdiChild)
                {
                    var c = i + 1;
                    if (i == this.MdiChildren.Length - 1)
                        c = 0;
                    tb1 = (this.MdiChildren[c] as ChildForm).textBox1;
                }
            string temp = tb.Text;
            tb.Text = tb1.Text;
            tb1.Text = temp;
        }
    }
}
