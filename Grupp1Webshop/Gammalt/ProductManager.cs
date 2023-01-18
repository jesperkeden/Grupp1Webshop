using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Models;

namespace Grupp1Webshop.Gammalt
{
    internal class ProductManager
    {
        public static List<Product> Products { get; set; }

        public static List<Product> GetAllProducts()
        {
            //        Random rnd = new();
            //        if (Products == null || !Products.Any())
            //        {
            //            Products = new List<Product>()
            //            {
            //                new Product()
            //                {
            //                    Name = "Dress with wrinkle",
            //                    Color = new List<string>()
            //                    {
            //                        "Black",
            //                    },
            //                    Size = new List<string>()
            //                    {
            //                        "XS",
            //                    },
            //                    UnitPrice = 299,
            //                    Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.";
            //            //Quantity = rnd.Next(5,50),
            //            //Category = 2
            //        },
            //                new Product()
            //                {
            //                    Name = "Dress with wrinkle",
            //                    Color = new List<string>()
            //                    {
            //                        "Black",
            //                    },
            //                    Size = new List<string>()
            //                    {
            //                        "S",
            //                    },
            //                    UnitPrice = 299,
            //                    Description = "A figure-close, calf-length dress in soft leotard without a sleeve. The dress has a wide neckline and hidden zipper at the back. Wrinkle at the waist for a slightly draped effect. Straight cut bottom edge. Unlined.";
            //        //Quantity = rnd.Next(5,50),
            //        //Category = 2
            //    }
            //};
            //        }
            return Products;
        }
    }
}
