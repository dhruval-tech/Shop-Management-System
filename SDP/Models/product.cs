using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    //    product_Name, product_Category,product_Original_Price,
    //product_MRP,product_IsPurchased

    public class product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int original_price { get; set; }
        public int MRP { get; set; }
        public bool isPurchase { get; set; } 

    }
}
