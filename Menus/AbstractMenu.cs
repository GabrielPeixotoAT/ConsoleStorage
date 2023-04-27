using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStorage.Menus
{
    public abstract class AbstractMenu : IGUI
    {
        public List<string> Options;
        public int OptionsLength;

        public abstract int Render();
        public abstract void PrintHeader();
    }
}
