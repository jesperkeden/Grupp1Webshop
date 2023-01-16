using System;
using System.Collections.Generic;
using System.Linq;
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

        internal static List<string> AddMenuChoicesForProp(List<string> propNameList)
        {
            propNameList.Insert(0, "Save All");
            propNameList.Add("Cancel");
            return propNameList;
        }

        internal static List<string> AddMenuChoicesForValues(List<string> valueList)
        {
            valueList.Insert(0, "");
            return valueList;
        }

        internal static bool ColumnValueNotEmpty(List<string> secondColumn)
        {
            foreach (var item in secondColumn)
            {
                if (item == "Empty") return true;
            }
            return false;
        }
    }
}
