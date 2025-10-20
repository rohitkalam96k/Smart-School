using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class MarksModel
    {
        public int markId { get; set; }
        public int? academicId { get; set; }
        public string? stdId { get; set; }
        public int? totalMark { get; set; }
        public int? obtainedMark { get; set; }
        public int? math { get; set; }
        public int? science { get; set; }
        public int? english { get; set; }
        public int? history { get; set; }
        public int? geography { get; set; }
        public int? marathi { get; set; }
        public int? hindi { get; set; }
        public DateTime? examDate { get; set; }
        
    }
}
