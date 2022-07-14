using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup (IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync(_config["MyKey"]);
            //    });
            //});

            //app.Use(async (context, next) =>
            //    {
            //        logger.LogInformation("MW1:incoming request");
            //        //await context.Response.WriteAsync("Hello from first middle ware!");
            //        await next();
            //        logger.LogInformation("MW1:outgoing request");
            //    });

            //app.Use(async (context, next) =>
            //{
            //    logger.LogInformation("MW2:incoming request");
            //    //await context.Response.WriteAsync("Hello from first middle ware!");
            //    await next();
            //    logger.LogInformation("MW2:outgoing request");
            //});

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World");
                //logger.LogInformation("MW3:Request Handled and response produced.");
            });
        }
    }
}
