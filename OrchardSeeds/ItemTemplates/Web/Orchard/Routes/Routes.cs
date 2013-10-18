using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Routes;


namespace $rootnamespace$
{
    public class $safeitemname$ : IRouteProvider
    {
        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[]
            {
                new HttpRouteDescriptor()
                {
                    Name = "my api",
                    RouteTemplate = "api/{action}",
                    Defaults = new
                    {
                        controller = "<controller>",
                        area = "<module>"
                    }
                },
                new RouteDescriptor
                {
                    Route = new Route("Admin/myItem/{action}",
                        new RouteValueDictionary
                        {
                            {"area", "<module>"},
                            {"controller", "<controller>"},
                            {"action", "<default action>"}
                        }, new RouteValueDictionary(),
                        new RouteValueDictionary {{"area", "<module>"}},
                        new MvcRouteHandler())
                }
            };
        }

        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (RouteDescriptor route in GetRoutes())
            {
                routes.Add(route);
            }
        }
    }
}