using Grupp1Webshop.Data;
using Grupp1Webshop.Gammalt;
using Grupp1Webshop.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Grupp1Webshop
{
    internal class Helpers
    {

        public static string ConvertEnumSpacesToString(string str)
        {
            return string.Concat(str.Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
        }

        internal static int GetLengthOfStringInList(List<string> listString)
        {
            return (listString.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur).Length + 1);
        }

        internal static List<string> AddMenuChoicesForProp(List<string> propNameList)
        {
            propNameList.Insert(0, "Save All");
            propNameList.Add("Cancel");
            return propNameList;
        }

        internal static List<string> AddMenuChoicesForValues(List<string> valueList)
        {
            valueList.Insert(0, "");
            return valueList;
        }

        internal static bool ColumnValueEmpty(List<string> secondColumn)
        {
            foreach (var item in secondColumn)
                if (item == "Empty" || item == "empty" || item == " " || item == "0")
                    return true;
            return false;
        }

        internal static List<string> GetPropertyNames(PropertyInfo[] properties, bool isAdmin)
        {
            List<string> propNameList = new List<string>();
            foreach (var property in properties)
                if (!property.Name.EndsWith("Id") && !property.Name.StartsWith("Order") && !property.Name.EndsWith("Products") && (isAdmin || !property.Name.StartsWith("Admin")))
                    propNameList.Add(property.Name);
            return propNameList;
        }

        internal static List<string> GetPropertyValues<T>(T model, PropertyInfo[] properties, bool isAdmin)
        {
            List<string> propertyValues = new List<string>();

            foreach (PropertyInfo property in properties)
            {
                if (!property.Name.EndsWith("Id") && !property.Name.StartsWith("Order") && !property.Name.EndsWith("Products") && (isAdmin || !property.Name.StartsWith("Admin")))
                {
                    object value = model.GetType().GetProperty(property.Name).GetValue(model, null);
                    if (value != null)
                        propertyValues.Add(value.ToString());
                    //else if (model.GetType().GetProperty(property.Name))
                    //{

                    //}
                    else
                        propertyValues.Add("Empty");
                }
            }
            return propertyValues;
        }

        //internal static List<string> GetPropertyValues(Supplier model, PropertyInfo[] properties, bool isAdmin)
        //{
        //    List<string> propertyValues = new List<string>();

        //    foreach (PropertyInfo property in properties)
        //    {
        //        if (!property.Name.EndsWith("Id") && !property.Name.EndsWith("Order") && (isAdmin || !property.Name.StartsWith("Admin")))
        //        {
        //            object value = model.GetType().GetProperty(property.Name).GetValue(model, null);
        //            if (value != null)
        //                propertyValues.Add(value.ToString());
        //            else
        //                propertyValues.Add("empty");
        //        }
        //    }
        //    return propertyValues;
        //}

        //internal static List<string> GetPropertyValues(Product model, PropertyInfo[] properties, bool isAdmin)
        //{
        //    List<string> propertyValues = new List<string>();

        //    foreach (PropertyInfo property in properties)
        //    {
        //        if (!property.Name.EndsWith("Id") && !property.Name.EndsWith("Order") && (isAdmin || !property.Name.StartsWith("Admin")))
        //        {
        //            object value = model.GetType().GetProperty(property.Name).GetValue(model, null);
        //            if (value != null)
        //                propertyValues.Add(value.ToString());
        //            else
        //                propertyValues.Add("empty");
        //        }
        //    }
        //    return propertyValues;
        //}

        internal static List<string> GetNewLinesInString(string description)
        {
            return description.Split('.').ToList();
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
        internal static void AddProductFromNewProduct()
        {
            List<Product> products = ProductImput.GetAllProducts();
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

        private static string GenerateSuplierName()
        {
            Random rnd = new Random();
            List<string> suppliers = ConvertClassListToStringList(GetSuppliersFromDb());

            return suppliers[rnd.Next(suppliers.Count)];
        }

        internal static List<Supplier> GetSuppliersFromDb()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (var db = new Context())
            {
                suppliers = db.Suppliers.ToList();
            }
            return suppliers;
        }

        internal static List<Product> GetProductsFromDb()
        {
            List<Product> products = new List<Product>();
            using (var db = new Context())
            {
                products = db.Products.ToList();
            }
            return products;
        }

        internal static List<User> GetUsersFromDb()
        {
            List<User> users = new List<User>();
            using (var db = new Context())
            {
                users = db.Users.ToList();
            }
            return users;
        }

        internal static List<string> ConvertClassListToStringList(List<Product> Products)
        {
            var ProductsNames = Products.Select(x => x.Name);
            return new List<string>(ProductsNames);
        }

        internal static List<string> ConvertClassListToStringList(List<Supplier> suppliers)
        {
            var suppliersNames = suppliers.Select(x => x.Name);
            return new List<string>(suppliersNames);
        }

        internal static List<string> ConvertClassListToStringList(List<Category> categories)
        {
            var categoriesNames = categories.Select(x => x.Name);
            return new List<string>(categoriesNames);
        }


        internal static List<Category> GetCategoriesFromDb()
        {
            List<Category> categories = new List<Category>();
            using (var db = new Context())
            {
                categories = db.Categories.ToList();
            }
            return categories;
        }

        internal static List<string> ConvertProductsListToStringList(List<Product> products)
        {
            var productNames = products.Select(x => x.Name);
            return new List<string>(productNames);
        }

        internal static List<string> ConvertProductListToStringList(List<Product> products)
        {
            var productsNames = products.Select(x => x.Name);
            return new List<string>(productsNames);
        }

        internal static List<string> ConvertClassListToStringList(List<User> users)
        {
            List<string> usersNames = new List<string>();
            foreach (var user in users)
            {
                usersNames.Add("ID: " + user.Id + ". Name: " + user.FirstName + " " + user.LastName);
            }
            return usersNames;
        }

        internal static void DeleteModel(User user)
        {
            using (var db = new Context())
            {
                var deleteUser = (from c in db.Users
                                  where c.Id == user.Id
                                  select c).SingleOrDefault();
                if (deleteUser != null)
                {
                    db.Users.Remove((User)deleteUser);
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("An error has occured, please try again!");
                        Console.WriteLine(e);
                    }
                }
            }
        }

        internal static void DeleteModel(Supplier supplier)
        {
            using (var db = new Context())
            {
                var deleteSupplier = (from c in db.Suppliers
                                      where c.Id == supplier.Id
                                      select c).SingleOrDefault();
                if (deleteSupplier != null)
                {
                    db.Suppliers.Remove((Supplier)deleteSupplier);
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("An error has occured, please try again!");
                        Console.WriteLine(e);
                    }
                }
            }
        }

        internal static void DeleteModel(Product product)
        {
            using (var db = new Context())
            {
                var deleteProduct = (from c in db.Products
                                     where c.Id == product.Id
                                     select c).SingleOrDefault();
                if (deleteProduct != null)
                {
                    db.Products.Remove((Product)deleteProduct);
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("An error has occured, please try again!");
                        Console.WriteLine(e);
                    }
                }
            }
        }

        internal static List<Product> buyProducts(List<Product> products, List<Product> basket)
        {
            int choice = 0;
            while (true)
            {
                choice = Menu.ProductMenu(products, choice);
                if (choice == -1) break;
                basket.Add(products[choice]);
            }
            return basket;
        }

        internal static List<Product> ShowAllProducts(List<Product> basket)
        {
            List<Product> products = Helpers.GetProductsFromDb();
            return buyProducts(products, basket);
        }

        internal static List<Product> ShowCategoryProducts(List<Product> basket)
        {
            List<Product> products = Helpers.GetCategoryProductsFromDb();
            return buyProducts(products, basket);
        }

        private static List<Product> GetCategoryProductsFromDb()
        {
            List<Category> catList = Querys.QShowAllCategories();
            List<string> catStringList = ConvertClassListToStringList(catList);
            int index = Menu.EditMenu(catStringList) + 1;
            List<Product> productList = Querys.QGetSelectedProducts(index);
            return productList;
        }

        internal static List<Product> Showbasket(List<Product> basket)
        {
            Console.Clear();
            foreach (Product product in basket)
            {
                GUI.WriteString(product.Name.PadRight(40) + "Price: " + product.UnitPrice.ToString().PadRight(7) + "Color: " + product.Color.PadRight(18) + "Size: " + product.Size.PadRight(4) + "In Stock: " + product.Quantity.ToString().PadRight(4));
                GUI.MessageBox("description", 3, 21, Helpers.GetNewLinesInString(product.Description));
            }
            Console.ReadLine();




            return basket;
        }
    }
}

