using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStorage.Menus
{
    public interface IGUI
    {
        int Render();
        void PrintHeader();
    }
}
