namespace Sample.Web.Configuration
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{*pathInfo}",
                defaults: new { controller = "Post", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
