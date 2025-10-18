using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class DocumetSubmittedModel
    {
        public int pk_docid { get; set; }

        public int? fk_academicid { get; set; }

        public bool? tc { get; set; }

        public bool? adharcard { get; set; }

        public bool? oldmarksheet { get; set; }
        public DateTime? submission_date { get; set; }
    }
}
