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

        internal static void EditUser(User user)
        {
            List<string> firstCollumn = Program.GetPropList(user);
            List<string> secondCollumn = new List<string>();
            PropertyInfo[] properties = user.GetType().GetProperties();

            for (int i = 1; i < (firstCollumn.Count + 1); i++)
            {
                try
                {
                    secondCollumn.Add(properties[i].GetValue(user).ToString());
                }
                catch
                {
                    secondCollumn.Add("Empty");
                }
            }
            firstCollumn.Insert(0, "Save All");
            firstCollumn.Add("Cancel");
            secondCollumn.Insert(0, "");

            while (true)
            {
                int index = Menu.EditMenu(firstCollumn, secondCollumn);

                if (index == 0) saveUser(secondCollumn, user);
                else if (index == 10) break;

                Console.SetCursorPosition(16, (2 + index));
                Console.Write(new string(' ', secondCollumn[index].Length));
                Console.SetCursorPosition(16, (2 + index));
                secondCollumn[index] = EditUserChoices(index);
                Console.Clear();
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

        internal static string EditUserChoices(int edit)
        {
            string value = "";
            switch (edit)
            {
                case 1:
                    value = Input.getBoolAsString();
                    break;
                case 2:
                case 3:
                case 7:
                case 9:
                    value = Input.GetStringFirstUpperInput();
                    break;
                case 4:
                    value = Input.GetStringLowerInput();
                    break;
                case 5:
                    value = Input.GetIntAsStringInput(18, 120);
                    break;
                case 8:
                    value = Input.GetIntAsStringInput(10000, 99999);
                    break;
                case 6:
                    value = Input.GetPhonenumberInput();
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
