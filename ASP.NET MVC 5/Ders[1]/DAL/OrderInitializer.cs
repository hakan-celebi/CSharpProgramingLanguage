using Ders_1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ders_1_.DAL
{
    public class OrderInitializer : System.Data.Entity.CreateDatabaseIfNotExists<OrderContext>
    {
        protected override void Seed(OrderContext context)
        {
            /*ID Değerleri normalde otomatik olarak atanması gerekirken ID değeri vermediğim zaman ID'ler aynı hatasını alıyorum. ID değeri versemm de kendisi ID değeri
             Atıyor.*/
            var categoryComputer = new Category { Id = 1, Type = "Computer" };
            var categoryPhone = new Category { Id = 2, Type = "Mobile Phone" };
            var categoryTelevision = new Category { Id = 3, Type = "Television" };
            context.Categories.Add(categoryComputer);
            context.Categories.Add(categoryPhone);
            context.Categories.Add(categoryTelevision);
            List<Product> products = new List<Product>()
            {
                new Product {Id = 1,  Name = "Asus FX-503VD", Pay = 6000, CategoryID = categoryComputer.Id, CreatedDate = new DateTime(2017, 01, 12) },
                new Product {Id = 2, Name = "Macbook Pro", Pay = 12000, CategoryID = categoryComputer.Id, CreatedDate = new DateTime(2021, 04, 29) },
                new Product {Id = 3, Name = "Samsung Galaxy Note 11 Pro", Pay = 16000, CategoryID = categoryPhone.Id, CreatedDate = new DateTime(2020, 09, 21) },
                new Product {Id = 4, Name = "Xiaomi Note  Pro", Pay = 5000, CategoryID = categoryPhone.Id, CreatedDate = new DateTime(2019, 07, 18) },
                new Product {Id = 5, Name = "TLC EF64K", Pay = 7000, CategoryID = categoryTelevision.Id, CreatedDate = new DateTime(2019, 04, 06) },
            };
            products.ForEach(product => context.Products.Add(product));
            context.SaveChanges();
        }
    }
}