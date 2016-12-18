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
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
            
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filepath = this.Text;
            File.WriteAllText(filepath, textBox1.Text);
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ChildForm_TextChanged(object sender, EventArgs e)
        {
            string filepath = this.Text;
            StreamReader sr = new StreamReader(filepath);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
