using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Models;

namespace Grupp1Webshop.Gammalt
{
    internal class NewUser
    {
        public NewUser()
        {

        }
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
        //public Basket Basket { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
