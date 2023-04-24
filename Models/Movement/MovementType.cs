using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Models.Movement
{
    public class MovementType
    {
        public int MovementTypeID { get; set; }
        public string Description { get; set; }
        public virtual List<Movement> Movements { get; set; }
    }
}