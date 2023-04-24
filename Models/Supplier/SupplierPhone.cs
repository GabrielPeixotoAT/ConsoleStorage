using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Supplier
{
    public class SupplierPhone
    {
        public int SupplierPhoneID { get; set; }
        public string Number { get; set; }
        public Supplier Supplier { get; set; }
    }
}