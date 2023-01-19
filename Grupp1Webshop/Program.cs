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
            Helpers.AddCategories();
            //Helpers.AddProductFromNewProduct();

            //Data.GetAllCities();
            //Data.GetAllCategories();
            //Data.GetAllSuppliers();
            //Data.GetAllProducts();
            //Data.GetAllUsers();



            //Menu.MainMenu();
            //User.CreateUser(true);
            //Supplier.CreateSupplier();
            //Product.CreateProduct();

            //Menu.MainMenu();
            //User.CreateUser(true);
            //Supplier.CreateSupplier();
            //Product.CreateProduct();



            //Metoder för att fylla på databasen
            //Helpers.AddCity();
            //Helpers.AddCategories();
            //Helpers.AddColors();
            //Helpers.AddSize();
            //Helpers.AddSupplier();
            //Helpers.AddProduct();

            //int input = 4;
            //Console.WriteLine("Alla kategorier:");
            //Querys.QShowAllCategories();
            //Console.WriteLine();
            //Console.WriteLine("Visa en kategori (jeans)");
            //Querys.QShowOneCategory(input);
            //Console.WriteLine();
            //Querys.QBestselling();
            //Console.WriteLine();
            //Querys.QAges();
            //Console.WriteLine();
            //Querys.QTopFiveExpensiveProduct();


        }
    }
}