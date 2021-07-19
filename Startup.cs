using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Routing.Constraints;


namespace TestWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            //app.UseMvc();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                // routes.MapRoute(name:"secure", template:"secure", defaults: new 
                // {
                //     Controller = "Admin", Action = "Index"
                // });
                
                routes.MapRoute(name:"default", template:"{controller=Home}/{action=Index}/{id:int?}");
                
                // routes.MapRoute(name:"default", template:"{controller}/{action}/{id}",
                //     defaults:new {controller = "Home", action = "Index"},
                //     constraints:new {id = new IntRouteConstraint()});

                // routes.MapRoute(name:"default",
                //     template:"post/{id:int}",
                //     defaults: new { controller = "Post", action = "PostsByID"});

                // routes.MapRoute(name:"anotherRoute",
                //     template:"post/{id:alpha}",
                //     defaults: new { controller = "Post", action = "PostsByPostName"});
            }); 

            app.Run(handler:async (context)=>
            {
               await context.Response.WriteAsync(text:"Failed to find route!");
            });
        }
    }
}
