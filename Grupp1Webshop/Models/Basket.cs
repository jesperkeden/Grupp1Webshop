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
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public User User { get; set; }
        public int Quantity { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
