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
        public Supplier()
        {
            Products = new HashSet<Product>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string StreetAdress { get; set; }
        public int ZipCode { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public virtual ICollection<Product> Products { get; set; }




        internal static void CreateSupplier()
        {
            EditSupplier(new Supplier());
        }

        internal static List<string> GetPropertyValues(Supplier supplier, PropertyInfo[] properties, int removeLast)
        {
            List<string> propertyValues = new List<string>();

            for (int i = 1; i < (properties.Length - removeLast); i++)
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
            List<string> firstColumn = Helpers.AddMenuChoicesForProp(Helpers.GetPropertyNames(properties, 1, 1));
            List<string> secondCollumn = Helpers.AddMenuChoicesForValues(GetPropertyValues(model, properties, 1));

            //Position of list in GUI
            int firstColumnPositionX = 3;
            int secondColumnPositionX = (Helpers.GetLengthOfStringInList(firstColumn) + firstColumnPositionX);
            int positionY = 2;

            int index = 0;

            //Edit prop values
            while (true)
            {
                index = Menu.EditMenu(firstColumn, secondCollumn, firstColumnPositionX, secondColumnPositionX, positionY, index);

                if (index == 0) SaveSupplier(secondCollumn, model);
                else if (index == secondCollumn.Count) break;

                GUI.OverWriteWithSpaces(secondCollumn[index].Length, secondColumnPositionX, (positionY + index));
                secondCollumn[index] = GetValueInput(properties[index], secondColumnPositionX);
            }
        }

        private static void SaveSupplier(List<string> secondColumn, Supplier suplier)
        {
            string saveOutput = "";
            if (Helpers.ColumnValueNotEmpty(secondColumn))
                saveOutput = "Could not save values, some values are empty";
            else
            {
                suplier.Name = secondColumn[1];
                suplier.ContactPerson = secondColumn[2];
                suplier.PhoneNumber = secondColumn[3];
                suplier.Email = secondColumn[4];
                suplier.StreetAdress = secondColumn[5];
                suplier.ZipCode = Convert.ToInt32(secondColumn[6]);
                //suplier.City = secondColumn[7];
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

        internal static string GetValueInput(PropertyInfo edit, int positionX)
        {
            string value = "";
            switch (edit.Name)
            {
                case nameof(Name):
                case nameof(StreetAdress):
                case nameof(Email):
                    value = Input.GetStringFirstLeterInEachWordUpperInput(positionX);
                    break;
                case nameof(City):
                    value = Input.GetStringFirstUpperInput(positionX);
                    break;
                case nameof(ZipCode):
                    value = Input.GetIntAsStringInput(10000, 99999, positionX);
                    break;
                case nameof(PhoneNumber):
                    value = Input.GetPhonenumberInput(positionX);
                    break;
                case nameof(ContactPerson):
                    value = Input.GetStringFirstUpperInput(positionX);
                    Console.Write(value);
                    value += " " + Input.GetStringFirstUpperInput(positionX + value.Length + 1);
                    break;
            }
            return value;
        }
    }
}
