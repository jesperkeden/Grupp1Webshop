using System;
using System.Collections.Generic;
using System.Linq;
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

        internal static int GetLengthOfStringInList(List<string> listString)
        {
            return (listString.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur).Length + 1);
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

        internal static List<string> GetPropertyNames(PropertyInfo[] properties, int startFrom)
        {
            List<string> propNameList = new List<string>();
            for (int i = startFrom; i < (properties.Length); i++)
                propNameList.Add(properties[i].Name);
            return propNameList;
        }

        internal static List<string> GetNewLinesInString(string description)
        {
            return description.Split('.').ToList();
        }
    }
}
