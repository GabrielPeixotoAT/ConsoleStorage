using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.PurchaseOrder
{
    public class PurchaseOrderItem
    {
        public int PurchaseOrderItemID { get; set; }
        public int Quantity { get; set; }
        public Decimal UnitPrice { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual Product.Product Product { get; set; }
    }
}