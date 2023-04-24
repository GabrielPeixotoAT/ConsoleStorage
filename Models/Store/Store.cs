using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Store
{
    public class Store
    {
        public int StoreID { get; set; }
        public string Name { get; set; }
        public StoreAddress Address { get; set; }
        public virtual List<StorePhone> Phones { get; set; }
    }
}