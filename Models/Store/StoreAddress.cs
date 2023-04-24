using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Store
{
    public class StoreAddress
    {
        public int StoreAddressID { get; set; }
        public string UF { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public virtual Store Store { get; set; }
    }
}