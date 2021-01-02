using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    //customer_name,customer_email,customer_contact,
    //customer_address,product_name

    public class customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public int contact { get; set; }
        public string address { get; set; }
        public string product_name { get; set; }
    }
}
