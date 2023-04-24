using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Movement
{
    public class Movement
    {
        public int MovementID { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
        public MovementType MovementType { get; set; }
        public Product.Product Product { get; set; }
        public Store.Store Origin { get; set; }
        public Store.Store Destiny { get; set; }
    }
}