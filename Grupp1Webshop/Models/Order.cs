using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop.Models
{
    internal class Order
    {
        public Order()
        {
            Product = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string PaymenthMethod { get; set; }
        public string Shipping { get; set; }
        public double ShippingCost { get; set; }
        public double TotalCost { get; set; }
        public User User { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
