using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
<<<<<<< HEAD
   public  class StaffModel
    {
         public string id { get; set; }  // Primary key, not nullable
         public string firstName { get; set; }
         public string middleName { get; set; }
         public string lastName { get; set; }
         public DateTime dob { get; set; }
         public string gender { get; set; }
         public string photo { get; set; }
         public string aadhar { get; set; }
         public DateTime joiningDate { get; set; }
         public string mobileNo { get; set; }
         public string email { get; set; }
         public string designationId { get; set; }
         public string status { get; set; }
         public string password { get; set; }
         public int addressId { get; set; }
         public string localAddress { get; set; }
=======
    class StaffModel
    {
         public string id { get; set; }  // Primary key, not nullable
         public string firstName { get; set; }
         public string? middleName { get; set; }
         public string lastName { get; set; }
         public DateTime? dob { get; set; }
         public string? gender { get; set; }
         public string? photo { get; set; }
         public string? aadhar { get; set; }
         public DateTime? joiningDate { get; set; }
         public string? mobileNo { get; set; }
         public string? email { get; set; }
         public string? designationId { get; set; }
         public string? status { get; set; }
         public string? password { get; set; }
         public int? addressId { get; set; }
         public string? localAddress { get; set; }
>>>>>>> 233690be0a29c2ad296243fd7a6d54a190d4695c
  
    }
}
