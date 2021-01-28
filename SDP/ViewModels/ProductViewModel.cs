using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.ViewModels
{
    public class ProductViewModel
    {
        public int productId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int originalPrice { get; set; }
        public int MRP { get; set; }
        public int Quantity { get; set;  }

        public IFormFile Photo { get; set; }
    }
}
