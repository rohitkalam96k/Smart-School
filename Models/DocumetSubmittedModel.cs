using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
<<<<<<< HEAD
    public class DocumetSubmittedModel
    {
        public int documentId { get; set; }

        public int academicId { get; set; }
        public string tc { get; set; }
        public string adharcard { get; set; }
        public string oldMarksheet { get; set; }

=======
    class DocumetSubmittedModel
    {
        public int documentId { get; set; }
        public int? academicId { get; set; }
        public bool? tc { get; set; }
        public bool? adharcard { get; set; }
        public bool? oldMarksheet { get; set; }
>>>>>>> 233690be0a29c2ad296243fd7a6d54a190d4695c
        public DateTime? submissionDate { get; set; }
   
    }
}
