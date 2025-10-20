using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class QualificationModel
    {
        public int qualificationId { get; set; }
        public string? stfId { get; set; }
        public string? stfHighestQualification { get; set; }
        public string? stfSpecialisation { get; set; }
        public string? stfCertification { get; set; }
        public int? stfExperienceYear { get; set; }  
    }
}
