using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
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
         public string localAddress { get; set; }
         public string country { get; set; }
         public string state { get; set; }
         public string district { get; set; }
         public string city { get; set; }
         public int pincode { get; set; }
  
    }
}
