using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class AddressModel
    {
        public int addressId { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string pincode { get; set; }
 
        }
}
