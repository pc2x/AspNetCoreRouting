using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Prueba3
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new MyViewLocationExpander());
            });

            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "site",
                    template: "{site=Admin}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "siteArea",
                    template: "{site=Admin}/{area:exists}/{controller=Home}/{action=Index}/{id?}");
                //routes.MapRoute(
                //    name: "areaRoute",
                //    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                //routes.MapRoute(
                //    name: "default",
                //    template: "{controller=Home}/{action=Index}/{id?}");
            });
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }


        public class MyViewLocationExpander : IViewLocationExpander
        {
            private const string Site = "site";

            public void PopulateValues(ViewLocationExpanderContext context)
            {
                context.ActionContext.ActionDescriptor.RouteValues.TryGetValue(Site, out var site);

                context.Values[Site] = site;
            }

            public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
            {
                //check if subarea key contain  
                if (!context.ActionContext.RouteData.Values.ContainsKey(Site)) return viewLocations;

                var site = RazorViewEngine.GetNormalizedRouteValue(context.ActionContext, Site);
                IEnumerable<string> subAreaViewLocation = new string[]
                {
                    //"/Areas/{2}/SubAreas/"+site+"/Views/{1}/{0}.cshtml"
                    $"/{site}/Areas/{{2}}/Views/{{1}}/{{0}}.cshtml",
                    $"/{site}/Views/{{1}}/{{0}}.cshtml"
                };

                return subAreaViewLocation;

                //return subAreaViewLocation.Union(viewLocations);

                //return viewLocations.Union(
                //    new[]
                //    {
                //            "Users/Areas/{2}/Views/{1}/{0}.cshtml",
                //            "/Users/Views/{1}/{0}.cshtml",
                //            "/Users/Shared/{0}.cshtml",
                //            "/Shared/Views/{0}.cshtml"
                //    });
            }
        }
    }
}
