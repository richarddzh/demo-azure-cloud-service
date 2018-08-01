using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebRole.App_Start
{
    public class RouteConfig
    {
        public static void Register(RouteCollection routes)
        {
            routes.MapRoute("default-mvc", "{controller}/{action}", new { controller = "Home", action = "Index" });
        }
    }
}