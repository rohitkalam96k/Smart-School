using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class StudentAccademicModel
    {
        public int pk_academicid { get; set; }

        public long? fk_std_abcid { get; set; }

        public int? passingyear { get; set; }

        public string @class { get; set; }

        public decimal? oldmarks { get; set; }

        public string schoolname { get; set; }

        public int? currentyear { get; set; }

        public string currentclass { get; set; }

        public string division { get; set; }

        public int? rollno { get; set; }

        public DateTime? regdate { get; set; }

        public string currentschoolname { get; set; }
    }
}
