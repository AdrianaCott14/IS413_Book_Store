using BookStore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //add connects to the connection string
            services.AddDbContext<BookStoreDBContext>(options =>
           {
               options.UseSqlite(Configuration["ConnectionStrings:BookStoreConnection"]);
           });

            //add scope service of a repository for each session
            services.AddScoped<IBookStoreRepository, EFBookStoreRepository>();

            //adding razor pages to our project
            services.AddRazorPages();

            services.AddDistributedMemoryCache();
            services.AddSession();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //sets up a session
            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("catpage",
                    "{category}/{pageNum:int}",
                    new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute("page",
                    "{pageNum:int}",
                    new { controller = "Home", action = "Index" });

                endpoints.MapControllerRoute("category",
                    "{category}",
                    new { controller = "Home", action = "Index", pageNum = 1 });

                endpoints.MapControllerRoute(
                   "pagination",
                   "Book/{pageNum}",
                   new { Controller = "Home", action = "Index" });

                endpoints.MapDefaultControllerRoute();

                //allows the routing system to handle razor pages
                endpoints.MapRazorPages();

            });

            SeedData.EnsurePopulated(app);

        }
    }
}
