using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SalaryModel
    {
        public int salaryId { get; set; }
        public string id { get; set; }
        public decimal salaryAmount { get; set; }
        public long ankaccountNo { get; set; }
        public string ifsc { get; set; }
        public string pan { get; set; }
        public string salaryType { get; set; }
   
    }
}
