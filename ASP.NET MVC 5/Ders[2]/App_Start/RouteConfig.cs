using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ders_2_
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "RouteTest",
                url: "RouteTest/{action}/{olay}",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional, olay = UrlParameter.Optional},
                constraints:  new {olay = @"\d{2}.\d{2}.\d{4}", method = new HttpMethodConstraint("GET", "POST") }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }             
            );

            
        }
    }
}
