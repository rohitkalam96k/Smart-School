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
       
    }
}
