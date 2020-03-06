using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ServiceQueueManagement.Core.Repositories;
using ServiceQueueManagement.Core.Services;
using ServiceQueueManagement.Data.Context;
using ServiceQueueManagement.Data.UOW;
using ServiceQueueManagement.Services;
using ServiceQueueManagement.Services.ServiceImp;

namespace ServiceQueueManagement
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
            services.AddControllers();

            string connectionString = Configuration["ConnectionStrings:connectionString"];
            services.AddDbContext<ServiceQueueDbContext>(o => o.UseSqlServer(connectionString));

            //services.AddDbContext<ServiceQueueDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("connectionString"), x => x.MigrationsAssembly("ServiceQueueManagement.Data")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICustomerServiceService, CustomerServiceService>();
            services.AddTransient<IAppoinmentService, AppoinmentService>();
            services.AddTransient<IEmployeeServiceService, EmployeeServiceService>();
            services.AddTransient<IServicesService, ServicesService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
