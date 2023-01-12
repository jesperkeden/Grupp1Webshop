using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Grupp1Webshop
{
    internal class Context : DbContext
    {
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\something; Database=something; Trusted_connection=True;");
        }
    }

    //Packet Manager
    // add-migration namnpåmigration
    // update-database
}
