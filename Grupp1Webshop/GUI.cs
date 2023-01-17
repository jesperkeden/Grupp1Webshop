using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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

        internal static void MessageBox(string header, int positionX, int PositionY, List<string> message)
        {
            int sizeX = Helpers.GetLengthOfStringInList(message) + 3;
            if (sizeX < 13) sizeX = 13;

            Console.SetCursorPosition(positionX, PositionY);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('┌' + header + new String('─', (sizeX - 2 - header.Length)) + '┐');
            for (int i = 0; i < message.Count; i++)
            {
                Console.SetCursorPosition(positionX, PositionY + 1 + i);
                Console.Write('│');

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" " + message[i] + new String(' ', sizeX - message[i].Length - 3));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('│');
            }
            Console.SetCursorPosition(positionX, PositionY + message.Count + 1);
            Console.Write('└' + new String('─', sizeX - 2) + '┘');

            Console.ResetColor();
        }

        internal static void OverWriteWithSpaces(int length, int positionX, int positionY)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(new string(' ', length));
            Console.SetCursorPosition(positionX, positionY);
        }

        internal static void OverWriteWithSpaces(int length, int positionX)
        {
            //Console.CursorTop--;
            Console.CursorLeft = positionX;
            Console.Write(new string(' ', length));
            Console.CursorLeft = positionX;
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

        internal static void PrintMenuWithNumbers(string header, int positionX, int PositionY, int index, List<string> text)
        {
            for (int i = 0; i < text.Count; i++)
            {
                Console.SetCursorPosition(positionX, PositionY + i);
                if (i == index)
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i + 1 + " " + text[i]);
                Console.ResetColor();
            }
        }
    }
}
