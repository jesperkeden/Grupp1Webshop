using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Data;
using Grupp1Webshop.Models;

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
        public bool HasPayed { get; set; } = false;
        public Dictionary<int, Product> MyOrder { get; set; } 
        public User User { get; set; }
        public virtual ICollection<Product> Product { get; set; }

        public void CreateMyOrder()
        {
            using var db = new Context();
            var product = new Product();
            Dictionary<int, Product> MyOrder = new Dictionary<int, Product>();
        }


        public void AddToMyOrder(Dictionary<int, Product> MyOrder, Product product)
        {
            using var db = new Context();
            MyOrder.Add(User.Id, product);
            db.SaveChanges();
        }
    }
}
