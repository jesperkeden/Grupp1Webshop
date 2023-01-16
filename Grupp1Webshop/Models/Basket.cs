using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop.Models
{
    internal class Basket
    {
        public Basket()
        {
            this.Products = new HashSet<Product>();
            this.Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("User")]
        public ICollection<Product> Products { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
