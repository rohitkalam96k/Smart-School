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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                MessageBox.Show("Please Enter Your Password");
                return;
            }
            string password=textPassword.Text;
            MessageBox.Show("Your Password "+password);
        }
        private void Index_Load(object sender, EventArgs e)
        {
           
        }
<<<<<<< HEAD
<<<<<<< HEAD
       
=======
=======
>>>>>>> 5fdb6affe82ed4eaf514066285de6287e4cd7289

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
<<<<<<< HEAD
>>>>>>> 754a88d3c5ec7738356eefe0e77e15a7ac2fe455
=======
>>>>>>> 5fdb6affe82ed4eaf514066285de6287e4cd7289
    }
}
