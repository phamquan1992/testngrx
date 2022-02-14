using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NgrxExample.Extention;
using NgrxExample.Repositories.IRepositories;
using NgrxExample.Repositories.Repositories;
using NgrxExample.Service.IService;
using NgrxExample.Service.ServiceImp;

namespace NgrxExample
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
            // In production, the Angular files will be served from this directory
            services.AddNHibernate(Configuration["ConnectionStrings:DefaultConnection"]);
            #region Repository
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBaidangRepository, BaidangRepository>();
            services.AddScoped<IChuyenmucRepository, ChuyenmucRepository>();
            services.AddScoped<ILuotxemRepository, LuotxemRepository>();
            services.AddScoped<ITaikhoanRepository, TaikhoanRepository>();
            services.AddScoped<ITheloaiRepository, TheloaiRepository>();
            #endregion
            #region Service
            services.AddScoped<IBaidangService, BaidangService>();
            services.AddScoped<IChuyenmucService, ChuyenmucService>();
            services.AddScoped<ILuotxemService, LuotxemService>();
            services.AddScoped<ITaikhoanService, TaikhoanService>();
            services.AddScoped<ITheloaiService, TheloaiService>();
            #endregion
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
