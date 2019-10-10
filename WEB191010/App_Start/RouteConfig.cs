using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WEB191010
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            #region classic routing
            // / filmek / megjelenes / 2015 / 02
            //routes.MapRoute(
            //    "FilmekMegjelenesSzerint",
            //    "filmek/megjelenes/{ev}/{honap}",
            //    new { controller = "Filmek", action = "Megjelenes" },
            //    new { ev = @"\d{4}", honap = @"\d{2}" }
            //    );
            #endregion

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
