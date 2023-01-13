using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class Input
    {
        public static string GetStringFirstUpperInput()
        {
            string phrase = GetStringLowerInput();
            string result = char.ToUpper(phrase.First()) + phrase.Substring(1);
            return result;
        }

        public static int GetDigitInput(int lowerValue, int higherValue)
        {
            int digit = 0;
            bool chooseNumber = true;
            Console.Write("Input a value between " + lowerValue + " and " + higherValue + ": ");
            while (chooseNumber)
            {
                if (!int.TryParse(Console.ReadLine(), out digit) || digit < lowerValue || digit > higherValue) ;
                //Console.WriteLine("Error,Du har matat in fel värden");
                else
                    chooseNumber = false;
            }
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

        public static string GetPhonenumberInput()
        {
            while (true)
            {
                string input = "07";
                Console.Write(input);
                input += Console.ReadLine();
                string number = string.Concat(input.Where(char.IsNumber));
                if (number.Length == 10)
                {
                    return number;
                }
            }
        }

        internal static string getBoolAsString()
        {
            string getBool = "";
            while(getBool != "True" && getBool != "False")
            {
                getBool = GetStringFirstUpperInput();
            }
            return getBool;
        }

        internal static string GetStringLowerInput()
        {
            string input = Console.ReadLine();
            //string result = new String(phrase.Where(c => c != '-' && (c < '0' || c > '9')).ToArray());
            string phrase = string.Concat(input.Where(char.IsLetter)).ToLower();
            return phrase;
        }

        internal static string GetIntAsStringInput(int lowerValue, int higherValue)
        {
            return GetDigitInput(lowerValue, higherValue).ToString();
        }
    }
}
