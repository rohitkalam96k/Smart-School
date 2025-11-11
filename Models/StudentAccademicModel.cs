using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
<<<<<<< HEAD
   public class StudentAccademicModel
    {
        public int academicId { get; set; }
        public long abcId { get; set; }
        public int passingYear { get; set; }
        public decimal oldMarks { get; set; }
        public string schoolName { get; set; }
        public int currentYear { get; set; }
        public string currentClass { get; set; }
        public string division { get; set; }
        public int rollNo { get; set; }
        public DateTime registrationDate { get; set; }
=======
    class StudentAccademicModel
    {
        public int academicId { get; set; }
        public long? stdAbcId { get; set; }
        public int? passingYear { get; set; }
        public decimal? oldMarks { get; set; }
        public string schoolName { get; set; }
        public int? currentYear { get; set; }
        public string currentClass { get; set; }
        public string division { get; set; }
        public int? rollNo { get; set; }
        public DateTime? registrationDate { get; set; }
>>>>>>> 233690be0a29c2ad296243fd7a6d54a190d4695c
        public string currentSchoolName { get; set; }
      
    }
}
