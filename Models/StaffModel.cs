using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class StaffModel
    {
         public string pk_stf_id { get; set; }  // Primary key, not nullable

        public string stf_firstname { get; set; } 

        public string? stf_middlename { get; set; }

        public string stf_lastname { get; set; }

        public DateTime? stf_dob { get; set; }

        public string? stf_gender { get; set; }

        public string? stf_photo { get; set; }

        public string? stf_aadhar { get; set; }

        public DateTime? stf_joiningdate { get; set; }

        public string? stf_mobileno { get; set; }

        public string? stf_email { get; set; }

        public string? fk_stf_designationid { get; set; }

        public string? stf_status { get; set; }

        public string? stf_password { get; set; }

        public int? fk_stf_addressid { get; set; }

        public string? stf_localaddress { get; set; }
    }
}
