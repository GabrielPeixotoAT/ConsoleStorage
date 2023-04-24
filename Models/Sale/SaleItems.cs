using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Sale
{
    public class SaleItems
    {
        public int SaleItemsID { get; set; }
        public int Quantity { get; set; }
        public Decimal UnitPrice { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Product.Product Product { get; set; }
    }
}