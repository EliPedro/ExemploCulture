﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ResourcesGlobalization.Mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        
            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Globalization", action = "Index", id = UrlParameter.Optional }
            //Caso use Areas defina o namespace
            , namespaces: new[] { "ResourcesGlobalization.Mvc.Controllers" });
        }
    }
}
