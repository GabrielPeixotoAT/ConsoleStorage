using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.PurchaseOrder
{
    public class PurchaseOrder
    {
        public int PurchaseOrderID { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public virtual Supplier.Supplier Supplier { get; set; }
        public virtual PurchaseOrderStatus Status { get; set; }
    }
}