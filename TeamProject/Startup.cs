using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using TeamProject.Data;
using TeamProject.Data.interfaces;
using TeamProject.Data.Repository;
using TeamProject.Data.Models;

namespace TeamProject
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IWebHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IExecutor, ExecutorRepository>();
            services.AddTransient<IPlace, PlaceRepository>();
            services.AddTransient<IRequest, RequestRepository>();
            services.AddTransient<IResponsible, ResponsibleRepository>();
            services.AddTransient<IShop, ShopRepository>();
            services.AddTransient<ITechnic, TechnicRepository>();
            services.AddTransient<ITypeTechnic, TypeTechnicRepository>();
            services.AddTransient<IUser, UserRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => AddRequest.GetRequest(sp));
            services.AddScoped(sp => AddTechnic.GetTechnic(sp));

            IServiceCollection serviceCollections = services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddControllersWithViews().AddNewtonsoftJson();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();


            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                
                DBObjects.Initial(content);
            }

        }
    }
}
