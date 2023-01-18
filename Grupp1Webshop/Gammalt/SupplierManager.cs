using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop.Gammalt
{
    internal class SupplierManager
    {
        public static List<Supplier> Suppliers { get; set; }

        public static List<Supplier> GetAllSuppliers()
        {
            if (Suppliers == null || !Suppliers.Any())
            {
                Suppliers = new List<Supplier>()
                {
                    new Supplier()
                    {
                        Name = "Robins klänningar",
                        ContactPerson = "Robin",
                        PhoneNumber = "0708759983",
                        Email = "jesper.keden@hotmail.com",
                        StreetAdress = "Storgatan 6",
                        ZipCode = 61335,
                        //City = 
                    }
                };
            }
            return Suppliers;
        }
    }
}

