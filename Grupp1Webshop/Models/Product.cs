using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Models;

namespace Grupp1Webshop.Models
{
    internal class Product
    {
        public Product()
        {
            this.Baskets = new HashSet<Basket>();
            this.Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public string Size { get; set; }
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Basket> Baskets { get; set; }
    }
}
