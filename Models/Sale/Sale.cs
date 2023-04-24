using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Sale
{
    public class Sale
    {
        public int SaleID { get; set; }
        public DateTime Date { get; set; }
        public Decimal Total { get; set; }
    }
}