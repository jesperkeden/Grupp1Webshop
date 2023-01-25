using Grupp1Webshop.Data;
using Grupp1Webshop.Gammalt;
using Grupp1Webshop.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
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

        internal static List<string> GetPropertyNames(PropertyInfo[] properties)
        {
            List<string> propNameList = new List<string>();
            foreach (var property in properties)
                if (!property.Name.EndsWith("Id") && !property.Name.StartsWith("Order") && !property.Name.EndsWith("Products"))
                    propNameList.Add(property.Name);
            return propNameList;
        }

        internal static List<string> GetPropertyValues<T>(T model, PropertyInfo[] properties)
        {
            List<string> propertyValues = new List<string>();

            foreach (PropertyInfo property in properties)
            {
                if (!property.Name.StartsWith("Id") && !property.Name.StartsWith("Order") && !property.Name.EndsWith("Products"))
                {
                    object value = model.GetType().GetProperty(property.Name).GetValue(model, null);
                    if (property.Name.EndsWith("CityId"))
                    {
                        value = Querys.QGetSelectedCityString(Convert.ToInt32(value));
                        propertyValues.RemoveAt(propertyValues.Count - 1);
                    }
                    else if (property.Name.EndsWith("SupplierId"))
                    {
                        value = Querys.QGetSelectedSupplierString(Convert.ToInt32(value));
                        propertyValues.RemoveAt(propertyValues.Count - 1);
                    }
                    else if (property.Name.EndsWith("CategoryId"))
                    {
                        value = Querys.QGetSelectedCategoryString(Convert.ToInt32(value));
                        propertyValues.RemoveAt(propertyValues.Count - 1);
                    }
                    if (value != null)
                        propertyValues.Add(value.ToString());
                    else
                        propertyValues.Add("Empty");
                }
            }
            return propertyValues;
        }

        internal static List<string> GetNewLinesInString(string description)
        {
            return description.Split('.').ToList();
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

        internal static List<string> ConvertClassListToStringList(List<Order> orders)
        {
            List<string> orderNameList = new List<string>();
            for (int i = 0; i < orders.Count; i++)
            {
                orderNameList.Add(orders[i].Id + "\tCost: " + orders[i].TotalCost + "\tNumber of products: " + Querys.GetProductsFromOrder(i+1).Count);
            }
            return orderNameList;
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

        internal static List<Product> BuyProducts(List<Product> products, List<Product> basket)
        {
            List<Product> productsTemp = new List<Product>(products);

            int choice = 0;
            while (true)
            {
                choice = Menu.ProductMenu(productsTemp, "Press enter to add product to basket\t B = Back\t S = Search", choice, true);
                if (choice == -1) break;
                else if (choice == -2)
                {
                    productsTemp = Helpers.Search();
                    choice = 0;
                    if (productsTemp.Count == 0)
                        BuyProducts(products, basket);
                }
                else if (productsTemp[choice].Quantity <= 0) ;
                else
                {
                    basket.Add(productsTemp[choice]);
                    productsTemp[choice].Quantity--;
                }
            }
            return basket;
        }

        internal static List<Product> ShowAllProducts(List<Product> basket)
        {
            List<Product> products = Helpers.GetProductsFromDb();
            return BuyProducts(products, basket);
        }

        internal static List<Product> ShowCategoryProducts(List<Product> basket)
        {
            List<Product> products = Helpers.GetCategoryProductsFromDb();
            return BuyProducts(products, basket);
        }

        private static List<Product> GetCategoryProductsFromDb()
        {
            List<Category> catList = Querys.QShowAllCategories();
            List<string> catStringList = ConvertClassListToStringList(catList);
            int index = Menu.EditMenu(catStringList) + 1;
            List<Product> productList = Querys.QGetSelectedProducts(index);
            return productList;
        }

        internal static List<string> GetBasketInfoList(Order order)
        {
            List<string> basketInfo = new List<string>();
            basketInfo.Add("Products in basket:".PadRight(30) + Querys.GetProductsFromOrder(order.Id).Count);
            basketInfo.Add("Price of products in basket:".PadRight(30) + (order.TotalCost - order.ShippingCost) + " kr");
            basketInfo.Add("Shipping:".PadRight(30) + order.Shipping);
            basketInfo.Add("Shipping Cost:".PadRight(30) + order.ShippingCost + " kr");
            basketInfo.Add("Paymenth method:".PadRight(30) + order.PaymenthMethod);
            basketInfo.Add("Total Cost:".PadRight(30) + order.TotalCost + " kr");
            return basketInfo;
        }

        internal static void ShowSelectedProducts()
        {
            List<Product> productList = Querys.QGetSelectedProductsForWelcomScreen();
            if (productList.Count == 0) return;
            List<String> productListStrings = new List<String>();
            foreach (Product product in productList)
            {
                productListStrings.Add(product.Name + " - " + product.UnitPrice + " kr");
            }
            GUI.MessageBox("Featured Products!", 50, 2, productListStrings);
        }

        public static List<Product> Search()
        {
            Console.Clear();
            GUI.WriteString("Enter search string:");
            SearchResult searchResult = Querys.SearchProduct(Input.GetStringWithMaxLength(0));
            if (!string.IsNullOrEmpty(searchResult.Message))
            {
                GUI.WriteString(searchResult.Message);
                Console.ReadKey();
            }
            return searchResult.Products;
        }

        internal static void RandomQuerys()
        {
            Console.Clear();
            Querys.QBestselling();
            Console.WriteLine();
            Querys.QAges();
            Querys.QTopFiveExpensiveProduct();
            Console.ReadLine();
        }
    }
}

