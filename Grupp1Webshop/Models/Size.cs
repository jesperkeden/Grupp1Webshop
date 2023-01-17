using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop.Models
{
    internal class Size
    {
        public Size()
        {
            NewProducts = new HashSet<NewProduct>();
        }
        public int? Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<NewProduct> NewProducts { get; set; }
    }
}
