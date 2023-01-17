using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            this.Orders = new HashSet<Order>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        [ForeignKey("Supplier")]
        public int? SupplierId { get; set; }

        public ICollection<Order> Orders { get; set; }



        internal static void CreateProduct()
        {
            EditSupplier(new Product());
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
            List<string> firstColumn = Helpers.AddMenuChoicesForProp(Helpers.GetPropertyNames(properties, 1));
            List<string> secondCollumn = Helpers.AddMenuChoicesForValues(GetPropertyValues(model, properties));

            //Position of list in GUI
            int firstColumnPositionX = 3;
            int secondColumnPositionX = (Helpers.GetLengthOfStringInList(firstColumn) + firstColumnPositionX);
            int positionY = 2;

            int index = 0;

            //Edit prop values
            while (true)
            {
                index = Menu.EditMenu(firstColumn, secondCollumn, firstColumnPositionX, secondColumnPositionX, positionY, index);

                if (index == 0) SaveProduct(secondCollumn, model);
                else if (index == secondCollumn.Count) break;

                GUI.OverWriteWithSpaces(secondCollumn[index].Length, secondColumnPositionX, (positionY + index));
                secondCollumn[index] = GetValueInput(properties[index], secondColumnPositionX, secondCollumn[index]);
            }
        }

        private static void SaveProduct(List<string> secondColumn, Product product)
        {
            string saveOutput = "";
            if (Helpers.ColumnValueNotEmpty(secondColumn))
                saveOutput = "Could not save values, some values are empty";
            else
            {
                product.Name = secondColumn[1];
                product.Price = Convert.ToDouble(secondColumn[2]);
                product.Description = secondColumn[3];
                product.Color = secondColumn[4];
                product.Quantity = Convert.ToInt32(secondColumn[5]);
                //product.CategoryId = Convert.ToInt32(secondColumn[6]);
                //product.SupplierId = Convert.ToInt32(secondColumn[7]);
                product.Size = secondColumn[8];
                saveOutput = "Save success";
            }

            //saveToDbFunciton("StringToSaveDbText");

            //{ New Generic method
            //    try
            //    {
            //        //saveToDbFunction
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Could not save data to database!");
            //        Console.ReadLine();
            //    }
            //    return;
            //}

            Console.WriteLine(saveOutput);
            Console.ReadKey();
            return;
        }

        internal static string GetValueInput(PropertyInfo edit, int positionX, string description)
        {
            string value = "";
            switch (edit.Name)
            {
                case nameof(Name):
                case nameof(Color):
                case nameof(Size):
                    value = Input.GetStringFirstUpperInput(positionX);
                    break;
                case nameof(Quantity):
                    value = Input.GetIntAsStringInput(0, 100, positionX);
                    break;
                case nameof(Price):
                    value = Input.GetDoubleAsStringInput(positionX);
                    break;
                case nameof(Description):
                    List <string> listDescription = Helpers.GetNewLinesInString("jhdfgjkhdkjgh.jdhfgdkjfhg. djhnfgkjdfhgjk. jdsfhgkjdhfg. djhgkjhdfkjg. jhdgfkj");
                    GUI.MessageBox("Description", 4, 20, listDescription);
                    value = Input.GetDescriptionInput(positionX);
                    break;
            }
            return value;
        }
    }
}