using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class StudentModel
    {
        public long pk_std_abcid { get; set; }

        public string std_firstname { get; set; }

        public string std_middlename { get; set; }

        public string std_lastname { get; set; }

        public string std_motherName { get; set; }

        public string std_gender { get; set; }

        public DateTime? std_DOB { get; set; }

        public string std_mobile { get; set; }

        public string std_parentMobile { get; set; }

        public string std_email { get; set; }

        public string std_adharno { get; set; }

        public string std_photo { get; set; }

        public string std_localaddress { get; set; }

        public string std_religion { get; set; }

        public string std_category { get; set; }

        public string std_caste { get; set; }

        public string std_mothertongue { get; set; }

        public int? fk_std_addressid { get; set; }

    }
}
