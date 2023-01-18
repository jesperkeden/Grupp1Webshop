using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Models;

namespace Grupp1Webshop.Gammalt
{
    internal class NewProduct
    {
        public NewProduct()
        {
            Color = new HashSet<Color>();
            Size = new HashSet<Size>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Color> Color { get; set; }
        public virtual ICollection<Size> Size { get; set; }
        public Category Category { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
