using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class jesper
    {
        enum Choice { Customer = 1, Admin = 2, Quit = 3 }
        Choice choice;

        internal static void MainMenu()
        {
            bool running = true;
            while (running)
            {
                Menu();
                Console.WriteLine("");
                int userInput = GetIntFromUser("What would you like to do?");
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
        public static void Menu()
        {
            Console.WriteLine($"{(int)Choice.Customer}: Login as customer");
            Console.WriteLine($"{(int)Choice.Admin}: Login as admin");
            Console.WriteLine($"{(int)Choice.Quit}: Quit");
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
    }
}
