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
        internal static void QBestselling() // bästsäljande produkter
        {
            using var db = new Data.Context();

            var query = db.Products.OrderByDescending(p => p.UnitSold).Take(3);
            var result = query.ToList();
                        

            Console.WriteLine("---------Top 3 Bestselling Products-----------");
            foreach (var product in result)
            {
                Console.WriteLine($"{product.Name} has been sold {product.UnitSold} times.");
            }

        }

        internal static void QAges()
        {
            using var db = new Data.Context();
            var users = Helpers.GetUsersFromDb();

            var query = db.Users.Select(u => u.Age);
            var avgAge = query.Average();
            var minAge = query.Min();
            var maxAge = query.Max();

            Console.WriteLine("\n\n------------Young vs. Old------------");
            Console.WriteLine("Our youngest customer is {0} years old.", minAge);
            Console.WriteLine("Our oldest customer is {0} years old.", maxAge);
            Console.WriteLine("Our average customer age is {0}.", avgAge.ToString("0.00"));

        }

        internal static void QTopFiveExpensiveProduct()
        {
            using var db = new Data.Context();

            var query = from p in db.Products
                        group p by p.CategoryId
                        into c
                        select c.OrderByDescending(p => p.UnitPrice).FirstOrDefault();

            var result = query.ToList();

            Console.WriteLine("\n\n------Most Expensive Products Per Category.---------");
            foreach (var product in result)
            {
                Console.WriteLine($"Category ID: {product.CategoryId}\t{product.Name} costs {product.UnitPrice} SEK.");
            }
        }

        internal static List<Category> QShowAllCategories() //Visa ALLA kategorier
        {
            using var db = new Data.Context();
            var categories = Helpers.GetCategoriesFromDb();

            return categories;
        }

        internal static List<Product> QGetSelectedProducts(int categoryId)
        {
            using var db = new Data.Context();
            var productList = db.Products.Where(d => d.CategoryId == categoryId).ToList();
            return productList;
        }

        internal static List<Product> QGetSelectedProductsForWelcomScreen()
        {
            using var db = new Data.Context();
            var productList = db.Products.Where(d => d.SelectedForWelcomeScreen == true).ToList();
            return productList;
        }

        internal static User QGetSelectedUserFromPassword(string firstName, string lastName, string password)
        {
            using var db = new Data.Context();
            var user = db.Users.FirstOrDefault(u => u.FirstName == firstName && u.LastName == lastName && u.Password == password);
            return user;
        }

        internal static List<Order> QGetSelectedOrder(User user)
        {
            using var db = new Data.Context();
            var orderList = db.Orders.Where(d => d.User == user).ToList();
            return orderList;
        }

        internal static string QGetSelectedCityString(int cityId)
        {
            using var db = new Data.Context();
            var city = db.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null) return null;
            return city.Name;
        }

        internal static string QGetSelectedSupplierString(int supplierId)
        {
            using var db = new Data.Context();
            var supplier = db.Suppliers.FirstOrDefault(c => c.Id == supplierId);
            if (supplier == null) return null;
            return supplier.Name;
        }

        internal static string QGetSelectedCategoryString(int categoryId)
        {
            using var db = new Data.Context();
            var category = db.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) return null;
            return category.Name;
        }

        internal static User QGetSelectedUser(int userId)
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

        internal static List<Product> GetProductsFromOrder(int orderId)
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
