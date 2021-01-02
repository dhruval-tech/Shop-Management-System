using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    //(worker_email, worker_name, worker_contact, worker_sallery,
    //worker_address, role)

    public class staff
    {
        public int id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public int contact { get; set; }
        public int salary { get; set; }
        public string address { get; set; }
        public string role { get; set; }
    }
}
