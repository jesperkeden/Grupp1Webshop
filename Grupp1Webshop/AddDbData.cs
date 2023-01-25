using Grupp1Webshop.Data;
using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class AddDbData
    {
        internal static void AddUsers()
        {
            using var db = new Context();
            db.AddRange
                (new User()
                {
                    Admin = true,
                    FirstName = "Robin",
                    LastName = "Forsling",
                    Password = "Banan",
                    Email = "Robinsemail@Gmail.com",
                    Age = 30,
                    PhoneNumber = "0737785364",
                    StreetAdress = "S:T Annegatan 17",
                    ZipCode = 61133,
                    CityId = 1
                },
                new User()
                {
                    Admin = true,
                    FirstName = "Jesper",
                    LastName = "K",
                    Password = "Pass",
                    Email = "JespersMail",
                    Age = 27,
                    PhoneNumber = "0737755347",
                    StreetAdress = "NågotIOxelösund",
                    ZipCode = 61122,
                    CityId = 2
                },
                new User()
                {
                    Admin = true,
                    FirstName = "Emina",
                    LastName = "Du",
                    Password = "Pass",
                    Email = "EminasMail@Mail.com",
                    Age = 25,
                    PhoneNumber = "0722678546",
                    StreetAdress = "EminaBorNågonstans i stan",
                    ZipCode = 61131,
                    CityId = 3
                });

            db.SaveChanges();
            Console.WriteLine("Users added");
        }

        private static string GenerateSuplierName()
        {
            Random rnd = new Random();
            List<string> suppliers = Helpers.ConvertClassListToStringList(Helpers.GetSuppliersFromDb());

            return suppliers[rnd.Next(suppliers.Count)];
        }

        internal static void AddProductFromNewProduct()
        {
            List<Product> products = ProductInput.GetAllProducts();
            using (var db = new Context())
            {
                foreach (Product product in products)
                {
                    product.CategoryId++;
                    string suplierName = GenerateSuplierName();

                    var dbSuppliers = db.Suppliers;
                    Supplier dbSupplier = dbSuppliers.ToList().SingleOrDefault(a => a.Name == suplierName);
                    product.Supplier = dbSupplier;

                    var newProduct = product;
                    var dbNewProduct = db.Products;
                    dbNewProduct.Add(newProduct);
                }
                try
                {
                    db.SaveChanges();
                    Console.WriteLine("Products added...");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.ReadLine();
                }

            }
            //using var db = new Context();
            //var dbNewProduct = db.Products;

            //var newProduct = new Product()
            //{
            //    Name = products.Name,
            //    Color = products.Colour[0].Name,
            //    Size = products.Size[0],
            //    UnitPrice = products.Price,
            //    Description = products.Description,
            //    Quantity = products.Quantity,
            //    CategoryId = products.CategoryId,
            //    Supplier = GenerateSuplierName()
            //};

            //dbNewProduct.Add(NewProduct);
        }

        internal static void AddCategories()
        {
            using var db = new Context();
            db.AddRange(

                new Category() { Name = "Dresses" },
                new Category() { Name = "Shoes" },
                new Category() { Name = "Sweaters" },
                new Category() { Name = "Skirts" },
                new Category() { Name = "Jackets" },
                new Category() { Name = "Bottoms" }

                );
            db.SaveChanges();
            Console.WriteLine("Categories added");
        }

        internal static void AddProduct()
        {
            using var db = new Context();
            var supplier = new Supplier();
            db.AddRange(
                //new Product() 
                //{ 
                //    Name = "Dress with wrinkle", 
                //    Description = "Hej", 
                //    UnitPrice = 299, 
                //    Quantity = 1, 
                //    ColorId = 1, 
                //    SizeId = 1, 
                //    CategoryId = 1, 
                //    SupplierId = 1 
                //},
                //new Product()
                //{
                //    Name = "Byxor",
                //    Description = "blåa vanliga jeans",
                //    UnitPrice = 1399,
                //    Quantity = 8,
                //    ColorId = 7,
                //    SizeId = 8,
                //    CategoryId = 4,
                //    SupplierId = 2
                //}

                );
            db.SaveChanges();
            Console.WriteLine("Product added");
        }

        internal static void AddSupplier()
        {
            using var db = new Context();
            db.AddRange
                (

                new Supplier()
                {
                    Name = "Robins Chokladkakor",
                    ContactPerson = "Robin Forsling",
                    PhoneNumber = "0708759983",
                    Email = "koko@hotmail.com",
                    StreetAdress = "Storgatan 6",
                    ZipCode = 61335,
                    CityId = 1
                },
                new Supplier()
                {
                    Name = "Eminas Klädbutik",
                    ContactPerson = "Emina Duro",
                    PhoneNumber = "0708759900",
                    Email = "emina@hotmail.com",
                    StreetAdress = "Storgatan 7",
                    ZipCode = 61335,
                    CityId = 2

                },
                new Supplier()
                {
                    Name = "Jespers Datasupport",
                    ContactPerson = "Jesper Kedén",
                    PhoneNumber = "0737785368",
                    Email = "jesper.keden@hotmail.com",
                    StreetAdress = "Storgatan 8",
                    ZipCode = 61336,
                    CityId = 3

                }
            );
            db.SaveChanges();
            Console.WriteLine("Suppliers added");

        }

        internal static void AddCities()
        {
            using var db = new Context();
            db.AddRange(

                new City() { Name = "Nyköping" },
                new City() { Name = "Stockholm" },
                new City() { Name = "Göteborg" },
                new City() { Name = "Malmö" }

             );

            db.SaveChanges();
            Console.WriteLine("Cities added");
        }
    }
}
