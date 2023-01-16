using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class Input
    {
        public static string GetStringFirstUpperInput(int positionX)
        {
            string phrase = GetStringLowerInput(positionX);
            return char.ToUpper(phrase.First()) + phrase.Substring(1);
        }

        public static int GetDigitInput(int lowerValue, int higherValue, int positionX)
        {
            int digit = 0;
            string prompt = "Input a number between " + lowerValue + " and " + higherValue + ": ";
            Console.Write(prompt);
            while (!int.TryParse(GetStringWithMaxLength(positionX + prompt.Length), out digit) || digit < lowerValue || digit > higherValue) ;
            return digit;
        }

        public static int GetIntFromUser(string prompt)
        {
            Console.WriteLine(prompt);

            int number = 0;
            while (int.TryParse(Console.ReadLine(), out number) is false)
            {
                Console.WriteLine("Wrong input, try again!");
            }
            return number;
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
                //GUI.OverWriteWithSpaces(getBool.Length, positionX);
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
            int maxLength = 84;
            ConsoleKeyInfo key;
            string savedInput = "";
            Console.CursorLeft = startPositionX;

            while (true)
            {
                GUI.OverWriteWithSpaces(savedInput.Length, startPositionX + savedInput.Length);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key == ConsoleKey.Backspace && savedInput.Length != 0) savedInput = savedInput.Remove(savedInput.Length - 1);
                else if (savedInput.Length >= (maxLength - startPositionX))
                {
                    GUI.OverWriteWithSpaces(savedInput.Length + 1, startPositionX);
                    savedInput = "";
                }
                else if (Char.IsLetter(key.KeyChar) || (Char.IsDigit(key.KeyChar)))
                    savedInput += key.KeyChar.ToString();
            }
            GUI.OverWriteWithSpaces(savedInput.Length, startPositionX);
            return savedInput;
        }
    }
}
