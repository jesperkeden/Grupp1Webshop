using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Models;

namespace Grupp1Webshop.Models
{
    internal class Product
    {
        public Product()
        {
            this.Baskets = new HashSet<Basket>();
            this.Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public string Size { get; set; }
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Basket> Baskets { get; set; }



        internal static void CreateProduct()
        {
            EditSupplier(new Product());
        }

        internal static List<string> GetPropertyNames(PropertyInfo[] properties)
        {
            List<string> propNameList = new List<string>();

            for (int i = 1; i < (properties.Length); i++)
            {
                propNameList.Add(properties[i].Name);
            }
            return propNameList;
        }

        internal static List<string> GetPropertyValues(Product product, PropertyInfo[] properties)
        {
            List<string> propertyValues = new List<string>();

            for (int i = 1; i < (properties.Length); i++)
            {
                try
                {
                    propertyValues.Add(properties[i].GetValue(product).ToString());
                }
                catch
                {
                    propertyValues.Add("Empty");
                }
            }
            return propertyValues;
        }

        internal static void EditSupplier(Product model)
        {
            //Get List of prop names and prop values
            PropertyInfo[] properties = model.GetType().GetProperties();
            List<string> firstColumn = Helpers.AddMenuChoicesForProp(GetPropertyNames(properties));
            List<string> secondCollumn = Helpers.AddMenuChoicesForValues(GetPropertyValues(model, properties));

            //Position of list in GUI
            int firstColumnPositionX = 3;
            int secondColumnPositionX = (Helpers.GetSecondCollumnPositionX(firstColumn) + firstColumnPositionX);
            int positionY = 2;

            int index = 0;

            //Edit prop values
            while (true)
            {
                index = Menu.EditMenu(firstColumn, secondCollumn, firstColumnPositionX, secondColumnPositionX, positionY);

                //if (index == 0) SaveProduct(secondCollumn, model);
                //else if (index == secondCollumn.Count) break;

                GUI.OverWriteWithSpaces(secondCollumn[index].Length, secondColumnPositionX, (positionY + index));
                secondCollumn[index] = EditProductChoices(index, secondColumnPositionX);
            }
        }

        private static string EditProductChoices(int index, int secondColumnPositionX)
        {
            throw new NotImplementedException();
        }

        //private static void SaveProduct(List<string> secondCollumn, Product product)
        //{
        //    product.Name = secondColumn[1];
        //    product.Price = Convert.ToDouble(secondColumn[2]);
        //    product.Description = secondColumn[3];
        //    product.Color = secondColumn[4];
        //    product.Quantity = Convert.ToInt32(secondColumn[5]);
        //    //product.CategoryId = Convert.ToInt32(secondColumn[6]);
        //    //product.SupplierId = Convert.ToInt32(secondColumn[7]);
        //    product.Size = secondColumn[8];


        //    //saveToDbFunciton("StringToSaveDbText");

        //    //{ New Generic method
        //    //    try
        //    //    {
        //    //        //saveToDbFunction
        //    //    }
        //    //    catch
        //    //    {
        //    //        Console.WriteLine("Could not save data to database!");
        //    //        Console.ReadLine();
        //    //    }
        //    //    return;
        //    //}

        //    return;
        //}
    }
}
