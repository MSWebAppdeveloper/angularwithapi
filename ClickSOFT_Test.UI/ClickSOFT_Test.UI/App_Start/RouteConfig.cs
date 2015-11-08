using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ClickSOFT_Test.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
       

            routes.MapRoute(
                      name: "dashboard",
                      url: "dashboard/{*url}",
                      defaults: new { controller = "dashboard", action = "Index" }
                  );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "dashboard", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}
