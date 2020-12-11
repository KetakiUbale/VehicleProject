using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VehicleProject.Data1;
using VehicleProject.Data1.Model;
using VehicleProject.Persistence;
using VehicleProject.Service;
using VehicleProject.Service.Interface;

namespace VehicleProject.Web
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
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IVehicleInfoService, IVehicleInfoService>();
            services.AddTransient<IVehicleService, IVehicleService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<VehicleContext>();
            services.AddTransient<IRepository<User>, Repository<User>>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
