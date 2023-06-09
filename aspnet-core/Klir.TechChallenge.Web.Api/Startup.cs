using Klir.TechChallenge.App;
using Klir.TechChallenge.Provider;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlirTechChallenge.Web.Api
{
    public class Startup
    {
        readonly string AllowSpecificOrigins = "_allowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // In order to resolve CORS issue
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                        builder =>
                        {
                            builder.AllowAnyOrigin().AllowAnyHeader();
                        });
            });

            services.AddControllers();

            services.AddTransient<IProductManager, ProductManager>();
            services.AddTransient<IProductProvider, ProductProvider>();
            services.AddTransient<IOrderManager, OrderManager>();
            services.AddTransient<IOrderProvider, OrderProvider>();
            services.AddTransient<IPromotionHandlerFactory, PromotionHandlerFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // In order to resolve CORS issue
            app.UseCors(
               options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
               );

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
