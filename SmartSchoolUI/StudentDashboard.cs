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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {

        }

        private void BtnAcademicData_Click(object sender, EventArgs e)
        {
            AcademicData academicdata = new AcademicData();
            academicdata.TopLevel = false;
            academicdata.Dock = DockStyle.Fill;
            panel2studentDashboard.Controls.Clear();
            panel2studentDashboard.Controls.Add(academicdata);
            academicdata.Show();
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {

        }
        private void BtnMarks_Click(object sender, EventArgs e)
        {
           
            StudentMarks studentmarks = new StudentMarks();
            studentmarks.TopLevel = false;
            studentmarks.Dock = DockStyle.Fill;
            panel2studentDashboard.Controls.Clear();
            panel2studentDashboard.Controls.Add(studentmarks);
            studentmarks.Show();
            studentmarks.Show();

        }

        private void BtnFees_Click(object sender, EventArgs e)
        {
           StudentFees studentfees = new StudentFees();
            studentfees.TopLevel = false;
            studentfees.Dock = DockStyle.Fill;
            panel2studentDashboard.Controls.Clear();
            panel2studentDashboard.Controls.Add(studentfees);
            studentfees.Show();
        }

        private void BtnDocuments_Click(object sender, EventArgs e)
        {
            StudentDocuments studentdocuments = new StudentDocuments();
            studentdocuments.TopLevel = false;
            studentdocuments.Dock = DockStyle.Fill;
            panel2studentDashboard.Controls.Clear();
            panel2studentDashboard.Controls.Add(studentdocuments);
            studentdocuments.Show();

        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
