using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
<<<<<<< HEAD
    public class FeesModel
    {
        public int feeId { get; set; }
        public int academicId { get; set; }
        public decimal totalFees { get; set; }
        public decimal paid { get; set; }
        public decimal due { get; set; }
        public string remarkDue { get; set; }
=======
    class FeesModel
    {
        public int feeId { get; set; }
        public int? academicId { get; set; }
        public decimal? totalFees { get; set; }
        public decimal? paid { get; set; }
        public decimal? due { get; set; }
        public string? remarkDue { get; set; }
>>>>>>> 233690be0a29c2ad296243fd7a6d54a190d4695c
        public string paymentStatus { get; set; } 

     }
}
