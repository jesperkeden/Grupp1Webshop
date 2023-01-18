using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Models;

namespace Grupp1Webshop.Models
{
    internal class City
    {
        public City()
        {
            Supplier = new HashSet<Supplier>();
            User = new HashSet<User>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
        public virtual ICollection<User> User { get; set; }

    }
}
