using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Ders_2_
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Session_Start(object sender, EventArgs e)
        {
            int onlineMemberCount = (int)Application["OnlineMemberCount"];
            Application["OnlineMemberCount"] = onlineMemberCount + 1;            
        }
        protected void Session_End(object sender, EventArgs e)
        {
            int onlineMemberCount = (int)Application["OnlineMemberCount"];
            Application["OnlineMemberCount"] = onlineMemberCount - 1;
        }
        protected void Application_Start()
        {
            Application["OnlineMemberCount"] = 0;
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
