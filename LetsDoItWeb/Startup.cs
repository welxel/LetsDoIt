using AppCore.DataAccess.Configs;
using Business.Services;
using Business.Services.Bases;
using Business.Services.Bases.MobillAppBase;
using Business.Services.MobilAppServices;
using DataAccess.EntityFramework.Contexts;
using DataAccess.EntityFramework.Repositories;
using DataAccess.EntityFramework.Repositories.Bases;
using DataAccess.Repositories;
using DataAccess.Repositories.Bases;
using LetsDoItWeb.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDoItWeb {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddControllersWithViews();
            #region ConnectionString
            ConnectionConfig.ConnectionString = Configuration.GetConnectionString("ETradeContext");
            services.AddMemoryCache();
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            #endregion
            #region IoC Container
            services.AddScoped<DbContext, ETradeContext>();

            services.AddScoped<UserRepositoryBase, UserRepository>();
            services.AddScoped<Business.Services.IUserService, UserService>();

            services.AddScoped<TodoRepositoryBase, TodoRepository>();
            services.AddScoped<ITodoService, TodoService>();


            services.AddScoped<TodoEventRepositoryBase, TodoEventRepository>();
            services.AddScoped<ITodoEventService, TodoEventService>();

            services.AddScoped<CityRepositoryBase, CityRepository>();
            services.AddScoped<ICityService, CityService>();

            services.AddScoped<ContactRepositoryBase, ContactRepository>();
            services.AddScoped<IContactService, ContactService>();

            services.AddScoped<TownRepositoryBase, TownRepository>();
            services.AddScoped<ITownService, TownService>();

            services.AddScoped<UserFriendRepositoryBase, UserFriendRepository>();
            services.AddScoped<IUserFriendService, UserFriendService>();


            #endregion

            services.AddSession();

            services.AddMvc().AddSessionStateTempDataProvider();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<SessionHelper>();
            services.AddSingleton<FileHelper>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            //Error eklenecek.
            else {
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseSession();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }


    }
}
