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
            var newCity = new City();
            newCity.Name = "Nyköping";
            newUser.FirstName = "Robin";
            newUser.Age = 30;
            newUser.Admin = true;
            newUser.StreetAdress = "Adressen";
            newUser.PhoneNumber = "07893546";
            newUser.ZipCode = 1111;
            newUser.LastName = "Forsling";
            newUser.Email = "Emailadress";
            newUser.Id = 1;

            List<string> newUserPropNamesList = Program.GetPropList(newUser);

            PropertyInfo[] properties = newUser.GetType().GetProperties();

            List<string> newUserPropValuesList = new List<string>();



            for (int i = 1; i < (newUserPropNamesList.Count + 1); i++)
            {
                try
                {
                    newUserPropValuesList.Add(properties[i].GetValue(newUser).ToString());
                }
                catch 
                {
                    newUserPropValuesList.Add("Empty");
                }
            }
            while (true)
            {
                EditMenu(newUserPropNamesList, newUserPropValuesList);
            }

            //Console.WriteLine(newUserPropValuesList[index]);
            

        }

        internal static void EditMenu(List<string> firstCollumn, List<string> secondCollumn)
        {
            string longestString = firstCollumn.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
            int firstColumnPositionX = 3;
            int secondColumnPositionX = (longestString.Length + firstColumnPositionX + 1);
            int index = 0;
            int positionY = 2;

            Console.CursorVisible = false;
            ConsoleKeyInfo keyPressed;
            do
            {
                GUI.PrintMenu("header", firstColumnPositionX, positionY, index, firstCollumn);
                GUI.PrintMenu("header", secondColumnPositionX, positionY, index, secondCollumn);

                keyPressed = Console.ReadKey();
                if
                    (keyPressed.Key == ConsoleKey.DownArrow && index != firstCollumn.Count - 1) index++;
                else if
                    (keyPressed.Key == ConsoleKey.UpArrow && index >= 1) index--;
            } while (keyPressed.Key != ConsoleKey.Enter);
            Console.CursorVisible = true;

            secondCollumn[index] = "";
            Console.Clear();

            GUI.PrintMenu("header", firstColumnPositionX, positionY, index, firstCollumn);
            GUI.PrintMenu("header", secondColumnPositionX, positionY, index, secondCollumn);

            Console.SetCursorPosition((secondColumnPositionX), (positionY + index));
            //secondCollumn[index] = Input.GetStringInput();
            
            return;
        }
        internal static void userEditChoices(int edit)
        {
            switch (edit)
            {
                case 0:
                    Input.getBoolAsString();
                    break;
                case 1:
                case 2:
                case 6:
                case 8:
                    Input.GetStringFirstUpperInput();
                    break;
                case 3:
                    Input.GetStringLowerInput();
                    break;
                case 4:
                case 7:
                    Input.GetIntAsStringInput();
                    break;
                case 5:
                    Input.GetPhonenumberInput();
                    break;
                   
            }
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
