using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class Menu
    {
        enum MainChoice { 
            Login, 
            CreateUser,
            RandomQuerys,
            Quit 
        }
        enum UserChoice
        {
            ProductMenu,
            EditYourProfile,
            AdminMenu,
            LogOut
        }
        enum AdminChoice
        {
            AddSupplier,
            UpdateSupplier,
            RemoveSupplier,
            AddProduct,
            UpdateProduct,
            RemoveProduct,
            AddUser,
            EditUser,
            RemoveUser,
            GoToPrevious
        }
        enum CustomerPortalChoice
        {
            Products,
            ShoppingCart,
            OrderHistory,
            GoToPrevious,
        }
        enum ProductPortalChoice
        {
            AllProducts,
            ByCategory,
            ShoppingCart,
            GoToPrevious
        }


        internal static void MainMenu()
        {
            

            bool running = true;
            while (running)
            {
                MainChoice mainChoice = (MainChoice)MainMenuText();
                switch (mainChoice)
                {
                    case MainChoice.Login:
                        Security.UserLogin();
                        break;
                    case MainChoice.CreateUser:
                        User.CreateUser(false);
                        break;
                    case MainChoice.RandomQuerys:
                        Helpers.RandomQuerys();
                        break;
                    case MainChoice.Quit:
                        running = false;
                        break;
                }
            }
        }
        internal static int MainMenuText()
        {
            Console.Clear();
            Helpers.ShowSelectedProducts();

            List<string> mainMenuText = new List<string>();
            mainMenuText.Add($"{MainChoice.Login}");
            mainMenuText.Add($"{Helpers.ConvertEnumSpacesToString(MainChoice.CreateUser.ToString())}");
            mainMenuText.Add($"{Helpers.ConvertEnumSpacesToString(MainChoice.RandomQuerys.ToString())}");
            mainMenuText.Add($"{MainChoice.Quit}");

            return Menu.EditMenu(mainMenuText);
        }
        internal static void UserMainMenu(User user)
        {
            bool running = true;
            while (running)
            {

                UserChoice userChoice = (UserChoice)UserMainMenu();

                switch (userChoice)
                {
                    case UserChoice.ProductMenu:
                        CustomerPortal(user);
                        break;
                    case UserChoice.EditYourProfile:
                        User.EditUser(Querys.QGetSelectedUser(user.Id), Security.CheckAdminPrivileges(user));
                        break;
                    case UserChoice.AdminMenu:
                        if (Security.CheckAdminPrivileges(user))
                            Menu.AdminMainMenu();
                        break;
                    case UserChoice.LogOut:
                        running = false;
                        break;
                }
            }
        }
        internal static int UserMainMenu()
        {
            Console.Clear();

            List<string> customerMainMenuText = new List<string>
            {
                $"{Helpers.ConvertEnumSpacesToString(UserChoice.ProductMenu.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(UserChoice.EditYourProfile.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(UserChoice.AdminMenu.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(UserChoice.LogOut.ToString())}"
            };
            return Menu.EditMenu(customerMainMenuText);
        }
        internal static void AdminMainMenu()
        {
            bool running = true;
            while (running)
            {

                AdminChoice adminchoice = (AdminChoice)AdminMenuText();

                switch (adminchoice)
                {
                    case AdminChoice.AddSupplier:
                        Supplier.CreateSupplier();
                        break;
                    case AdminChoice.UpdateSupplier:
                        Supplier.UpdateSupplier();
                        break;
                    case AdminChoice.RemoveSupplier:
                        Supplier.RemoveSupplier();
                        break;
                    case AdminChoice.AddProduct:
                        Product.CreateProduct();
                        break;
                    case AdminChoice.UpdateProduct:
                        Product.UpdateProduct();
                        break;
                    case AdminChoice.RemoveProduct:
                        Product.RemoveProduct();
                        break;
                    case AdminChoice.AddUser:
                        User.CreateUser(true);
                        break;
                    case AdminChoice.EditUser:
                        User.UpdateUser(true);
                        break;
                    case AdminChoice.RemoveUser:
                        User.RemoveUser();
                        break;
                    case AdminChoice.GoToPrevious:
                        running = false;
                        break;
                }
            }
        }
        internal static int AdminMenuText()
        {
            Console.Clear();

            List<string> adminMainMenuText = new List<string>
            {
                $"{Helpers.ConvertEnumSpacesToString(AdminChoice.AddSupplier.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(AdminChoice.UpdateSupplier.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(AdminChoice.RemoveSupplier.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(AdminChoice.AddProduct.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(AdminChoice.UpdateProduct.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(AdminChoice.RemoveProduct.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(AdminChoice.AddUser.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(AdminChoice.EditUser.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(AdminChoice.RemoveUser.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(AdminChoice.GoToPrevious.ToString())}"
            };
            return Menu.EditMenu(adminMainMenuText);
        }
        internal static void CustomerPortal(User user)
        {
            List<Product> basket = new List<Product>();
            bool running = true;
            while (running)
            {

                CustomerPortalChoice customerportalchoice = (CustomerPortalChoice)CustomerPortalText();

                switch (customerportalchoice)
                {
                    case CustomerPortalChoice.Products:
                        basket = ProductPortal(user, basket);
                        break;
                    case CustomerPortalChoice.ShoppingCart:
                        ShowbasketMenu(basket, user);
                        break;
                    case CustomerPortalChoice.OrderHistory:
                        Order.OrderHistory(user);
                        break;
                    case CustomerPortalChoice.GoToPrevious:
                        running = false;
                        break;
                }
            }
        }
        internal static int CustomerPortalText()
        {
            Console.Clear();

            List<string> CustomerPortalText = new List<string>
            {
                $"{CustomerPortalChoice.Products}",
                $"{Helpers.ConvertEnumSpacesToString(CustomerPortalChoice.ShoppingCart.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(CustomerPortalChoice.OrderHistory.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(CustomerPortalChoice.GoToPrevious.ToString())}"
            };
            return Menu.EditMenu(CustomerPortalText);
        }
        internal static List<Product> ProductPortal(User user, List<Product> basket)
        {
            bool running = true;
            while (running)
            {

                ProductPortalChoice productportalchoice = (ProductPortalChoice)ProductPortalText();

                switch (productportalchoice)
                {
                    case ProductPortalChoice.AllProducts:
                        basket = Helpers.ShowAllProducts(basket);
                        break;
                    case ProductPortalChoice.ByCategory:
                        basket = Helpers.ShowCategoryProducts(basket);
                        break;
                    case ProductPortalChoice.ShoppingCart:
                        basket = ShowbasketMenu(basket, user);
                        break;
                    case ProductPortalChoice.GoToPrevious:
                        running = false;
                        break;
                }
            }
            return basket;
        }
        internal static int ProductPortalText()
        {
            Console.Clear();

            List<string> ProductPortalText = new List<string>
            {
                $"{Helpers.ConvertEnumSpacesToString(ProductPortalChoice.AllProducts.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(ProductPortalChoice.ByCategory.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(ProductPortalChoice.ShoppingCart.ToString())}",
                $"{Helpers.ConvertEnumSpacesToString(ProductPortalChoice.GoToPrevious.ToString())}"
            };
            return Menu.EditMenu(ProductPortalText);
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

        internal static int ProductMenu(List<Product> products, string info , int index, bool canSearch)
        {
            List<string> list = new List<string>();
            int positionX = 3;
            int middle = 20;
            int writeFrom = index;
            int writeTo = index + 20;

            foreach (Product product in products)
            {
                list.Add(product.Name.PadRight(40) + "Price: " + product.UnitPrice.ToString().PadRight(7) + "Color: " + product.Color.PadRight(18) + "Size: " + product.Size.PadRight(4));
            }

            Console.CursorVisible = false;
            ConsoleKeyInfo keyPressed;
            do
            {
                string description = products[index].Description;
                List<string> descriptionList = Helpers.GetNewLinesInString(description);
                int decLength = descriptionList.Count();

                string theOneProduct = products[index].Name.PadRight(40) + "Price: " + products[index].UnitPrice.ToString().PadRight(7) + "Color: " + products[index].Color.PadRight(18) + "Size: " + products[index].Size.PadRight(4) + "In Stock: " + products[index].Quantity.ToString().PadRight(4);
                Console.Clear();
                GUI.PrintProductMenu(positionX, middle, index, list, theOneProduct, info , writeFrom, writeTo, decLength);

                GUI.MessageBox("description", 3, index + 21, descriptionList);

                keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.DownArrow && index != list.Count - 1)
                {
                    index++;
                    writeFrom++;
                    writeTo++;

                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && index >= 1)
                {
                    index--;
                    writeFrom--;
                    writeTo--;
                }
                else if (keyPressed.Key == ConsoleKey.B || keyPressed.Key == ConsoleKey.Escape) return -1;
                else if (keyPressed.Key == ConsoleKey.S && canSearch) return -2;
            } while (keyPressed.Key != ConsoleKey.Enter);
            Console.CursorVisible = true;

            return index;
        }

        internal static string EditDescriptionValue(string description)
        {
            List<string> list = new List<string>();
            Console.Clear();
            list.Add("Yes");
            list.Add("No");
            Console.WriteLine("Want to edit description?");
            GUI.MessageBox("Description", 10, 2, Helpers.GetNewLinesInString(description));
            int edit = EditMenu(list);
            if (edit == 0) return Input.GetDescriptionInput(description);
            return description;
        }

        internal static string PickSupplierFromMenu()
        {
            var suppliersList = Helpers.GetSuppliersFromDb();
            Console.Clear();
            return suppliersList[Menu.EditMenu(Helpers.ConvertClassListToStringList(suppliersList))].Name;
        }

        internal static List<Product> ShowbasketMenu(List<Product> basket, User user)
        {
            Order order = new Order();
            List<string> basketMenuList = new List<string>();
            basketMenuList.Add("Product List in basket");
            basketMenuList.Add("Pay Order");
            basketMenuList.Add("Back");

            int index = 0;
            bool productMenu = false;
            Console.Clear();
            do
            {
                while (productMenu)
                {
                    if (basket.Count == 0)
                        break;
                    index = Menu.ProductMenu(basket, "Enter = Remove product\t B = Back", index, false);
                    if (index == -1) 
                    { 
                        Console.Clear();
                        break;
                    }

                    basket.RemoveAt(index);
                    index--;
                    if (index < 0)
                        index++;
                    Console.Clear();
                }

                List<string> basketInfo = new List<string>();

                basketInfo.Add("Products in basket:".PadRight(30) + basket.Count.ToString());
                if (basket.Count != 0)
                {
                    double productCost = 0d;
                    for (int i = 0; i < basket.Count; i++)
                    {
                        productCost += basket[i].UnitPrice;
                        order.ShippingCost += 10d;
                    }
                    order.TotalCost = productCost + order.ShippingCost;
                    order.PaymenthMethod = "Visa";
                    order.Shipping = "Postnord";
                    basketInfo.Add("Price of products in basket:".PadRight(30) + productCost + " kr");
                    basketInfo.Add("Shipping:".PadRight(30) + order.Shipping);
                    basketInfo.Add("Shipping Cost:".PadRight(30) + order.ShippingCost + " kr");
                    basketInfo.Add("Paymenth method:".PadRight(30) + order.PaymenthMethod);
                    basketInfo.Add("Total Cost:".PadRight(30) + order.TotalCost + " kr");
                }

                for (int i = 0; i < basketInfo.Count; i++)
                {
                    GUI.WriteStringAtLocation(basketInfo[i], 50, 2 + i);
                }
                index = Menu.EditMenu(basketMenuList);
                Console.Clear();
                if (index == 0) productMenu = true;
                else if (index == 1 && basket.Count != 0) Order.Receipt(Order.PayOrder(user, basket, order), basketInfo);
                if (order.HasPayed)
                {
                    basket.Clear();
                    break;
                }
            } while (index != basketMenuList.Count - 1);
            return basket;
        }
    }
}