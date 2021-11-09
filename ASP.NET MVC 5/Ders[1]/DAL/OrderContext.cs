using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Ders_1_.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ders_1_.DAL
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDatabase") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        /*Tablo isimlerini çoğullaştıma metodunu kaldırır.*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}