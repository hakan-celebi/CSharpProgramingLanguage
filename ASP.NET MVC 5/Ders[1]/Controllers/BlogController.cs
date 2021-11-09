using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ders_1_.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewData["Value1"] = "Abdullah";
            ViewBag.Val = "Test";
            return View();
        }
    }
}