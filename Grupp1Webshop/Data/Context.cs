using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Grupp1Webshop.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Grupp1Webshop.Data
{
    internal class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server = tcp:myserverjesper.database.windows.net, 1433; Initial Catalog = grupp1webshop; Persist Security Info = False; User ID = jesperadmin; Password = !jespersystem22; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Grupp1Webshop;Trusted_Connection=True;");
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Supplier>()
        //        .HasOptional<Product>(s => s.Product)
        //        .WithMany()
        //        .WillCascadeOnDelete(false);
        //}

    }

    //Packet Manager
    // add-migration namnpåmigration
    // update-database
}
