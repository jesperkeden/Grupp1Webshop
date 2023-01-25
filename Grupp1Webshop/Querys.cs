using Grupp1Webshop.Data;
using Grupp1Webshop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class Querys
    {
        public static void QBestselling() // bästsäljande produkter
        {
            using var db = new Data.Context();
            var products = Helpers.GetProductsFromDb();
            var result = products
                .Take(3)
                .OrderBy(p => p.UnitSold)
                .ToList();
            Console.WriteLine("Top 3 Bestselling Products");
            foreach (var product in result)
            {
                Console.WriteLine($"{product.Name} has been sold {product.UnitSold} times.");
            }

        }
        public static void QAges()
        {
            using var db = new Data.Context();
            var users = Helpers.GetUsersFromDb();

            int min = users.Min(p => p.Age);
            int max = users.Max(p => p.Age);
            Console.WriteLine("Young vs. Old");
            Console.WriteLine();
            Console.WriteLine("Our youngest customer is {0} years old.", min);
            Console.WriteLine();
            Console.WriteLine("Our oldest customer is {0} years old.", max);

        }

        public static void QTopFiveExpensiveProduct()
        {
            using var db = new Data.Context();
            var products = Helpers.GetProductsFromDb();
            var result = products
                .Take(5)
                .OrderBy(p => p.UnitPrice)
                .ToList();
            Console.WriteLine("Top 5 Most Expensive Products");
            Console.WriteLine();
            foreach (var product in result)
            {
                Console.WriteLine($"{product.Name} costs {product.UnitPrice} SEK.");
            }
        }

        public static List<Category> QShowAllCategories() //Visa ALLA kategorier
        {
            using var db = new Data.Context();
            var categories = Helpers.GetCategoriesFromDb();

            return categories;
        }

        public static List<Product> QGetSelectedProducts(int categoryId)
        {
            using var db = new Data.Context();
            var productList = db.Products.Where(d => d.CategoryId == categoryId).ToList();
            return productList;
        }

        public static List<Product> QGetSelectedProductsForWelcomScreen()
        {
            using var db = new Data.Context();
            var productList = db.Products.Where(d => d.SelectedForWelcomeScreen == true).ToList();
            return productList;
        }

        public static User QGetSelectedUserFromPassword(string firstName, string lastName, string password)
        {
            using var db = new Data.Context();
            var user = db.Users.FirstOrDefault(u => u.FirstName == firstName && u.LastName == lastName && u.Password == password);
            return user;
        }

        public static List<Order> QGetSelectedOrder(User user)
        {
            using var db = new Data.Context();
            var orderList = db.Orders.Where(d => d.User == user).ToList();
            return orderList;
        }

        public static string QGetSelectedCityString(int cityId)
        {
            using var db = new Data.Context();
            var city = db.Cities.FirstOrDefault(c => c.Id == cityId);
            return city.Name;
        }

        internal static string QGetSelectedSupplierString(int supplierId)
        {
            using var db = new Data.Context();
            var supplier = db.Suppliers.FirstOrDefault(c => c.Id == supplierId);
            return supplier.Name;
        }

        internal static string QGetSelectedCategoryString(int categoryId)
        {
            using var db = new Data.Context();
            var category = db.Categories.FirstOrDefault(c => c.Id == categoryId);
            return category.Name;
        }

        public static User QGetSelectedUser(int userId)
        {
            using var db = new Data.Context();
            var user = db.Users.FirstOrDefault(c => c.Id == userId);
            return user;
        }

        internal static SearchResult SearchProduct(string searchString)
        {
            using (var db = new Context())
            {
                var products = from p in db.Products
                               where p.Name.Contains(searchString)
                               || p.Description.Contains(searchString)
                               select p;
                var result = new SearchResult();
                result.Products = products.ToList();

                if (result.Products.Count == 0)
                {
                    result.Message = "You'r search returned no results";
                }
                return result;
            }
        }

        internal static List<T> GetProductCountFromOrder<T>()
        {
            using (var db = new Context())
            {
                var query = from op in db.OrderProducts
                            group op by op.OrderId into g
                            select new { OrderId = g.Key, ProductCount = g.Count() };
                var result = query;
                return result.Cast<T>().ToList();
            }
        }

        public static List<Product> GetProductsFromOrder(int orderId)
        {
            using (var db = new Context())
            {
                var query = from op in db.OrderProducts
                            where op.OrderId == orderId
                            join p in db.Products on op.ProductId equals p.Id
                            select p;
                return query.ToList();
            }
        }
    }
}
