using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Sale
{
    public class Devolution
    {
        public int DevolutionID { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
        public virtual Product.Product Product { get; set; }
        public virtual Sale Sale { get; set; }
    }
}