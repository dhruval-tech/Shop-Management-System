using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    public class customer
    {
        public int customerId { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public long contact { get; set; }
        public string address { get; set; }

       //public string productName { get; set; }
    }
}
