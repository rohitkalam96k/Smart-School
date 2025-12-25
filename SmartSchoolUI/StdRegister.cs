using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using BLL;
using System.Text.RegularExpressions;

namespace SmartSchoolUI
{
    public partial class StdRegister : Form
    {

        StudentRegistrationBLL _bll = new StudentRegistrationBLL();

        public StdRegister()
        {
            InitializeComponent();
        }

        private void txtAbc_TextChanged(object sender, EventArgs e)
        {
            txtAbc.Text = Regex.Replace(txtAbc.Text, "[^0-9]", "");
            txtAbc.SelectionStart = txtAbc.Text.Length;
        }

        private void txtAdharCard_TextChanged(object sender, EventArgs e)
        {
            txtAdharCard.Text = Regex.Replace(txtAdharCard.Text, "[^0-9]", "");
            txtAdharCard.SelectionStart = txtAdharCard.Text.Length;
        }

        private void txtParentMob_TextChanged(object sender, EventArgs e)
        {
            txtParentMob.Text = Regex.Replace(txtParentMob.Text, "[^0-9]", "");
            txtParentMob.SelectionStart = txtParentMob.Text.Length;
        }

        private void txtStdMob_TextChanged(object sender, EventArgs e)
        {
            txtStdMob.Text = Regex.Replace(txtStdMob.Text, "[^0-9]", "");
            txtStdMob.SelectionStart = txtStdMob.Text.Length;
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            txtPin.Text = Regex.Replace(txtPin.Text, "[^0-9]", "");
            txtPin.SelectionStart = txtPin.Text.Length;
        }

        // Helper Method to Get Data
        private StudentModel GetStudentFormData()
        {
            var student = new StudentModel();

            // Parse numeric ID safely
            long abcId;
            long.TryParse(txtAbc.Text, out abcId);
            student.abcId = abcId;

            // Basic text fields
            student.firstName = txtFirstName.Text.Trim();
            student.middleName = txtMiddleName.Text.Trim();
            student.lastName = txtLastName.Text.Trim();
            student.motherName = txtMotherName.Text.Trim();
            student.email = txtStdEmail.Text.Trim();
            student.aadharNo = txtAdharCard.Text.Trim();
            student.mobile = txtStdMob.Text.Trim();
            student.parentMobile = txtParentMob.Text.Trim();

            // Gender radio buttons
            if (rdoMale.Checked)

                student.gender = "Male";
            else if (rdoFemale.Checked)
                student.gender = "Female";
            else if (rdoOther.Checked)
                student.gender = "Other";

        


            // Date of Birth
            student.dob = dtpDob.Value;

            // Category and State dropdowns
            student.category = cmbCategory.SelectedItem != null ? cmbCategory.SelectedItem.ToString() : "";
            student.caste =  txtCast.Text.Trim();// Change if needed
            //student.religion = // Optional

            string state = cmbState.SelectedItem != null ? cmbState.SelectedItem.ToString() : "";
            string pin = txtPin.Text != null ? txtPin.Text.Trim() : "";
            string city = txtCity.Text != null ? txtCity.Text.Trim() : "";
            string street = txtStreet.Text != null ? txtStreet.Text.Trim() : "";

            // optional concatenating 
            student.localAddress = street + ", " + city + ", " + state + ", PIN: " + pin;

            // Optional fields
            student.mothertongue = ""; // Set if you have a control for this
            student.photo = "";        // Set if you have a photo path or upload logic
            //student.addressId = null;  // Set if you generate or fetch address ID elsewhere


            //photo path


            return student;
        }

        // Helper Method to Clear Form Data
        private void ClearAllFields()
        {
            // TextBoxes
            txtAbc.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtMotherName.Text = "";
            txtStdEmail.Text = "";
            txtAdharCard.Text = "";
            txtStdMob.Text = "";
            txtParentMob.Text = "";
            txtPin.Text = "";
            txtCity.Text = "";
            txtStreet.Text = "";

            // RadioButtons
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoOther.Checked = false;

            // DateTimePicker
            dtpDob.Value = DateTime.Now;

            // ComboBoxes
            cmbCategory.SelectedIndex = -1;
            cmbState.SelectedIndex = -1;

        }

        // Clear all Fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Photo";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = openFileDialog.FileName;
                txtPath.Text = selectedPath;

                try
                {
                    Image originalImage = Image.FromFile(selectedPath);
                    Image resizedImage = new Bitmap(originalImage, new Size(192, 160));
                    picPhoto.Image = resizedImage;
                    picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentModel student = GetStudentFormData();

            Console.WriteLine("=== Student Data ===");
            Console.WriteLine("ABC ID: " + student.abcId);
            Console.WriteLine("First Name: " + student.firstName);
            Console.WriteLine("Middle Name: " + student.middleName);
            Console.WriteLine("Last Name: " + student.lastName);
            Console.WriteLine("Mother Name: " + student.motherName);
            Console.WriteLine("Gender: " + student.gender);
            Console.WriteLine("DOB: " + (student.dob.HasValue ? student.dob.Value.ToString("dd-MM-yyyy") : ""));
            Console.WriteLine("Student Mobile: " + student.mobile);
            Console.WriteLine("Parent Mobile: " + student.parentMobile);
            Console.WriteLine("Email: " + student.email);
            Console.WriteLine("Aadhar No: " + student.aadharNo);
            Console.WriteLine("Local Address: " + student.localAddress);
            Console.WriteLine("Religion: " + student.religion);
            Console.WriteLine("Category: " + student.category);
            Console.WriteLine("Caste: " + student.caste);
            Console.WriteLine("Mother Tongue: " + student.mothertongue);
            Console.WriteLine("Photo Path: " + student.photo);

      
        }

        private void StdRegister_Load(object sender, EventArgs e)
        {
        

        }


    }
}
