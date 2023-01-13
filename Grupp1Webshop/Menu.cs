using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class Menu
    {
        enum Choice { 
            CustomerPankaka = 1, 
            Admin = 2, 
            Quit = 3 
        }
        Choice choice;

        internal static void MainMenu()
        {
            

            bool running = true;
            while (running)
            {
                MainMenuText();
                int userInput = Input.GetIntFromUser("What would you like to do?");
                Choice choice = (Choice)userInput;
                switch (choice)
                {
                    case Choice.CustomerPankaka:
                        cMainMenu();
                        break;
                    case Choice.Admin:
                        // admin menu
                        break;
                    case Choice.Quit:
                        running = false;
                        return;
                }
            }
        }

        public static void MainMenuText()
        {
            List<string> mainMenuText = new List<string>();
            string newString = Menu.getSpaces(Choice.CustomerPankaka.ToString());
            mainMenuText.Add($"Login as {newString}");
            mainMenuText.Add($"{(int)Choice.Admin}: Login as admin");
            mainMenuText.Add($"{(int)Choice.Quit}: Quit");
            GUI.PrintMenuText(mainMenuText);
        }

        enum cChoice
        {
            Customer,
            Admin,
            Quit
        }
        cChoice cchoice;

        internal static void cMainMenu()
        {
            bool running = true;
            while (running)
            {

                Choice choice = (Choice)cMainMenuText();
                switch (choice)
                {
                    case Choice.CustomerPankaka:
                        //browse
                        break;
                    case Choice.Admin:
                        // admin menu
                        break;
                    case Choice.Quit:
                        running = false;
                        return;
                }
            }
        }

        public static string getSpaces(string str)
        {
            return string.Concat(str.Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
        }

        public static int cMainMenuText()
        {
            List<string> cmainMenuText = new List<string>();
            cmainMenuText.Add($"Login as {cChoice.Customer}");
            cmainMenuText.Add($"{(int)cChoice.Admin}: Login as admin");
            cmainMenuText.Add($"{(int)cChoice.Quit}: Quit");
            int choice = Menu.EditMenu(cmainMenuText);
            return choice;
        }

        internal static int EditMenu(List<string> firstCollumn)
        {
            int firstColumnPositionX = 3;
            int index = 0;
            int positionY = 2;

            Console.CursorVisible = false;
            ConsoleKeyInfo keyPressed;
            do
            {
                GUI.PrintMenu("header", firstColumnPositionX, positionY, index, firstCollumn);

                keyPressed = Console.ReadKey();
                if
                    (keyPressed.Key == ConsoleKey.DownArrow && index != firstCollumn.Count - 1) index++;
                else if
                    (keyPressed.Key == ConsoleKey.UpArrow && index >= 1) index--;
            } while (keyPressed.Key != ConsoleKey.Enter);
            Console.CursorVisible = true;

            return index;
        }

        internal static int EditMenu(List<string> firstCollumn, List<string> secondCollumn)
        {
            string longestString = firstCollumn.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
            int firstColumnPositionX = 3;
            int secondColumnPositionX = (longestString.Length + firstColumnPositionX + 1);
            int index = 0;
            int positionY = 2;

            Console.CursorVisible = false;
            ConsoleKeyInfo keyPressed;
            do
            {
                GUI.PrintMenu("header", firstColumnPositionX, positionY, index, firstCollumn);
                GUI.PrintMenu("header", secondColumnPositionX, positionY, index, secondCollumn);

                keyPressed = Console.ReadKey();
                if 
                    (keyPressed.Key == ConsoleKey.DownArrow && index != firstCollumn.Count - 1) index++;
                else if 
                    (keyPressed.Key == ConsoleKey.UpArrow && index >= 1) index--;
            } while (keyPressed.Key != ConsoleKey.Enter);
            Console.CursorVisible = true;

            return index;
        }

        internal static int ProductMenu(List<string> list)
        {
            int positionX = 3;
            int index = 0;
            int middle = 10;

            Console.CursorVisible = false;
            ConsoleKeyInfo keyPressed;
            do
            {
                Console.Clear();
                GUI.PrintMenu("header", positionX, middle, index, list);

                keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.DownArrow && index != list.Count - 1)
                {
                    index++;
                    middle--;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && index >= 1)
                {
                    index--;
                    middle++;
                }
            } while (keyPressed.Key != ConsoleKey.Enter);
            Console.CursorVisible = true;

            return index;
        }
    }
}
