using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartSchoolUI
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StdRegister register = new StdRegister();
            register.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StdList list = new StdList();
            list.Show();
        }
    }
}
