using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop.Data
{
    internal class CategoryManager
    {
        public static List<Category> Categories { get; set; }

        public static List<Category> GetAllCategories()
        {
            if (Categories == null || !Categories.Any())
            {
                Categories = new List<Category>()
                {
                    new Category()
                    {
                        Name = "Dresses",
                    },
                    new Category()
                    {
                        Name = "Shoes"
                    },
                    new Category()
                    {
                        Name = "Sweaters"
                    },
                    new Category()
                    {
                        Name = "Skirts"
                    },
                    new Category()
                    {
                        Name = "Jackets"
                    }
                };
            }
            return Categories;
        }
    }
}
