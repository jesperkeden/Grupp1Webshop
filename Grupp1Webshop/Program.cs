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
            //Data.GetAllProducts();
            //Data.GetAllUsers();

            Menu.MainMenu();
            //Menu.ProductPortal();
            //User.CreateUser(true);
            //Supplier.CreateSupplier();
            //Product.CreateProduct();


            //-----------------------------------
            //Metoder i korrekt ordning för att fylla på DB
            //-----------------------------------
            //AddDbData.AddCategories();
            //AddDbData.AddCities();
            //AddDbData.AddSupplier();
            //AddDbData.AddUsers();
            //AddDbData.AddProductFromNewProduct();



            //AddDbData.Addorders();
        }
    }
}