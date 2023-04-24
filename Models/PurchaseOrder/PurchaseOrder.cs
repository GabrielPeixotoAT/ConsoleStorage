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
        public Supplier.Supplier Supplier { get; set; }
        public PurchaseOrderStatus Status { get; set; }
        public virtual List<PurchaseOrderItem> Items { get; set; }
    }
}