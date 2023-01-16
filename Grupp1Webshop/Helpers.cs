using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class Helpers
    {

        public static string ConvertEnumSpacesToString(string str)
        {
            return string.Concat(str.Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
        }

        internal static int GetSecondCollumnPositionX(List<string> firstCollumn)
        {
            return (firstCollumn.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur).Length + 1);
        }
    }
}
