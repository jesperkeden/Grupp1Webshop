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
    }
}
