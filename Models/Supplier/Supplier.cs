using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Supplier
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public virtual List<SupplierAddress> Addresses { get; set; }
        public virtual List<SupplierPhone> Phones { get; set; }
    }
}