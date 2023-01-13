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
            Customer = 1, 
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
                    case Choice.Customer:
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
            mainMenuText.Add($"{(int)Choice.Customer}: Login as customer");
            mainMenuText.Add($"{(int)Choice.Admin}: Login as admin");
            mainMenuText.Add($"{(int)Choice.Quit}: Quit");
            GUI.PrintMenuText(mainMenuText);
        }

        enum cChoice
        {
            Customer = 1,
            Admin = 2,
            Quit = 3
        }
        cChoice cchoice;

        internal static void cMainMenu()
        {
            bool running = true;
            while (running)
            {
                cMainMenuText();
                int userInput = Input.GetIntFromUser("What would you like to do?");
                Choice choice = (Choice)userInput;
                switch (choice)
                {
                    case Choice.Customer:
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

        public static void cMainMenuText()
        {
            List<string> cmainMenuText = new List<string>();
            cmainMenuText.Add($"{(int)cChoice.Customer}: Login as customer");
            cmainMenuText.Add($"{(int)cChoice.Admin}: Login as admin");
            cmainMenuText.Add($"{(int)cChoice.Quit}: Quit");
            GUI.PrintMenuText(cmainMenuText);
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
