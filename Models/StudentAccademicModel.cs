using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
   public class StudentAccademicModel
    {
        public int academicId { get; set; }
        public long? abcId { get; set; }
        public int? passingYear { get; set; }
        public decimal? oldMarks { get; set; }
        public string schoolName { get; set; }
        public int? currentYear { get; set; }
        public string currentClass { get; set; }
        public string division { get; set; }
        public int? rollNo { get; set; }
        public DateTime? registrationDate { get; set; }
        public string currentSchoolName { get; set; }
      
    }
}
