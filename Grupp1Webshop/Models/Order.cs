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
            this.Products = new HashSet<Product>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int? CustomerId { get; set; }
        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public string PaymentMethod { get; set; }
        public string Shipping { get; set; }
        public int ShippingCost { get; set; }
        public double TotalCost { get; set; }
        public string PlannedDelivery { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
