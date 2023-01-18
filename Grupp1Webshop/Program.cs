using Grupp1Webshop.Data;
using Grupp1Webshop.Models;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Grupp1Webshop
{
    internal class Program
    {
        internal static void Main()
        {
            //Data.GetAllCities();
            //Data.GetAllCategories();
            //Data.GetAllSuppliers();
            //Data.GetAllProducts();
            //Data.GetAllUsers();


            //Menu.MainMenu();
            User.CreateUser(true);
            //Supplier.CreateSupplier();
            //Product.CreateProduct();


            //Metoder för att fylla på databasen
            //Helpers.AddCity();
            //Helpers.AddCategories();
            //Helpers.AddColors();
            //Helpers.AddSize();
            //Helpers.AddSupplier();
            //Helpers.AddProduct();


        }
    }
}