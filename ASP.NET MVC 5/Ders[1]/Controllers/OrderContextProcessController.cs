using Ders_1_.DAL;
using Ders_1_.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ders_1_.Controllers
{
    public class OrderContextProcessController : Controller
    {
        private OrderContext db = new OrderContext();
        // GET: OrderContextProcess
        public ActionResult Index(string CategoryName = "Computer")
        {
            //List<Product> products = (from P in db.Products where P.Category.Type == CategoryName select P).ToList();
            //List<Product> products = db.Products.Where(p => p.Category.Type == CategoryName).ToList(); //Üst kodun alternatifi
            //IEnumerable<Product> products = db.Products.ToList(); Tüm verileri alma
            //List<Product> products = db.Products.ToList(); Tüm verileri alma
            //IQueryable products = db.Products.Include(p => p.Category); Tüm verileri alma
            IEnumerable<Product> products = db.Products.ToList();
            /* Update First Way
            int CategoryID = (from C in db.Categories where C.Type == CategoryName select C.Id).FirstOrDefault();
            db.Products.Find(CategoryID).Pay = 69000;
            db.SaveChanges();
            */
            /* Update Second Way
            int CategoryID = (from C in db.Categories where C.Type == CategoryName select C.Id).FirstOrDefault();
            Product product = db.Products.Find(CategoryID);
            product.Pay = 42000;
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            */
            /* Insert Second Way
            Product product = new Product() { Name = "RTX 3090 Ti", Pay = 31000, CreatedDate = DateTime.Today, Category = db.Categories.Find(7), CategoryID = 7 };
            db.Entry(product).State = EntityState.Added;
            db.SaveChanges();
            */
            return View(products);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }
    }
}