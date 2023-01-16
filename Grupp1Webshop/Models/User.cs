using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Grupp1Webshop.Models
{
    internal class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Admin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAdress { get; set; }
        public int ZipCode { get; set; }
        [ForeignKey("City")]
        public int? CityId { get; set; }
        public City City { get; set; }
        public Order Order { get; set; }
        public Basket Basket { get; set; }


        internal static void CreateUser()
        {
            EditUser(new User());
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

        internal static List<string> GetPropertyValues(User user, PropertyInfo[] properties)
        {
            List<string> propertyValues = new List<string>();

            for (int i = 1; i < (properties.Length); i++)
            {
                try
                {
                    propertyValues.Add(properties[i].GetValue(user).ToString());
                }
                catch
                {
                    propertyValues.Add("Empty");
                }
            }
            return propertyValues;
        }

        internal static void EditUser(User model)
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

                if (index == 0) SaveUser(secondCollumn, model);
                else if (index == secondCollumn.Count) break;

                GUI.OverWriteWithSpaces(secondCollumn[index].Length, secondColumnPositionX, (positionY + index));
                secondCollumn[index] = GetValueInput(properties[index], secondColumnPositionX);
            }
        }

        private static void SaveUser(List<string> secondColumn, User user)
        {
            string saveOutput = "";
            if (Helpers.ColumnValueNotEmpty(secondColumn))
                saveOutput = "Could not save values";
            else
            {
                user.Admin = Convert.ToBoolean(secondColumn[1]);
                user.FirstName = secondColumn[2];
                user.LastName = secondColumn[3];
                user.Email = secondColumn[4];
                user.Age = Convert.ToInt32(secondColumn[5]);
                user.PhoneNumber = secondColumn[6];
                user.StreetAdress = secondColumn[7];
                user.ZipCode = Convert.ToInt32(secondColumn[8]);
                //user.City = userTemp[9];
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

            //return saveOutput;
        }

        internal static string GetValueInput(PropertyInfo edit, int positionX)
        {
            string value = "";
            switch (edit.Name)
            {
                case nameof(Admin):
                    value = Input.GetBoolAsString(positionX);
                    break;
                case nameof(FirstName):
                case nameof(LastName):
                case nameof(StreetAdress):
                case nameof(City):
                    value = Input.GetStringFirstUpperInput(positionX);
                    break;
                case nameof(Email):
                    value = Input.GetStringLowerInput(positionX);
                    break;
                case nameof(Age):
                    value = Input.GetIntAsStringInput(18, 120, positionX);
                    break;
                case nameof(ZipCode):
                    value = Input.GetIntAsStringInput(10000, 99999, positionX);
                    break;
                case nameof(PhoneNumber):
                    value = Input.GetPhonenumberInput(positionX);
                    break;
            }
            return value;
        }
    }


    //Console.WriteLine("Input first name: Jesper");
    //string firstName = Console.ReadLine();
    //Console.WriteLine("Input last name: ");
    //string lastName = Console.ReadLine();
    //Console.WriteLine("Input email: ");
    //string email = Console.ReadLine();
    //Console.WriteLine("Input age: ");
    //int age = Input.GetDigitInput(18, 100); 
    //Console.WriteLine("Input phonenumber: ");
    //string phoneNumber = Input.GetPhonenumberInput(); 
    //Console.WriteLine("Input streetadress: ");
    //string streetAdress = Console.ReadLine();
    //Console.WriteLine("Input zipcode: "); // Gör en ny metod
    //string zipCode = Console.ReadLine();
    //Console.WriteLine("Input city: ");
    //string city = Console.ReadLine();
    //Console.WriteLine("Admin? true/false");
    //string admin = Console.ReadLine(); //kolla efteråt ifall det är true/false och uppdatera boolen. 

    //using (var context = new context())
    //{
    //    var newUser = new User()
    //    {
    //        FirstName = firstName,
    //        LastName = lastName,
    //        Email = email,
    //        Age = age,
    //        PhoneNumber = phoneNumber,
    //        StreetAdress = streetAdress,
    //        ZipCode = zipCode,
    //        CityId = 1,
    //        Admin = kolla senare

    //    };
    //    context.User.Add(newUser);
    //    context.SaveChanges();
    //}

    //}
}
