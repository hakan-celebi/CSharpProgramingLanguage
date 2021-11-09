using Ders_2_.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ders_2_.Controllers
{
#if !DEBUG
    [RequireHttps]
#endif
    public class HomeController : Controller
    {
        [OutputCache(Duration = 60, Location = System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult Index(int? a = 5)
        {
            MyType type = new MyType();
            type["test"] = 45;
            Session["NewSession"] = "value";
            HttpCookie cookie = new HttpCookie("NewCookie", "CookieValue");
            cookie.Expires = DateTime.Now.AddMinutes(1);
            HttpContext.Response.Cookies.Add(cookie);
            ViewBag.Time = HttpContext.Application["OnlineMemberCount"];
            return View(a);
        }

        [HttpPost, ActionName("Index"), Authorize(Users = "abdullah", Roles = "admin")]
        public ActionResult IndexConfirmed(int a = 5)
        {
            //string script = "alert('Clicked!');";
            //return JavaScript(script);
            //return File(@"C:\Users\hkncl\Desktop\a.pdf", "application/pdf");
            return View();
        }

        public ActionResult About(string olay)
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}