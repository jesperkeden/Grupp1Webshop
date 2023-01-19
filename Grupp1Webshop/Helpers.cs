using Grupp1Webshop.Data;
using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
                if (item == "Empty" || item == "empty" || item == "" || item == " " || item == "0")
                    return true;
            return false;
        }

        internal static List<string> GetPropertyNames(PropertyInfo[] properties, bool isAdmin)
        {
            List<string> propNameList = new List<string>();
            foreach (var property in properties)
                if (!property.Name.EndsWith("Id") && !property.Name.EndsWith("Order") && !property.Name.EndsWith("Products") && (isAdmin || !property.Name.StartsWith("Admin"))) 
                    propNameList.Add(property.Name);
            return propNameList;
        }

        internal static List<string> GetPropertyValues<T>(T model, PropertyInfo[] properties, bool isAdmin)
        {
            List<string> propertyValues = new List<string>();

            foreach (PropertyInfo property in properties)
            {
                if (!property.Name.EndsWith("Id") && !property.Name.EndsWith("Order") && !property.Name.EndsWith("Products") && (isAdmin || !property.Name.StartsWith("Admin")))
                {
                    object value = model.GetType().GetProperty(property.Name).GetValue(model, null);
                    if (value != null)
                        propertyValues.Add(value.ToString());
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

        //internal static void AddColors()
        //{
        //    using var db = new Context();
        //    db.AddRange(

        //        new Color() { Name = "Black" },
        //        new Color() { Name = "Beige" },
        //        new Color() { Name = "Blue" },
        //        new Color() { Name = "White" },
        //        new Color() { Name = "Silver" },
        //        new Color() { Name = "Red" },
        //        new Color() { Name = "Black/Stripped" },
        //        new Color() { Name = "Black/Floral" },
        //        new Color() { Name = "Green" },
        //        new Color() { Name = "Blue/Denim" },
        //        new Color() { Name = "Blue/Light" },
        //        new Color() { Name = "Cream" }

        //        );
        //    db.SaveChanges();
        //    Console.WriteLine("Colors added");
        //}
        //internal static void AddSize()
        //{
        //    using var db = new Context();
        //    db.AddRange(

        //        new Size() { Name = "XS" },
        //        new Size() { Name = "S" },
        //        new Size() { Name = "M" },
        //        new Size() { Name = "L" },
        //        new Size() { Name = "XL" },
        //        new Size() { Name = "32" },
        //        new Size() { Name = "34" },
        //        new Size() { Name = "35" },
        //        new Size() { Name = "36" },
        //        new Size() { Name = "37" },
        //        new Size() { Name = "38" },
        //        new Size() { Name = "39" },
        //        new Size() { Name = "40" },
        //        new Size() { Name = "41" },
        //        new Size() { Name = "42" },
        //        new Size() { Name = "43" },
        //        new Size() { Name = "44" }
        //        );
        //    db.SaveChanges();
        //    Console.WriteLine("Sizes added");
        //}
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
            //db.AddRange(

            //    new Supplier() 
            //    { 
            //        Name = "Robins kakor", 
            //        ContactPerson = "Robin", 
            //        PhoneNumber = "0708759983", 
            //        Email = "blabla", 
            //        StreetAdress = "storgatan 6", 
            //        ZipCode = 61335,
            //        CityId = 1,
            //    },
            //    new Supplier()
            //    {
            //        Name = "Eminas kläder",
            //        ContactPerson = "Emina",
            //        PhoneNumber = "0708759900",
            //        Email = "blablaasd",
            //        StreetAdress = "storgatan 7",
            //        ZipCode = 61336,
            //    });
            try
            {
                var dbNewSupplier = db.Suppliers;
                var newSupplier = new Supplier()
                {
                    Name = "Jespers",
                    ContactPerson = "emina",
                    PhoneNumber = "0737785368",
                    Email = "fghfghfgh",
                    StreetAdress = "dfgdfg",
                    ZipCode = 61336,
                };

                dbNewSupplier.Add(newSupplier);

                var dbCities = db.Cities;
                City dbCity = dbCities.ToList().SingleOrDefault(a => a.Name == "kiruna");
                if (dbCity == null)
                {
                    dbCity = new City()
                    {
                        Name = "kiruna"
                    };

                    dbCities.Add(dbCity);
                }
                newSupplier.City = dbCity;

                
                db.SaveChanges();
                Console.WriteLine("Suppliers added");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        internal static void AddCity()
        {
            using var db = new Context();
            db.AddRange(

                new City() { Name = "Nyköping" }, 
                new City() { Name = "Stockholm" } 

                );
            db.SaveChanges();
            Console.WriteLine("City added");
        }
        //internal static void AddProduct()
        //{
        //    List<Product> products = new GetAllProducts();
        //    using var db = new Context();
        //    var dbNewProduct = db.Products;
        //    var newProduct = new Product()
        //    {
        //        Name = product.Name,
        //        Colour product.Colour[0],
        //        Size = product.Size[0],
        //        UnitPrice = product.Price,
        //        Description = product.Description,
        //        Quantity= product.Quantity,
        //        Category= product.Category,
        //        Supplier=GenerateSuplierName();
        //    };

        //   dbNewProduct.Add(NewProduct);

        //}


        //private string GenerateSuplierName()
        //{
        //    Random rnd = new Random();
        //    string [] suppliers = ConvertClassListToStringList(GetSuppliersFromDb());

        //    return suppliers[rnd.Next(suppliers.Length)];
        //}

        internal static List<Supplier> GetSuppliersFromDb()
        {
            List <Supplier> suppliers = new List<Supplier>();
            using (var db = new Context())
            {
                suppliers =  db.Suppliers.ToList();
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
            return new List<string> (ProductsNames);
        }

        internal static List<string> ConvertClassListToStringList(List<Supplier> suppliers)
        {
            var suppliersNames = suppliers.Select(x => x.Name);
            return new List<string>(suppliersNames);
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

        internal static List<Product> GetProductsFromDb()
        {
            List<Product> products = new List<Product>();
            using (var db = new Context())
            {
                products = db.Products.ToList();
            }
            return products;
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


        //internal static List<string> ConvertClassListToStringList(List<User> Users)
        //{
        //    var UsersNames = Users.Select(x => x.Name);
        //    return new List<string>(UsersNames);
        //}

    }
}

