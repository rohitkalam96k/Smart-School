using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class QualificationModel
    {
        public int pk_stf_qualificationid { get; set; }

        public string? fk_stf_id { get; set; }

        public string? stf_highestqualification { get; set; }

        public string? stf_specialisation { get; set; }

        public string? stf_certification { get; set; }

        public int? stf_experienceyear { get; set; }
    }
}
