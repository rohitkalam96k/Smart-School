using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    class StudentRegistrationBLL
    {
        StudentModel s1 = new StudentModel();
        public string AddStudent(StudentModel std)
        {
            // abc id
            if (std.abcId <= 0)
                return "Please enter a valid student ID";
            //first name
            if (s1.firstName == "")
                return "Please enter your first name";
            //last name
            if (s1.lastName == "")
                return "Please enter your last name";
            //middle name
            if (s1.middleName == "")
                return "Please enter your middle name";
            //mother name
            if (s1.motherName == "")
                return "Please enter your mother name";
            //gender
            if (string.IsNullOrEmpty(std.gender))
                return "Please select your gender";

            // Date of birth 
            if (std.dob == null)
                return "Please enter your date of birth";

            // Mobile number validation
            if (string.IsNullOrEmpty(std.mobile) || std.mobile.Length != 10)
                return "Please enter a valid 10-digit mobile number";

            if (string.IsNullOrEmpty(std.parentMobile) || std.parentMobile.Length != 10)
                return "Please enter a valid 10-digit parent mobile number";

            // Email validation
            if (string.IsNullOrEmpty(std.email) || !std.email.Contains("@"))
                return "Please enter a valid email address";

            // Aadhar number validation
            if (!string.IsNullOrEmpty(std.aadharNo) && std.aadharNo.Length != 12)
                return "Aadhar number must be 12 digits";

            // Optional fields (can be empty but checked for length)
            if (!string.IsNullOrEmpty(std.localAddress) && std.localAddress.Length > 200)
                return "Local address is too long";

            if (!string.IsNullOrEmpty(std.religion) && std.religion.Length > 50)
                return "Religion name is too long";

            if (!string.IsNullOrEmpty(std.category) && std.category.Length > 50)
                return "Category name is too long";

            if (!string.IsNullOrEmpty(std.caste) && std.caste.Length > 50)
                return "Caste name is too long";

            if (!string.IsNullOrEmpty(std.mothertongue) && std.mothertongue.Length > 50)
                return "Mother tongue name is too long";

            // Address ID validation
            if (std.addressId != null && std.addressId <= 0)
                return "Invalid address ID";



            else
                return "Student registered succesfully";
                DAL.insert(std);
        }

        public string updateStudent()
        {

        }

        public string displayStudent()
        { 
        
        }

        public string displayAll()
        { 
        
        }
    }
}
