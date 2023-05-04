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

        public AbstractMenu(List<string> options, int optionsLength)
        {
            Options = options;
            OptionsLength = optionsLength;
        }

        public int Render()
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

        public void PrintHeader()
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
