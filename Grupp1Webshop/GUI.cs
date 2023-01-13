using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class GUI
    {
        public static void PrintMenuText(List<string> text)
        {
            foreach (string line in text)
                Console.WriteLine(line);
        }

        internal static void PrintCreateMenu()
        {

        }

        internal static void PrintMenu(string header, int positionX, int PositionY, int index, List<string> text)
        {
            for (int i = 0; i < text.Count; i++)
            {
                Console.SetCursorPosition(positionX, PositionY + i);
                if (i == index)
                    Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(text[i]);
                Console.ResetColor();
            }
        }
    }
}
