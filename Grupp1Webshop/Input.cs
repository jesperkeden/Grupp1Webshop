using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class Input
    {
        internal static string GetStringFirstUpperInput(int positionX)
        {
            string phrase = GetStringLowerInput(positionX);
            return char.ToUpper(phrase.First()) + phrase.Substring(1);
        }

        internal static int GetDigitInput(int lowerValue, int higherValue, int positionX)
        {
            int digit = 0;
            string prompt = "Input a number between " + lowerValue + " and " + higherValue + ": ";
            Console.Write(prompt);
            while (!int.TryParse(GetStringWithMaxLength(positionX + prompt.Length), out digit) || digit < lowerValue || digit > higherValue) ;
            return digit;
        }

        public static string GetPhonenumberInput(int positionX)
        {
            string number = "07";
            Console.Write(number);
            while (number.Count() != 10)
                number = "07" + string.Concat(GetStringWithMaxLength(positionX + 2).Where(char.IsNumber));
            return number;
        }

        internal static string GetBoolAsString(int positionX)
        {
            string getBool = "";
            while(getBool != "True" && getBool != "False")
            {
                getBool = GetStringFirstUpperInput(positionX);
            }
            return getBool;
        }

        internal static string GetStringLowerInput(int positionX)
        {
            string lowerString = "";
            while (lowerString.Length == 0 || lowerString.Any(x => !char.IsLetter(x)))
                lowerString = GetStringWithMaxLength(positionX);
            return string.Concat(lowerString.ToLower());
        }

        internal static string GetIntAsStringInput(int lowerValue, int higherValue, int positionX)
        {
            return GetDigitInput(lowerValue, higherValue, positionX).ToString();
        }

        internal static string GetStringWithMaxLength(int startPositionX)
        {
            int maxLength = 66;
            ConsoleKeyInfo key;
            string savedInput = "";
            Console.CursorLeft = startPositionX;

            while (true)
            {
                GUI.OverWriteWithSpaces(savedInput.Length + 1, startPositionX + savedInput.Length);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter) break;
                else if (key.Key == ConsoleKey.Escape) return "Empty";
                else if (key.Key == ConsoleKey.Backspace && savedInput.Length != 0) savedInput = savedInput.Remove(savedInput.Length - 1);
                else if (savedInput.Length >= (maxLength - startPositionX));
                else if (Char.IsLetterOrDigit(key.KeyChar) || Char.IsPunctuation(key.KeyChar) || Char.IsSeparator(key.KeyChar))
                    savedInput += key.KeyChar.ToString();
            }
            GUI.OverWriteWithSpaces(savedInput.Length, startPositionX);
            return savedInput;
        }

        internal static string GetDoubleAsStringInput(int positionX)
        {
            return GetDoubleInput(0d, positionX).ToString();
        }
        internal static double GetDoubleInput(double lowerValue, int positionX)
        {
            double value = 0;
            while (!double.TryParse(GetStringWithMaxLength(positionX), out value) || value < lowerValue) ;
            return value;
        }

        internal static string GetDescriptionInput(string description)
        {
            return GetStringWithMaxLengthForDescription(description);
        }

        internal static string GetStringWithMaxLengthForDescription(string savedInput)
        {
            string oldString = savedInput;
            ConsoleKeyInfo key;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter = Save\t Escape = Cancel\n");
                Console.Write(savedInput);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter) break;
                else if (key.Key == ConsoleKey.Escape) return oldString;
                else if (key.Key == ConsoleKey.Backspace && savedInput.Length != 0) savedInput = savedInput.Remove(savedInput.Length - 1);
                else if (Char.IsLetterOrDigit(key.KeyChar) || Char.IsPunctuation(key.KeyChar) || Char.IsSeparator(key.KeyChar))
                    savedInput += key.KeyChar.ToString();
            }
            return savedInput;
        }

        internal static string GetStringFirstLeterInEachWordUpperInput(int positionX)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(GetStringWithMaxLength(positionX).ToLower());
        }
    }
}
