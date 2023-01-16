using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Grupp1Webshop.Models
{
    internal class User
    {
        public int Id { get; set; }
        public bool Admin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAdress { get; set; }
        public int ZipCode { get; set; }
        public City City { get; set; }


        internal static void CreateUser()
        {
            var newUser = new User();
            newUser.FirstName = "Robin";
            newUser.Age = 30;
            newUser.Admin = true;
            newUser.StreetAdress = "Adressen";
            newUser.PhoneNumber = "07893546";
            newUser.ZipCode = 1111;
            newUser.LastName = "Forsling";
            newUser.Email = "Emailadress";
            newUser.Id = 1;

            EditUser(newUser);
        }

        internal static List<string> GetPropertyNames(User user, PropertyInfo[] properties)
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
            List<string> firstColumn = Helpers.AddMenuChoicesForProp(GetPropertyNames(model, properties));
            List<string> secondCollumn = Helpers.AddMenuChoicesForValues(GetPropertyValues(model, properties));

            //Position of list in GUI
            int firstColumnPositionX = 3;
            int secondColumnPositionX = (Helpers.GetSecondCollumnPositionX(firstColumn) + firstColumnPositionX);
            int positionY = 2;

            //Edit prop values
            while (true)
            {
                int index = Menu.EditMenu(firstColumn, secondCollumn, firstColumnPositionX, secondColumnPositionX, positionY);

                if (index == 0) saveUser(secondCollumn, model);
                else if (index == 10) break;

                GUI.OverWriteWithSpaces(secondCollumn[index].Length, secondColumnPositionX, (positionY + index));
                secondCollumn[index] = EditUserChoices(index, secondColumnPositionX);
            }
        }

        private static void saveUser(List<string> userTemp, User user)
        {
            user.Admin = Convert.ToBoolean(userTemp[1]);
            user.FirstName = userTemp[2];
            user.LastName = userTemp[3];
            user.Email = userTemp[4];
            user.Age = Convert.ToInt32(userTemp[5]);
            user.PhoneNumber = userTemp[6];
            user.StreetAdress = userTemp[7];
            user.ZipCode = Convert.ToInt32(userTemp[8]);
            //user.City = userTemp[9];

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

        internal static string EditUserChoices(int edit, int positionX)
        {
            string value = "";
            switch (edit)
            {
                case 1:
                    value = Input.getBoolAsString(positionX);
                    break;
                case 2:
                case 3:
                case 7:
                case 9:
                    value = Input.GetStringFirstUpperInput(positionX);
                    break;
                case 4:
                    value = Input.GetStringLowerInput(positionX);
                    break;
                case 5:
                    value = Input.GetIntAsStringInput(18, 120, positionX);
                    break;
                case 8:
                    value = Input.GetIntAsStringInput(10000, 99999, positionX);
                    break;
                case 6:
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
