using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class DocumetSubmittedModel
    {
        public int documentId { get; set; }
        public int academicId { get; set; }
        public string tc { get; set; }
        public string adharcard { get; set; }
        public string oldMarksheet { get; set; }
        public DateTime? submissionDate { get; set; }
   
    }
}
