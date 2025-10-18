using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class FeesModel
    {
        public int pk_feeid { get; set; }

        public int? fk_academicid { get; set; }

        public decimal? total_fees { get; set; }

        public decimal? paid { get; set; }

        public decimal? due { get; set; }

        public string? remarkdue { get; set; }

        public string payment_status { get; set; } 
    }
}
