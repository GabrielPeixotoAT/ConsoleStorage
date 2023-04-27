using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStorage.Menus.ConcreteMenus
{
    public class Main : AbstractMenu
    {
        public Main(List<string> options, int optionsLength)
        {
            Options = options;
            Options.Add("Exit");
            OptionsLength = optionsLength;
        }

        public override int Render()
        {
            int index = 0;
            ConsoleKeyInfo aws;

            List<string> opts = FormatOptions();

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;

                PrintHeader();

                Console.WriteLine("OPTIONS: \n");

                for (int i = 0; i < opts.Count; i++)
                {
                    if (i == index)
                        SelectedOption();
                    else
                        NonSelectedOption();

                    Console.WriteLine(opts[i]);
                }

                aws = Console.ReadKey();

                switch (aws.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (index < opts.Count - 1)
                            index++;
                        break;
                }
            } while (aws.Key != ConsoleKey.Enter);

            return index;
        }

        public override void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine(ApplicationInfo.Header);
        }

        List<string> FormatOptions()
        {
            List<string> sb = new List<string>();

            foreach (string option in Options)
            {
                string optionUpper = option.ToUpper();

                for (int i = optionUpper.Length; i < OptionsLength; i++)
                {
                    optionUpper += " ";
                }

                sb.Add($" {optionUpper}");
            }

            return sb;
        }

        void SelectedOption()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        void NonSelectedOption()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
