﻿using System;
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
        public int PhoneNumber { get; set; }
        public bool Admin { get; set; }
        public string StreetAdress { get; set; }
        public int ZipCode { get; set; }
        public int CityId { get; set; }


    }
}