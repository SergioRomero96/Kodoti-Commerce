using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Catalog.Persistence.Database;
using Catalog.Service.Queries;
using Common.Logging;
using HealthChecks.UI.Client;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Catalog.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Inicializa la DB con Entity
            services.AddDbContext<ApplicationDBContext>(opts =>
               opts.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection"),
                   x => x.MigrationsHistoryTable("__EFMigrationsHistory","Catalog")
               )
            );


            //Registrar las dependencias para que este al nivel de los controladores
            //Para revisar si la DB esta operativa
            services.AddHealthChecks()
                .AddCheck("self", () => HealthCheckResult.Healthy())
                .AddDbContextCheck<ApplicationDBContext>();

            services.AddHealthChecksUI();
            
            services.AddMediatR(Assembly.Load("Catalog.Service.EventHandlers"));

            services.AddTransient<IProductQueryService, ProductQueryService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Configuración de Logs
            // Si no es entorno de desarrollo
            if (!env.IsDevelopment())
            {
                loggerFactory.AddSyslog(
                  Configuration.GetValue<string>("Papertrail:host"),
                  Configuration.GetValue<int>("Papertrail:port")
                );
            }

            app.UseRouting();

            app.UseAuthorization();

            //Exponer el enpoints
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/hc", new HealthCheckOptions()
                {
                    Predicate = _ => true,
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                });

                endpoints.MapHealthChecksUI();
                endpoints.MapControllers();
            });
        }
    }
}
