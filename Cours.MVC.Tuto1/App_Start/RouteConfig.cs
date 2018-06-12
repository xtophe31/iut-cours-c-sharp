using System.Web.Mvc;
using System.Web.Routing;

namespace Cours.MVC.Tuto1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Ajouter",
                url: "Calculer-{action}/{param1}/{param2}",
                defaults: new {controller = "Calculer", Action= "Ajouter", param1 = 0, param2 = 0},
                constraints: new {param1 = @"\d", param2 = @"\d"});

            routes.MapRoute(
                name: "AjouterSansController",
                url: "{action}/{param1}/{param2}",
                defaults: new { controller = "Calculer", Action = "Ajouter", param1 = 0, param2 = 0 },
                constraints: new { param1 = @"\d+", param2 = @"\d+" });

            routes.MapRoute(
                name: "AjouterAvecController",
                url: "{controller}/{action}/{param1}/{param2}",
                defaults: new { controller = "Calculer", Action = "Ajouter", param1 = 0, param2 = 0 },
                constraints: new { param1 = @"\d+", param2 = @"\d+" });

             // attention à l'ordre

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HelloWorld", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
