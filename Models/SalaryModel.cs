using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class SalaryModel
    {
        public int pk_stf_salaryid { get; set; }

        public string? fk_stf_id { get; set; }

        public decimal? stf_salaryamount { get; set; }

        public long? stf_bankaccountno { get; set; }

        public string? stf_ifsc { get; set; }

        public string? stf_pan { get; set; }

        public string? stf_salarytype { get; set; }
    }
}
