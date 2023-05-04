﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStorage.Menus.ConcreteMenus
{
    public class Main : AbstractMenu
    {
        public Main(List<string> options, int optionsLength)
         : base (options, optionsLength)
        {
            Options.Add("Exit");
        }
    }
}
