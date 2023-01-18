using Grupp1Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop.Gammalt
{
    internal class CityManager
    {
        public static List<City> Cities { get; set; }

        public static List<City> GetAllCities()
        {
            if (Cities == null || !Cities.Any())
            {
                Cities = new List<City>()
                {
                    new City()
                    {
                        Name = "Nyköping",
                    },
                    new City()
                    {
                        Name = "Stockholm"
                    },
                    new City()
                    {
                        Name = "Göteborg"
                    }
                };
            }
            return Cities;
        }
    }
}
