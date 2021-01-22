using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.ViewModels
{
    public class PurchaseProductViewModel
    {
        [Required]
       public String ProductName { get; set; }

        [Required]
       public String ProductCategory { get; set; }
        [Required]
        public int ProductQuantity { get; set; }
    }
}
