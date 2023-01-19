using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Data;
using Grupp1Webshop.Models;

namespace Grupp1Webshop.Models
{
    internal class Product
    {
        internal readonly object UnitsSold;

        public Product()
        {
            //Category = new HashSet<Category>();
            //Suppliers = new HashSet<Supplier>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int UnitSold { get; set; }
        public Supplier Supplier { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        //[ForeignKey("Color")]
        //public int ColorId { get; set; }
        //[ForeignKey("Size")]
        //public int SizeId { get; set; }
        //[ForeignKey("Category")]
        //[ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        //public virtual ICollection<Supplier> Suppliers { get; set; }


        internal static void CreateProduct()
        {
            EditSupplier(new Product());
        }

        //internal static List<string> GetPropertyValues(Product product, PropertyInfo[] properties)
        //{
        //    List<string> propertyValues = new List<string>();

        //    for (int i = 1; i < (properties.Length); i++)
        //    {
        //        try
        //        {
        //            propertyValues.Add(properties[i].GetValue(product).ToString());
        //        }
        //        catch
        //        {
        //            propertyValues.Add("Empty");
        //        }
        //    }
        //    return propertyValues;
        //}

        internal static void EditSupplier(Product model)
        {
            //Get List of prop names and prop values
            PropertyInfo[] properties = model.GetType().GetProperties();
            List<string> firstColumn = Helpers.AddMenuChoicesForProp(Helpers.GetPropertyNames(properties, true));
            List<string> secondCollumn = Helpers.AddMenuChoicesForValues(Helpers.GetPropertyValues(model, properties, true));

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
            if (Helpers.ColumnValueEmpty(secondColumn))
                saveOutput = "Could not save values, some values are empty";
            else
            {
                product.Name = secondColumn[1];
                string categoryFromColumn = secondColumn[2];
                product.Color = secondColumn[3];
                product.Size = secondColumn[4];
                product.Quantity = Convert.ToInt32(secondColumn[5]);
                product.UnitPrice = Convert.ToDouble(secondColumn[6]);
                string supplierFromColumn = secondColumn[7];
                product.Description = secondColumn[8];


                try
                {
                    using (var db = new Context())
                    {
                        var dbProduct = db.Products;
                        dbProduct.Add(product);

                        var dbCategories = db.Categories;
                        Category dbCategory = dbCategories.ToList().SingleOrDefault(a => a.Name == categoryFromColumn);
                        if (dbCategory == null)
                        {
                            dbCategory = new Category()
                            {
                                Name = categoryFromColumn
                            };

                            dbCategories.Add(dbCategory);
                        }
                        product.Category = dbCategory;

                        var dbSuppliers = db.Suppliers;
                        Supplier dbSupplier = dbSuppliers.ToList().SingleOrDefault(a => a.Name == supplierFromColumn);
                        product.Supplier = dbSupplier;

                        db.SaveChanges();
                        saveOutput = "Save success";
                    }
                }
                catch (Exception ex)
                {
                    saveOutput = "Could not save values to database" + ex;
                }

            }
            Console.WriteLine("\n\n" + saveOutput);
            Console.ReadLine();
        }

        internal static string GetValueInput(PropertyInfo edit, int positionX, string description)
        {
            string value = "";
            switch (edit.Name)
            {
                case nameof(Name):
                    value = Input.GetStringFirstLeterInEachWordUpperInput(positionX);
                    break;
                case nameof(Color):
                case nameof(Category):
                case nameof(Size):
                    value = Input.GetStringFirstUpperInput(positionX);
                    break;
                case nameof(Quantity):
                    value = Input.GetIntAsStringInput(0, 100, positionX);
                    break;
                case nameof(UnitPrice):
                    value = Input.GetDoubleAsStringInput(positionX);
                    break;
                case nameof(Description):
                    value = Menu.EditDescriptionValue(description);
                    break;
                case nameof(Supplier):
                    value = Menu.PickSupplierFromMenu();
                    break;
            }
            return value;
        }
    }
}