using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    public class product
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int originalPrice { get; set; }
        public int MRP { get; set; }
        public int Quantity { get; set;  }
        public string Photopath { get; set; }
    }
}
