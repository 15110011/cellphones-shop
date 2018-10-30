using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MobileStore.Data.Interfaces;
using MobileStore.Data.Mocks;
using MobileStore.Data.Models;
using MobileStore.Data.Repository;

namespace MobileStore
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            //Configuration = configuration;
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json") 
                .Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddTransient<IPhoneRepository, PhoneRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<MobileStoreDbContext>(options =>
            options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));
            services.AddMemoryCache();
            services.AddSession();
        }
         
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseSession();
            //app.UseIdentity();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();  

            app.UseMvc(routes =>
            {
                routes.MapRoute(name:"categoryFilter",template:"Phone/{Action}/{category?}",defaults:new { Controller="Phone", action="List" });
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
