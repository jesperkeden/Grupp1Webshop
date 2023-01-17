using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class Menu
    {
        enum MainChoice { 
            Customer, 
            Admin,
            Quit 
        }
        enum CustomerChoice
        {
            Login,
            CreateNewCustomer,
            GoToPrevious
        }
        enum AdminChoice
        {
            AddProduct,
            UpdateProduct,
            RemoveProduct,
            AddUser,
            EditUser,
            GoToPrevious
        }
        enum CustomerPortalChoice
        {
            Products,
            OrderHistory,
            ShoppingCart,
            EditYourProfile,
            Logout,
        }
        enum ProductPortalChoice
        {
            AllProducts,
            ByCategory,
            ShoppingCart,
            GoToPrevious
        }
        enum ProductCategoryChoice
        {
            Tops,
            Bottoms,
            Shoes,
            Search,
            GoToPrevious
        }

        internal static void MainMenu()
        {
            

            bool running = true;
            while (running)
            {
                MainChoice mainchoice = (MainChoice)MainMenuText();
                switch (mainchoice)
                {
                    case MainChoice.Customer:
                        CustomerMainMenu();
                        break;
                    case MainChoice.Admin:
                        AdminMainMenu();
                        break;
                    case MainChoice.Quit:
                        running = false;
                        return;
                }
            }
        }
        internal static int MainMenuText()
        {
            List<string> mainMenuText = new List<string>();
            mainMenuText.Add($"{MainChoice.Customer}");
            mainMenuText.Add($"{MainChoice.Admin}");
            mainMenuText.Add($"{MainChoice.Quit}");
            int choice = Menu.EditMenu(mainMenuText);
            return choice;
        }
        internal static void CustomerMainMenu()
        {
            bool running = true;
            while (running)
            {

                CustomerChoice customerchoice = (CustomerChoice)CustomerMainMenuText();

                switch (customerchoice)
                {
                    case CustomerChoice.Login:
                        CustomerPortal();
                        break;
                    case CustomerChoice.CreateNewCustomer:
                        User.CreateUser(false);
                        break;
                    case CustomerChoice.GoToPrevious:
                        running = false;
                        return;
                }
            }
        }
        internal static int CustomerMainMenuText()
        {
            Console.Clear();
            string createCustomer = Helpers.ConvertEnumSpacesToString(CustomerChoice.CreateNewCustomer.ToString());
            string previous = Helpers.ConvertEnumSpacesToString(CustomerChoice.GoToPrevious.ToString());

            List<string> customerMainMenuText = new List<string>();
            customerMainMenuText.Add($"Login as customer");
            customerMainMenuText.Add($"{createCustomer}");
            customerMainMenuText.Add($"{previous}");
            int choice = Menu.EditMenu(customerMainMenuText);
            return choice;
        }
        internal static void AdminMainMenu()
        {
            bool running = true;
            while (running)
            {

                AdminChoice adminchoice = (AdminChoice)AdminMenuText();

                switch (adminchoice)
                {
                    case AdminChoice.AddProduct:
                        // addproduct()
                        break;
                    case AdminChoice.UpdateProduct:
                        // updateproduct()
                        break;
                    case AdminChoice.RemoveProduct:
                        // removeproduct()
                        break;
                    case AdminChoice.AddUser:
                        User.CreateUser(true);
                        break;
                    case AdminChoice.EditUser:
                        //User.UpdateUser();
                        break;
                    case AdminChoice.GoToPrevious:
                        running = false;
                        return;
                }
            }
        }
        internal static int AdminMenuText()
        {
            Console.Clear();
            string addProduct = Helpers.ConvertEnumSpacesToString(AdminChoice.AddProduct.ToString());
            string updateProduct = Helpers.ConvertEnumSpacesToString(AdminChoice.UpdateProduct.ToString());
            string removeProduct = Helpers.ConvertEnumSpacesToString(AdminChoice.RemoveProduct.ToString());
            string addUser = Helpers.ConvertEnumSpacesToString(AdminChoice.AddUser.ToString());
            string editUser = Helpers.ConvertEnumSpacesToString(AdminChoice.EditUser.ToString());
            string previous = Helpers.ConvertEnumSpacesToString(AdminChoice.GoToPrevious.ToString());


            List<string> adminMainMenuText = new List<string>();
            adminMainMenuText.Add($"{addProduct}");
            adminMainMenuText.Add($"{updateProduct}");
            adminMainMenuText.Add($"{removeProduct}");
            adminMainMenuText.Add($"{addUser}");
            adminMainMenuText.Add($"{editUser}");
            adminMainMenuText.Add($"{previous}");
            int choice = Menu.EditMenu(adminMainMenuText);
            return choice;
        }
        internal static void CustomerPortal()
        {
            bool running = true;
            while (running)
            {

                CustomerPortalChoice customerportalchoice = (CustomerPortalChoice)CustomerPortalText();

                switch (customerportalchoice)
                {
                    case CustomerPortalChoice.Products:
                        ProductPortal();
                        break;
                    case CustomerPortalChoice.EditYourProfile:
                        // �ndra uppgifter(samma metod som admin/ edituser, v�ljer currentuser)
                        break;
                    case CustomerPortalChoice.OrderHistory:
                        // orderhistory()
                        break;
                    case CustomerPortalChoice.ShoppingCart:
                        // seeShoppingCart()
                        break;
                    case CustomerPortalChoice.Logout:
                        running = false;
                        //logout metod, confirm y/n f�r att logga ut och s�nd tillbaka till mainmenu
                        return;
                }
            }
        }
        internal static int CustomerPortalText()
        {
            Console.Clear();
            string shoppingCart = Helpers.ConvertEnumSpacesToString(CustomerPortalChoice.ShoppingCart.ToString());
            string orderHistory = Helpers.ConvertEnumSpacesToString(CustomerPortalChoice.OrderHistory.ToString());
            string editCredentials = Helpers.ConvertEnumSpacesToString(CustomerPortalChoice.EditYourProfile.ToString());
            string logout = Helpers.ConvertEnumSpacesToString(CustomerPortalChoice.Logout.ToString());

            List<string> CustomerPortalText = new List<string>();
            CustomerPortalText.Add($"{CustomerPortalChoice.Products}");
            CustomerPortalText.Add($"{shoppingCart}");
            CustomerPortalText.Add($"{orderHistory}");
            CustomerPortalText.Add($"{editCredentials}");
            CustomerPortalText.Add($"{logout}");
            int choice = Menu.EditMenu(CustomerPortalText);
            return choice;
        }
        internal static void ProductPortal()
        {
            bool running = true;
            while (running)
            {

                ProductPortalChoice productportalchoice = (ProductPortalChoice)ProductPortalText();

                switch (productportalchoice)
                {
                    case ProductPortalChoice.AllProducts:
                        // lista alla produkter()
                        break;
                    case ProductPortalChoice.ByCategory:
                        ProductCategory();
                        break;
                    case ProductPortalChoice.ShoppingCart:
                        // orderhistory()
                        break;
                    case ProductPortalChoice.GoToPrevious:
                        running = false;
                        return;
                }
            }
        }
        internal static int ProductPortalText()
        {
            Console.Clear();
            string allProducts = Helpers.ConvertEnumSpacesToString(ProductPortalChoice.AllProducts.ToString());
            string byCategory = Helpers.ConvertEnumSpacesToString(ProductPortalChoice.ByCategory.ToString());
            string shoppingCart = Helpers.ConvertEnumSpacesToString(ProductPortalChoice.ShoppingCart.ToString());
            string previous = Helpers.ConvertEnumSpacesToString(ProductPortalChoice.GoToPrevious.ToString());

            List<string> ProductPortalText = new List<string>();
            ProductPortalText.Add($"{allProducts}");
            ProductPortalText.Add($"{byCategory}");
            ProductPortalText.Add($"{shoppingCart}");
            ProductPortalText.Add($"{previous}");
            int choice = Menu.EditMenu(ProductPortalText);
            return choice;
        }
        internal static void ProductCategory()
        {
            bool running = true;
            while (running)
            {

                ProductCategoryChoice productcategorychoice = (ProductCategoryChoice)ProductCategoryText();

                switch (productcategorychoice)
                {
                    case ProductCategoryChoice.Tops:
                        // visa alla toppar()
                        break;
                    case ProductCategoryChoice.Bottoms:
                        // visa alla bottoms()
                        break;
                    case ProductCategoryChoice.Shoes:
                        // visa alla skor()
                        break;
                    case ProductCategoryChoice.Search:
                        // fritexts�kning()
                        break;
                    case ProductCategoryChoice.GoToPrevious:
                        running = false;
                        return;
                }
            }
        }
        internal static int ProductCategoryText()
        {
            Console.Clear();
            string previous = Helpers.ConvertEnumSpacesToString(ProductCategoryChoice.GoToPrevious.ToString());

            List<string> ProductCategoryText = new List<string>();
            ProductCategoryText.Add($"{ProductCategoryChoice.Tops}");
            ProductCategoryText.Add($"{ProductCategoryChoice.Bottoms}");
            ProductCategoryText.Add($"{ProductCategoryChoice.Shoes}");
            ProductCategoryText.Add($"{ProductCategoryChoice.Search}");
            ProductCategoryText.Add($"{previous}");
            int choice = Menu.EditMenu(ProductCategoryText);
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

            Console.Clear();
            return index;
        }
        internal static int EditMenu(List<string> firstCollumn, List<string> secondCollumn, int firstColumnPositionX, int secondColumnPositionX, int positionY, int index)
        {
            Console.Clear();

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


//Kund meny
//produktsidan(meny)
//�ndra uppgifter(samma metod som admin/edituser, v�ljer currentuser)
//se orderhistorik
//se kundkorg
//logout metod, confirm y/n f�r att logga ut och s�nd tillbaka till mainmenu


//produktsida > alla produkter
//se kundkorg
//S�k > fritext s�ka
//Kategorier > ny meny med kategorier (tr�ja, byxa, skor)
////tr�ja
////byxa
////skor