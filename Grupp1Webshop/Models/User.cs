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

            int firstColumnPositionX = 3;
            int secondColumnPositionX = (Helpers.GetSecondCollumnPositionX(firstCollumn) + firstColumnPositionX);
            int positionY = 2;

            while (true)
            {
                int index = Menu.EditMenu(firstCollumn, secondCollumn, firstColumnPositionX, secondColumnPositionX, positionY);

                if (index == 0) saveUser(secondCollumn, user);
                else if (index == 10) break;

                GUI.OverWriteWithSpaces(secondCollumn[index].Length, secondColumnPositionX, (positionY + index));
                secondCollumn[index] = GetValueInput(properties[index], secondColumnPositionX);
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

        internal static string GetValueInput(PropertyInfo edit, int positionX)
        {
            string value = "";
            switch (edit.Name)
            {
<<<<<<< Updated upstream
                case 1:
                    value = Input.getBoolAsString(positionX);
=======
                case nameof(Admin):
                    value = Input.GetBoolAsString(positionX);
>>>>>>> Stashed changes
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
