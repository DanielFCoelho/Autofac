using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Autofac;
using Autofac.Extensions.DependencyInjection;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public ILifetimeScope AutofacContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CarRentContext>(opt => opt.UseInMemoryDatabase("RentCar"));
            services.AddControllers();
            services.AddOptions(); // Necessário para injetar o container do AutoFac
            services.AddSwaggerGen(k =>
            {
                k.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = "Rent a Car",
                        Version = "v1"
                    });
            });

            var builder = new ContainerBuilder();
            builder.RegisterModule(new Infra.Containers.InfraInjectionContainer());
            builder.RegisterModule(new Service.Containers.ServiceInjectionContainer());
            builder.Populate(services);

            AutofacContainer = builder.Build();

            return new AutofacServiceProvider(AutofacContainer);
        }

        public void ConfigureContainers(ContainerBuilder builder)
        {
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(k => k.SwaggerEndpoint("/swagger/v1/swagger.json", "Rent a Car - v1"));

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

       
        }
    }
}
