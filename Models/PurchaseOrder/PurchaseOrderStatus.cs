using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.PurchaseOrder
{
    public class PurchaseOrderStatus
    {
        public int PurchaseOrderStatusID { get; set; }
        public string Description { get; set; }
        public virtual List<PurchaseOrder> PurchaseOrders { get; set; }
    }
}