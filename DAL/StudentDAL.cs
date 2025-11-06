using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    public class StudentDAL
    {

        // Insert a new student

        public int Insert(StudentModel s1)
        {
            using (MySqlConnection con= DBConnection.GetConnection())
            {
                con.Open();
                string q = @"Insert into StudentModel(abcId,firstName,middleName,lastName,motherName,gender,dob,mobile,parentMobile,email,aadharNo,photo,localAddress,religion,category,caste,mothertongue,addressId) values (@abcId,@fn,@midn,@ln,@mon,@gen,@dob,@mob,@pmob,@email,@aadharno,@photo,@localadd,@relig,@cat,@caste,@mtng,@addid);";

                MySqlCommand cmd = new MySqlCommand(q, con);
                cmd.Parameters.AddWithValue("@abcid", s1.abcId);
                cmd.Parameters.AddWithValue("@fn", s1.firstName);
                cmd.Parameters.AddWithValue("@midn", s1.middleName);
                cmd.Parameters.AddWithValue("@ln", s1.lastName);
                cmd.Parameters.AddWithValue("@mon", s1.motherName);
                cmd.Parameters.AddWithValue("@gen", s1.gender);
                cmd.Parameters.AddWithValue("@dob", s1.dob);
                cmd.Parameters.AddWithValue("@mob", s1.mobile);
                cmd.Parameters.AddWithValue("@pmob", s1.parentMobile);
                cmd.Parameters.AddWithValue("@email", s1.email);
                cmd.Parameters.AddWithValue("@aadharno", s1.aadharNo);
                cmd.Parameters.AddWithValue("@photo", s1.photo);
                cmd.Parameters.AddWithValue("@localadd", s1.localAddress);
                cmd.Parameters.AddWithValue("@relg", s1.religion);
                cmd.Parameters.AddWithValue("@cat", s1.category);
                cmd.Parameters.AddWithValue("@caste", s1.caste);
                cmd.Parameters.AddWithValue("@mtng", s1.mothertongue);
                cmd.Parameters.AddWithValue("@addid", s1.addressId);
                return cmd.ExecuteNonQuery();
            }

        }

        // Get all students

        public StudentModel GetStudentByabcId(int abcId)
        {
            StudentModel student = null;

            using (MySqlConnection con1 = DBConnection.GetConnection())
            {
                string q1 = "SELECT abcId,firstName,middleName,lastName,motherName,gender,dob,mobile,parentMobile,email,aadharNo,photo,localAddress,religion,category,caste,mothertongue,addressId FROM StudentModel WHERE abcId = @abcid";
                MySqlCommand cmd = new MySqlCommand(q1, con1);
                cmd.Parameters.AddWithValue("@abcid", abcId);

                con1.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        student = new StudentModel
                        {                          
                            abcId = reader.GetInt32("abcId"),
                            firstName = reader["firstName"].ToString(),
                            middleName = reader["middleName"].ToString(),
                            lastName = reader["lastName"].ToString(),
                            motherName = reader["motherName"].ToString(),
                            gender = reader["gender"].ToString(),
                            dob = Convert.ToDateTime(reader["dob"]),
                            mobile = reader["mobile"].ToString(),
                            parentMobile = reader["parentMobile"].ToString(),
                            email = reader["email"].ToString(),
                            aadharNo = reader["aadharNo"].ToString(),
                            photo = reader["photo"].ToString(),
                            localAddress = reader["localAddress"].ToString(),
                            religion = reader["religion"].ToString(),
                            category = reader["cat"].ToString(),
                            caste = reader["caste"].ToString(),
                            mothertongue = reader["mothertongue"].ToString(),
                            addressId = Convert.ToInt32(reader["addressId"]),                         

                        };
                    }
                }
            }
            return student;
        }

        // Update student details
        public int UpdateStudent(StudentModel s1)
        {
            using (MySqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"UPDATE Students SET 
            firstName = @fn, middleName = @mn, lastName = @ln, motherName = @mon,
            gender = @g, dob = @dob, mobile = @mob, parentMobile = @pmob,
            email = @email, aadharNo = @aadharno, photo = @photo, localAddress = @localadd,
            religion = @relg, caste = @caste, mothertongue = @mtng, addressId = @addid
            WHERE abcId = @abcid";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@abcid", s1.abcId);
                cmd.Parameters.AddWithValue("@fn", s1.firstName);
                cmd.Parameters.AddWithValue("@mn", s1.middleName);
                cmd.Parameters.AddWithValue("@ln", s1.lastName);
                cmd.Parameters.AddWithValue("@mon", s1.motherName);
                cmd.Parameters.AddWithValue("@g", s1.gender);
                cmd.Parameters.AddWithValue("@dob", s1.dob);
                cmd.Parameters.AddWithValue("@mob", s1.mobile);
                cmd.Parameters.AddWithValue("@pmob", s1.parentMobile);
                cmd.Parameters.AddWithValue("@email", s1.email);
                cmd.Parameters.AddWithValue("@aadharno", s1.aadharNo);
                cmd.Parameters.AddWithValue("@photo", s1.photo);
                cmd.Parameters.AddWithValue("@localadd", s1.localAddress);
                cmd.Parameters.AddWithValue("@relg", s1.religion);
                smd.Parameters.AddWithValue("@cat", s1.category);
                cmd.Parameters.AddWithValue("@caste", s1.caste);
                cmd.Parameters.AddWithValue("@mtng", s1.mothertongue);
                cmd.Parameters.AddWithValue("@addid", s1.addressId);

                return cmd.ExecuteNonQuery();
            }
        }

    }
}
