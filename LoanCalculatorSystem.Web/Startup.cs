using LoanCalculatorSystem.Core.Repositories;
using LoanCalculatorSystem.Core.Services;
using LoanCalculatorSystem.Core.UnitOfWorks;
using LoanCalculatorSystem.Data.Repositories;
using LoanCalculatorSystem.Data.UnitOfWork;
using LoanCalculatorSystem.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LoanCalculatorSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace LoanCalculatorSystem.Web
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
           
           // services.AddScoped<NotFoundFilter>();
            services.AddAutoMapper(typeof(Startup));
           
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service.Services.Service<>));
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<ILoanService, LoanService>();
            services.AddScoped<IInvoiceService, InvoiceService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:SqlConStr"].ToString(), o =>
                {
                    o.MigrationsAssembly("LoanCalculatorSystem.Data");
                });
            });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
