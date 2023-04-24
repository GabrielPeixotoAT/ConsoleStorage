using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Purchase
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public DateTime Date { get; set; }
        public virtual Supplier.Supplier Supplier { get; set; }
    }
}