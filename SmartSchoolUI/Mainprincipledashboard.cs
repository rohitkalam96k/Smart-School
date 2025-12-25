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
    public partial class Mainprincipledashboard : Form
    {
        public Mainprincipledashboard()
        {
            InitializeComponent();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            ad.FormBorderStyle = FormBorderStyle.None;
            panelPrincipal2Dashboard.Controls.Clear();
            panelPrincipal2Dashboard.Controls.Add(ad);
            ad.Show();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            StudentDashboard sd = new StudentDashboard();
            sd.TopLevel = false;
            sd.Dock = DockStyle.Fill;
            sd.FormBorderStyle = FormBorderStyle.None;

            panelPrincipal2Dashboard.Controls.Clear();
            panelPrincipal2Dashboard.Controls.Add(sd);
            sd.Show();
        }

        private void Mainprincipledashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
