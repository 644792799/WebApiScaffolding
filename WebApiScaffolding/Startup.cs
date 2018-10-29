using Microsoft.Owin;
using WebApiScaffolding;

[assembly: OwinStartup(typeof(Startup))]
namespace WebApiScaffolding
{
    using System.Web.Http;
    using Microsoft.Owin;
    using Microsoft.Owin.Extensions;
    using Microsoft.Owin.FileSystems;
    using Microsoft.Owin.StaticFiles;
    using Owin;
    using System.Web.Http.Cors;
    using System;
    using System.Web.Http.Filters;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            try
            {
                var httpConfiguration = new HttpConfiguration();

                // Configure Web API Routes:
                // - Enable Attribute Mapping
                // - Enable Default routes at /api.
                httpConfiguration.MapHttpAttributeRoutes();
                httpConfiguration.Filters.Add(new MyFilter());
                httpConfiguration.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );

                app.UseWebApi(httpConfiguration);

                // Make ./public the default root of the static files in our Web Application.
                app.UseFileServer(new FileServerOptions
                {
                    RequestPath = new PathString(string.Empty),
                    FileSystem = new PhysicalFileSystem("./public"),
                    EnableDirectoryBrowsing = true,
                });

                app.UseStageMarker(PipelineStage.MapHandler);

                //Support for CORS
                EnableCorsAttribute CorsAttribute = new EnableCorsAttribute("*", "*", "*");
                httpConfiguration.EnableCors(CorsAttribute);
            }
            catch (Exception ex)
            {

            }
        }
    }

    class MyFilter : IFilter
    {
        public bool AllowMultiple
        {
            get
            {
                return true;
                //return Value
            }
        }
    }
}
