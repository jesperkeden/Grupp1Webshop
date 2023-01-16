using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop.Models
{
    internal class Supplier
    {
        [ForeignKey("City")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string StreetAdress { get; set; }
        public int ZipCode { get; set; }
        public City City { get; set; }




        internal static void CreateSupplier()
        {
            EditSupplier(new Supplier());
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

        internal static List<string> GetPropertyValues(Supplier supplier, PropertyInfo[] properties)
        {
            List<string> propertyValues = new List<string>();

            for (int i = 1; i < (properties.Length); i++)
            {
                try
                {
                    propertyValues.Add(properties[i].GetValue(supplier).ToString());
                }
                catch
                {
                    propertyValues.Add("Empty");
                }
            }
            return propertyValues;
        }

        internal static void EditSupplier(Supplier model)
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

                if (index == 0) SaveSupplier(secondCollumn, model);
                else if (index == secondCollumn.Count) break;

                GUI.OverWriteWithSpaces(secondCollumn[index].Length, secondColumnPositionX, (positionY + index));
                secondCollumn[index] = EditSupplierChoices(index, secondColumnPositionX);
            }
        }

        private static string EditSupplierChoices(int index, int secondColumnPositionX)
        {
            throw new NotImplementedException();
        }

        private static void SaveSupplier(List<string> secondColumn, Supplier suplier)
        {
            suplier.Name = secondColumn[1];
            suplier.ContactPerson = secondColumn[2];
            suplier.PhoneNumber = secondColumn[3];
            suplier.Email = secondColumn[4];
            suplier.StreetAdress = secondColumn[5];
            suplier.ZipCode = Convert.ToInt32(secondColumn[6]);
            //suplier.City = secondColumn[7];

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

            return;
        }
    }
}
