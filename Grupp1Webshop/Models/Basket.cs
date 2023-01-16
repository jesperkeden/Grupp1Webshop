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
            this.Users = new HashSet<User>();
            this.Products = new HashSet<Product>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int? ProductId { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
