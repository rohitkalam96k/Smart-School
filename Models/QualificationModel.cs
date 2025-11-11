using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
<<<<<<< HEAD
    public class QualificationModel
    {
        public int qualificationId { get; set; }
        public string id { get; set; }
        public string highestQualification { get; set; }
        public string specialisation { get; set; }
        public string certification { get; set; }
        public int experienceYear { get; set; }  
=======
    class QualificationModel
    {
        public int qualificationId { get; set; }
        public string? stfId { get; set; }
        public string? stfHighestQualification { get; set; }
        public string? stfSpecialisation { get; set; }
        public string? stfCertification { get; set; }
        public int? stfExperienceYear { get; set; }  
>>>>>>> 233690be0a29c2ad296243fd7a6d54a190d4695c
    }
}
