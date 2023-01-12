using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
