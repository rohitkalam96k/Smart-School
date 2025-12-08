using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SmartSchoolUI
{
    public partial class StudentDocuments : Form
    {
        public StudentDocuments()
        {
            InitializeComponent();
        }

        private void BtnTC_Click(object sender, EventArgs e)
        {
           

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Destination folder path for T.C
                string destPath = Application.StartupPath + "\\Documents\\TC\\";
                Directory.CreateDirectory(destPath);

                // Get file name from selected file
                string fileName = Path.GetFileName(ofd.FileName);

                // Combine destination path + file name
                string savePath = Path.Combine(destPath, fileName);

                // Copy file to destination folder
                File.Copy(ofd.FileName, savePath, true);

                // Success message
                MessageBox.Show("T.C saved successfully!");
            }


        }

        private void BtnAdharcard_Click(object sender, EventArgs e)
        {
           

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Destination folder path for Aadhaar Card
                string destPath = Application.StartupPath + "\\Documents\\AdharCard\\";
                Directory.CreateDirectory(destPath);

                // Get file name from selected file
                string fileName = Path.GetFileName(ofd.FileName);

                // Combine destination path + file name
                string savePath = Path.Combine(destPath, fileName);

                // Copy file to destination folder
                File.Copy(ofd.FileName, savePath, true);

                // Success message
                MessageBox.Show("Aadhaar Card saved successfully!");
            }


        }

        private void BtnOldMarkSheet_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Destination folder path for Old Marksheet
                string destPath = Application.StartupPath + "\\Documents\\OldMarksheet\\";
                Directory.CreateDirectory(destPath);

                // Get file name from selected file
                string fileName = Path.GetFileName(ofd.FileName);

                // Combine destination path + file name
                string savePath = Path.Combine(destPath, fileName);

                // Copy file to destination folder
                File.Copy(ofd.FileName, savePath, true);

                // Success message
                MessageBox.Show("Old Marksheet saved successfully!");
            }
        }
    }
}
