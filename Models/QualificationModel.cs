using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class QualificationModel
    {
        public int qualificationId { get; set; }
        public string id { get; set; }
        public string highestQualification { get; set; }
        public string specialisation { get; set; }
        public string certification { get; set; }
        public int experienceYear { get; set; }  
    }
}
