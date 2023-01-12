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
                //Console.WriteLine("");
                int userInput = Input.GetIntFromUser("What would you like to do?");
                Choice choice = (Choice)userInput;
                switch (choice)
                {
                    case Choice.Customer:
                        //customer menu
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
    }
}
