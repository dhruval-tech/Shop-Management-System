using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.ViewModels
{
    public class CustomerViewModel
    {
        [Required]
        public int customerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int contact { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string address { get; set; }
    }
}
