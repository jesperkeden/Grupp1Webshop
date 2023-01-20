using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
                int maxLengthInString = 80;
                string textItem = text[i].Length > maxLengthInString ? text[i].Substring(0, maxLengthInString) + "....." : text[i];
                Console.SetCursorPosition(positionX, PositionY + i);
                if (i == index)
                    Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(textItem);
                Console.ResetColor();
            }
        }

        internal static void PrintProductMenu(int positionX, int positionY, int index, List<string> text, string theOneProduct, string info, int writeFrom, int writeTo, int descLength)
        {
            Console.SetCursorPosition(2, 1 + index);
            Console.Write(info);
            for (int i = 0; i < text.Count; i++)
            {
                Console.SetCursorPosition(positionX, positionY + i);
                if (i == index)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(theOneProduct);
                    Console.ResetColor();
                    positionY += descLength + 2;
                }
                else if (writeFrom <= i + 15 && writeTo >= i + 15)
                {
                    Console.WriteLine(text[i]);
                }
                //Console.WriteLine(text[i] + " " + i);
                //Console.ResetColor();
            }
            
            Console.SetCursorPosition(0, index);
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

        internal static void WriteString(string v)
        {
            Console.WriteLine(v);
        }

        internal static void WriteStringAtLocation(string v, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(v);
        }
    }
}
