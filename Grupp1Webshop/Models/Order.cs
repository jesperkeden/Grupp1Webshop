using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Data;
using Grupp1Webshop.Models;

namespace Grupp1Webshop.Models
{
    internal class Order
    {
        //public Order()
        //{
        //    Products = new HashSet<Product>();
        //}

        public int Id { get; set; }
        public string PaymenthMethod { get; set; }
        public string Shipping { get; set; }
        public double ShippingCost { get; set; }
        public double TotalCost { get; set; }
        public bool HasPayed { get; set; } = false;
        public User User { get; set; }
        public int UserId { get; set; }

        //public List<Order> OrderHistory { get; set; }
        //public virtual ICollection<Product> Products { get; set; }


        internal static void PayOrder(User user, List<Product> products, Order order)
        {
            string saveOutput = "";

            using (var db = new Context())
            {


                try
                {
                    order.HasPayed = true;
                    order.User = user;

                    var dbOrders = db.Orders;
                    Order dbOrder = dbOrders.ToList().SingleOrDefault(a => a.Id == order.Id);
                    if (dbOrder == null)
                    {
                        dbOrders.Add(dbOrder);
                    }

                    db.SaveChanges();
                    saveOutput = "Save success";
                }
                catch (Exception ex)
                {
                    saveOutput = "Could not save values to database\n\n" + ex;
                }
            }
            Console.WriteLine("\n\n" + saveOutput);
            Console.ReadLine();
        }
    }
}
