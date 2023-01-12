using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAdress { get; set; }
        public int ZipCode { get; set; }
        public int CityId { get; set; }
        public bool Admin { get; set; }

        public City City { get; set; } 
    }

    //internal static void CreateUser()
    //{
    //    Console.WriteLine("Input first name: ");
    //    string firstName = Console.ReadLine();
    //    Console.WriteLine("Input last name: ");
    //    string lastName = Console.ReadLine();
    //    Console.WriteLine("Input email: ");
    //    string email = Console.ReadLine();
    //    Console.WriteLine("Input age: ");
    //    int age = Input.GetDigitInput(18, 100); // Gör en ny metod
        //Console.WriteLine("Input phonenumber: ");
        //string phoneNumber = Input.GetPhonenumberInput(); // Gör en ny metod
    //    Console.WriteLine("Input streetadress: ");
    //    string streetAdress = Console.ReadLine();
    //    Console.WriteLine("Input zipcode: "); // Gör en ny metod
    //    string zipCode = Console.ReadLine();
    //    Console.WriteLine("Input city: ");
    //    string city = Console.ReadLine();
    //    Console.WriteLine("Admin? true/false");
    //    string admin = Console.ReadLine(); //kolla efteråt ifall det är true/false och uppdatera boolen. 

    //    using (var context = new context())
    //    {
    //        var newUser = new User()
    //        {
    //            FirstName = firstName,
    //            LastName = lastName,
    //            Email = email,
    //            Age = age,
    //            PhoneNumber = phoneNumber,
    //            StreetAdress = streetAdress,
    //            ZipCode = zipCode,
    //            CityId = 1,
    //            Admin = kolla senare

    //        };
    //        context.User.Add(newUser);
    //        context.SaveChanges();
    //    }

    //}
}
