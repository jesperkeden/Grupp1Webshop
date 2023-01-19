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
        public static void QBestselling()
        {
            using var db = new Data.Context();
            var products = Helpers.GetProductsFromDb();
            //var prodList = Helpers.ConvertProductListToStringList(products);
            //var items = from p in products
            //            orderby p.UnitSold,
                        
            //            select p;

            //products.OrderBy(p => p.UnitsSold.Count).Take(5);

            var result = products.
                Take(3).
                OrderByDescending(p => p.UnitSold).
                ToList();
            //OrderByDescending(p => p.UnitSold).ToList();
            foreach (var product in result)
            {
                Console.WriteLine(product.Name);
            }



        }
        public void QPopularAge()
        {

        }
        public void QTopFiveExpensiveProduct()
        {

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

        public static void QShowAllCategories()
        {
            using var db = new Data.Context();
            var categories = Helpers.GetCategoriesFromDb();
            //var categories = Helpers.ConvertCategoryListToStringList(categories);
  
            foreach (var item in categories)
            {
                Console.WriteLine($"{item.Name}");
            }

        }


    }
}
