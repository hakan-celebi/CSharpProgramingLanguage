using Ders_1_.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Ders_1_
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            /*Proje varsayılan olarak başlangıçta database aramak için bakmaktadır. Biz context.Database.Initialize(true) satırı ile database oluşturmasını da configure
            etmiş olduk. Database.SetInitializer satırında ise, Web.Config içerisine <entityFramework> tagleri arasına yazdığımız Context için Initializer atama
            kısmını yazmış olduk.*/
            Database.SetInitializer<OrderContext>(new OrderInitializer());
            using (var context = new OrderContext())
            {
                context.Database.Initialize(true);
            }
        }
    }
}
