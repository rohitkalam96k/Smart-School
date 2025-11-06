using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class FeesModel
    {
        public int feeId { get; set; }
        public int academicId { get; set; }
        public decimal totalFees { get; set; }
        public decimal paid { get; set; }
        public decimal due { get; set; }
        public string remarkDue { get; set; }
        public string paymentStatus { get; set; } 

     }
}
