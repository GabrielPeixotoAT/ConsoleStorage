using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Purchase
{
    public class PurchaseItem
    {
        public int PurchaseItemID { get; set; }
        public int Quantity { get; set; }
        public Decimal UnitPrice { get; set; }
        public Product.Product Product { get; set; }
        public Purchase Purchase { get; set; }
    }
}