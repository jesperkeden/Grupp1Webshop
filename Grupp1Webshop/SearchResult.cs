using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class SearchResult
    {
        public List<Product> Products { get; set; }
        public string Message { get; set; }
    }
}
