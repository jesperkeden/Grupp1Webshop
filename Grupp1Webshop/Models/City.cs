using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop.Models
{
    internal class City
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<User> Users { get; set; }
        public Supplier Supplier { get; set; }
        public User User { get; set; }
    }
}
