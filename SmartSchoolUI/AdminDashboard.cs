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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {

            StdRegister regForm = new StdRegister();
            regForm.TopLevel = false;
            regForm.Dock = DockStyle.Fill;
            panelAdminDashboard.Controls.Clear();
            panelAdminDashboard.Controls.Add(regForm);
            regForm.Show();
        }

        private void panelAdminDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
