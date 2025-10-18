using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class MarksModel
    {
        public int pk_markid { get; set; }

        public int? fk_academicid { get; set; }

        public string? stdid { get; set; }

        public int? totalmark { get; set; }

        public int? obtainedmark { get; set; }

        public int? math { get; set; }

        public int? science { get; set; }

        public int? english { get; set; }

        public int? history { get; set; }

        public int? geography { get; set; }

        public int? marathi { get; set; }

        public int? hindi { get; set; }

        public DateTime? exam_date { get; set; }
    }
}
