﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class Input
    {
        public static string GetStringInput()
        {
            string input = Console.ReadLine();
            //string result = new String(phrase.Where(c => c != '-' && (c < '0' || c > '9')).ToArray());
            string phrase = string.Concat(input.Where(char.IsLetter));
            string result = char.ToUpper(phrase.First()) + phrase.Substring(1).ToLower();
            return result;
        }

        public static int GetDigitInput(int lowerValue, int higherValue)
        {
            int digit = 0;
            bool chooseNumber = true;
            while (chooseNumber)
            {
                Console.Write("Mata in ett värde mellan " + lowerValue + " och " + higherValue + ": ");
                if (!int.TryParse(Console.ReadLine(), out digit) || digit < lowerValue || digit > higherValue)
                    Console.WriteLine("Error,Du har matat in fel värden");
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
                string digit = string.Concat(input.Where(char.IsNumber));
                if (digit.Length == 10)
                {
                    return digit;
                }
            }
        }
    }
}
