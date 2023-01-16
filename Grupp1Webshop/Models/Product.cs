using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            this.Orders = new HashSet<Order>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        [ForeignKey("Supplier")]
        public int? SupplierId { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
