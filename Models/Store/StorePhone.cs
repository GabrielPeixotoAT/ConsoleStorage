using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Store
{
    public class StorePhone
    {
        public int StorePhoneID { get; set; }
        public string Number { get; set; }
        public Store Store { get; set; }
    }
}