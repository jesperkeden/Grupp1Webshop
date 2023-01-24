using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Data;
using Grupp1Webshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Grupp1Webshop.Models
{
    internal class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PaymenthMethod { get; set; }
        public string Shipping { get; set; }
        public double ShippingCost { get; set; }
        public double TotalCost { get; set; }
        public bool HasPayed { get; set; } = false;
        public User User { get; set; }
        public List<OrderProduct> Products { get; set; }




        //internal static Order PayOrder(User user, List<Product> products, Order order)
        //{
        //    string saveOutput = "";

        //    using (var db = new Context())
        //    {

        //        order.HasPayed = true;

        //        Console.WriteLine(order.Id + " " + order.PaymenthMethod + " " + order.Shipping + " " + order.ShippingCost + " " + order.TotalCost + " " + order.HasPayed + " " + order.User + " "/* + order.UserId + " "*/ + order.Products);
        //        Console.ReadLine();
        //        try
        //        {
        //            var dbProducts = db.Products;
        //            foreach (Product product in products)
        //            {
        //                Product dbProduct = dbProducts.ToList().SingleOrDefault(a => a.Id == product.Id);
        //                if (dbProduct == null)
        //                {
        //                    dbProducts.Add(dbProduct);
        //                }
        //                order.Products.Add(dbProduct);
        //            }


        //            var dbUsers = db.Users;
        //            User dbUser = dbUsers.ToList().SingleOrDefault(a => a.Id == user.Id);
        //            order.User = dbUser;

        //            var dbOrders = db.Orders;
        //            Order dbOrder = dbOrders.ToList().SingleOrDefault(a => a.Id == order.Id);
        //            if (dbOrder != null)
        //            {
        //                throw new Exception("Order ID already Exist");
        //            }
        //            dbOrders.Add(order);

        //            db.SaveChanges();
        //            saveOutput = "Your purchase has been made!";
        //        }
        //        catch (Exception ex)
        //        {
        //            saveOutput = "Your purchase could not be completed, please contact Admin!\n\n" + ex;
        //            order.HasPayed = false;
        //        }
        //    }
        //    Console.WriteLine("\n\n" + saveOutput);
        //    return order;
        //}

        internal static Order PayOrder(User user, List<Product> products, Order order)
        {
            string saveOutput = "";

            using (var db = new Context())
            {
                order.HasPayed = true;

                try
                {
                    var dbProducts = db.Products;
                    var dbOrderProducts = db.OrderProducts;
                    foreach (Product product in products)
                    {
                        Product dbProduct = dbProducts.ToList().SingleOrDefault(a => a.Id == product.Id);
                        dbProduct.Quantity --;
                        dbProduct.UnitSold++;

                        var orderProduct = new OrderProduct() { Order = order, Product = dbProduct};
                        dbOrderProducts.Add(orderProduct);
                    }

                    var dbUsers = db.Users;
                    User dbUser = dbUsers.ToList().SingleOrDefault(a => a.Id == user.Id);
                    order.User = dbUser;

                    var dbOrders = db.Orders;
                    Order dbOrder = dbOrders.ToList().SingleOrDefault(a => a.Id == order.Id);
                    if (dbOrder != null)
                    {
                        throw new Exception("Order ID already Exist");
                    }
                    dbOrders.Add(order);

                    db.SaveChanges();
                    saveOutput = "Your purchase has been made!";
                }
                catch (Exception ex)
                {
                    saveOutput = "Your purchase could not be completed, please contact Admin!\n\n" + ex;
                    order.HasPayed = false;
                }
            }
            Console.WriteLine("\n\n" + saveOutput);
            Console.ReadLine();
            return order;
        }


        internal static void Receipt(Order order, List<string> basketInfo)
        {
            if (order.HasPayed)
            {

                for (int i = 0; i < basketInfo.Count; i++)
                {
                    GUI.WriteStringAtLocation(basketInfo[i], 50, 2 + i);
                }
                int counting = 0;
                //foreach ( Product product in order.Products)
                //{
                //    counting++;
                //    GUI.WriteStringAtLocation(product.Name.PadRight(40) + "Price: " + product.UnitPrice.ToString().PadRight(7) + "Color: " + product.Color.PadRight(18) + "Size: " + product.Size.PadRight(4), 1, counting);
                //}

                Console.ReadLine();
            }
            else Console.WriteLine("Order has not been completed!");
            Console.Clear();
        }

        internal static void OrderHistory(User user)
        {
            List<Order> orders = Querys.QGetSelectedOrder(user);
            if (orders.Count == 0)
            {
                GUI.WriteString("You Have no order history!");
                Console.ReadKey();
                return;
            }
            int index = Menu.EditMenu(Helpers.ConvertClassListToStringList(orders));
            Receipt(orders[index], Helpers.GetBasketInfoList(orders[index]));
        }
    }
}
