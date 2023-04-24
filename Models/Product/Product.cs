using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Product
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
        public int MinimalQuantity { get; set; }
        public DateTime ExpiringDate { get; set; }
        public virtual Store.Store Store { get; set; }
    }
}