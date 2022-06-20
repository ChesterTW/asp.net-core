using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopWebsite.Data;
using ShopWebsite.Repository;
using ShopWebsite.Services;

namespace ShopWebsite
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
            services.AddControllersWithViews();
            services.AddScoped(typeof(IRepository<>),typeof(Repositories<>));
            services.AddScoped(typeof(IService<>),typeof(Service<>));
            services.AddDbContext<ShopWebContext>(options => options.UseMySql(Configuration.GetConnectionString("conn"),new MySqlServerVersion(new Version(8,0,27))));
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>{
                //瀏覽器會限制cookie 只能經由HTTP(S) 協定來存取
                option.Cookie.HttpOnly = true;
                //登入頁，未鄧入時會自動導到登入頁
                option.LoginPath = new PathString("/Account/Login");
                //登出網頁(可以省略)
                option.LogoutPath = new PathString("/Account/Logout");
                //登入有效時間
                option.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                });        
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

            app.UseRouting();
            
            //啟用 cookie 原則功能
            app.UseCookiePolicy();
            //啟用身分識別
            app.UseAuthentication();
            //啟用授權功能
            app.UseAuthorization();
            // 這三個前後次序不能對調喔

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
