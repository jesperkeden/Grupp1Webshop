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
        public DbSet<OrderProduct> OrderProducts { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server = tcp:myserverjesper.database.windows.net, 1433; Initial Catalog = grupp1webshop; Persist Security Info = False; User ID = jesperadmin; Password = !jespersystem22; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Grupp1Webshop;Trusted_Connection=True;");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<OrderProduct>()
        //        .HasKey(op => op.Id);
        //    modelBuilder.Entity<OrderProduct>()
        //        .Property(op => op.Quantity)
        //        .IsRequired();
        //    modelBuilder.Entity<OrderProduct>()
        //        .HasOne(op => op.Order)
        //        .WithMany(p => p.Products)
        //        .HasForeignKey(op => op.OrderId);
        //    modelBuilder.Entity<OrderProduct>()
        //        .HasOne(op => op.Product)
        //        .WithMany(o => o.Orders)
        //        .HasForeignKey(op => op.ProductId);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => op.Id);
            //modelBuilder.Entity<OrderProduct>()
            //    .Property(op => op.Quantity)
            //    .IsRequired();
            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(p => p.Products)
                .HasForeignKey(op => op.OrderId);
            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Product)
                .WithMany(o => o.Orders)
                .HasForeignKey(op => op.ProductId);
        }
    }

    //Packet Manager
    // add-migration namnpåmigration
    // update-database
}
