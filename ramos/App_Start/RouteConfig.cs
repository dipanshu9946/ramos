﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ramos
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //attribute route
            routes.MapMvcAttributeRoutes();

            //custom route
            //routes.MapRoute(
            //  "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { controller = "Movies" , action = "ByReleaseDate"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
