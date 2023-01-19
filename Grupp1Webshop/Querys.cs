using Grupp1Webshop.Data;
using Grupp1Webshop.Models;
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

        public static void QShowOneCategory(int input) //Vill ha CategoryID / ID från category som input
        {
            using var db = new Data.Context();

            var result = from
                         c in db.Categories
                         join
                         p in db.Products
                         on c.Id equals p.CategoryId
                         select new
                         {
                             Name = p.Name,
                             Category = c.Name,
                             CategoryId = c.Id,
                         };
            var categories = result.Where(g => g.CategoryId == input).ToList();
            foreach (var item in categories)
            {
                Console.WriteLine($"{item.Name}");
            }

        }

        public static void QShowAllCategories() //Visa ALLA kategorier
        {
            using var db = new Data.Context();
            var categories = Helpers.GetCategoriesFromDb();

            foreach (var item in categories)
            {
                Console.WriteLine($"{item.Name}");
            }

        }


    }
}
