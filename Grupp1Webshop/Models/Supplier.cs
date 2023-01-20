using Grupp1Webshop.Data;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        internal static int GetProductChoice(List<Supplier> model)
        {
            if (model.Count < 1)
            {
                Console.WriteLine("There is no Suppliers");
                Console.ReadKey();
                return -1;
            }
            return Menu.EditMenu(Helpers.ConvertClassListToStringList(model));
        }

        internal static void UpdateSupplier()
        {
            List<Supplier> suppliers = Helpers.GetSuppliersFromDb();
            int index = GetProductChoice(suppliers);
            if (index != -1)
            {
                EditSupplier(suppliers[index]);
            }
        }

        internal static void RemoveSupplier()
        {
            List<Supplier> suppliers = Helpers.GetSuppliersFromDb();
            int index = GetProductChoice(suppliers);
            if (index != -1)
            {
                Helpers.DeleteModel(suppliers[index]);
            }
        }

        internal static void EditSupplier(Supplier model)
        {
            //Get List of prop names and prop values
            PropertyInfo[] properties = model.GetType().GetProperties();
            List<string> firstColumn = Helpers.AddMenuChoicesForProp(Helpers.GetPropertyNames(properties));
            List<string> secondCollumn = Helpers.AddMenuChoicesForValues(Helpers.GetPropertyValues(model, properties));

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

        private static void SaveSupplier(List<string> secondColumn, Supplier supplier)
        {
            string saveOutput = "";
            if (Helpers.ColumnValueEmpty(secondColumn))
                saveOutput = "Could not save values, some values are empty";
            else
            {
                using (var db = new Context())
                {
                    var dbSuppliers = db.Suppliers;
                    Supplier dbSupplier = dbSuppliers.ToList().SingleOrDefault(a => a.Id == supplier.Id);
                    if (dbSupplier == null)
                    {
                        dbSuppliers.Add(supplier);
                    }
                    else supplier = dbSupplier;

                    supplier.Name = secondColumn[1];
                    supplier.ContactPerson = secondColumn[2];
                    supplier.PhoneNumber = secondColumn[3];
                    supplier.Email = secondColumn[4];
                    supplier.StreetAdress = secondColumn[5];
                    supplier.ZipCode = Convert.ToInt32(secondColumn[6]);
                    string cityFromColumn = secondColumn[7];

                    var dbCities = db.Cities;
                    City dbCity = dbCities.ToList().SingleOrDefault(a => a.Name == cityFromColumn);
                    if (dbCity == null)
                    {
                        dbCity = new City()
                        {
                            Name = cityFromColumn
                        };

                        dbCities.Add(dbCity);
                    }
                    supplier.City = dbCity;

                    try
                    {
                        db.SaveChanges();
                        saveOutput = "Save success";
                    }
                    catch (Exception ex)
                    {
                        saveOutput = "Could not save values to database" + ex;
                    }
                }
            }
            Console.WriteLine("\n\n" + saveOutput);
            Console.ReadKey();
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
