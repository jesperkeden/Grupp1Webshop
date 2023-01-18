using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop.Gammalt
{
    internal class UserManager
    {
        public static List<User> Users { get; set; }

        public static List<User> GetAllUsers()
        {
            if (Users == null || !Users.Any())
            {
                Users = new List<User>()
                {
                    new User()
                    {
                        Admin = true,
                        //Username = blabla
                        //Password = blanla
                        FirstName = "Jesper",
                        LastName = "Keden",
                        Email = "koko@hotmail.com",
                        Age = 33,
                        PhoneNumber = "0708759983",
                        StreetAdress = "Storgatan 6",
                        ZipCode = 61335,
                        //City = 
                        Order = new List<Order>()
                        {

                        }
                    }
                };
            }
            return Users;
        }
    }
}