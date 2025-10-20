using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class DocumetSubmittedModel
    {
        public int documentId { get; set; }
        public int? academicId { get; set; }
        public bool? tc { get; set; }
        public bool? adharcard { get; set; }
        public bool? oldMarksheet { get; set; }
        public DateTime? submissionDate { get; set; }
   
    }
}
