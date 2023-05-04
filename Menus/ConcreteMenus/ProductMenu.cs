using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStorage.Menus.ConcreteMenus
{
    public class ProductMenu : AbstractMenu
    {
        public ProductMenu(List<string> options, int optionsLength)
         : base (options, optionsLength)
        {
            Options.Add("Back");
        }
    }
}