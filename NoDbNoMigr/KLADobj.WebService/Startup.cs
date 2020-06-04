using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using KLADobj.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using KLADobj.ApplicationServices.GetFreeListUseCase;
using KLADobj.ApplicationServices.Ports.Gateways.Database;
using KLADobj.ApplicationServices.Repositories;
using KLADobj.DomainObjects.Ports;

namespace KLADobj.WebService
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
            services.AddDbContext<KLADobjContext>(opts => 
                opts.UseSqlite($"Filename={System.IO.Path.Combine(System.Environment.CurrentDirectory, "KLADobj.db")}")
            );

            services.AddScoped<IKLADobjDatabaseGateway, KLADobjEFSqliteGateway>();

            services.AddScoped<DbKLADobjRepository>();
            services.AddScoped<IReadOnlyKLADobjRepository>(x => x.GetRequiredService<DbKLADobjRepository>());
            services.AddScoped<IKLADobjRepository>(x => x.GetRequiredService<DbKLADobjRepository>());


            services.AddScoped<IGetKLADobjListUseCase, GetKLADobjListUseCase>();

            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}