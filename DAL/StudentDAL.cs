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
            using (MySqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string q = @"INSERT INTO studentData (
                                std_abcid, std_firstname, std_midlename, std_lastname, std_motherName,
                                std_gender, std_DOB, std_mobile, std_parentMobile, std_email,
                                std_adharno, std_photo, std_localaddress, std_category,
                                std_cast
                            ) VALUES (
                                @abcid, @fn, @midn, @ln, @mon,
                                @gen, @dob, @mob, @pmob, @email,
                                @aadharno, @photo, @localadd, @cat,
                                @caste
                            );";


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
                cmd.Parameters.AddWithValue("@cat", s1.category);
                cmd.Parameters.AddWithValue("@caste", s1.caste);
                Console.WriteLine(s1.gender);
                return cmd.ExecuteNonQuery();
            }
        }


        // Get all students

        public StudentModel GetStudentByabcId(int abcId)
        {
            using (MySqlConnection con1 = DBConnection.GetConnection())
            {
                string q1 = @"SELECT std_abcid, std_firstname, std_midlename, std_lastname, std_motherName,
                             std_gender, std_DOB, std_mobile, std_parentMobile, std_email,
                             std_adharno, std_photo, std_localaddress, std_religion, std_category,
                             std_cast, std_mothertoung, fk_std_addressid
                      FROM studentData
                      WHERE std_abcid = @abcid";

                MySqlCommand cmd = new MySqlCommand(q1, con1);
                cmd.Parameters.AddWithValue("@abcid", abcId);

                con1.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new StudentModel
                        {
                            abcId = reader.GetInt64("std_abcid"),
                            firstName = reader["std_firstname"].ToString(),
                            middleName = reader["std_midlename"].ToString(),
                            lastName = reader["std_lastname"].ToString(),
                            motherName = reader["std_motherName"].ToString(),
                            gender = reader["std_gender"].ToString(),
                            dob = reader["std_DOB"] as DateTime?,
                            mobile = reader["std_mobile"].ToString(),
                            parentMobile = reader["std_parentMobile"].ToString(),
                            email = reader["std_email"].ToString(),
                            aadharNo = reader["std_adharno"].ToString(),
                            photo = reader["std_photo"].ToString(),
                            localAddress = reader["std_localaddress"].ToString(),
                            religion = reader["std_religion"].ToString(),
                            category = reader["std_category"].ToString(),
                            caste = reader["std_cast"].ToString(),
                            mothertongue = reader["std_mothertoung"].ToString(),
                            addressId = reader["fk_std_addressid"] as int?,

                        }; 
                    }
                }
            }
            return null;
        }

        // Update student details
        public bool UpdateStudent(StudentModel s1)
        {
            using (MySqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"UPDATE studentData SET 
                            std_firstname = @fn, std_midlename = @mn, std_lastname = @ln, std_motherName = @mon,
                            std_gender = @g, std_DOB = @dob, std_mobile = @mob, std_parentMobile = @pmob,
                            std_email = @email, std_adharno = @aadharno, std_photo = @photo, std_localaddress = @localadd,
                            std_religion = @relg, std_category = @cat, std_cast = @caste, std_mothertoung = @mtng,
                            fk_std_addressid = @addid
                        WHERE std_abcid = @abcid";

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
                cmd.Parameters.AddWithValue("@cat", s1.category);
                cmd.Parameters.AddWithValue("@caste", s1.caste);
                cmd.Parameters.AddWithValue("@mtng", s1.mothertongue);
                cmd.Parameters.AddWithValue("@addid", s1.addressId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
