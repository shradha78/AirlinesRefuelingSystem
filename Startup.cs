using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Team_Mars_Backend.Data;
using Team_Mars_Backend.Data_Admin;
using Team_Mars_Backend.GraphQL;
using Team_Mars_Backend.GraphQL_Admin;
using Team_Mars_Backend.Repository;

namespace Team_Mars_Backend
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
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:Mars_Team"]));
            services.AddScoped<VendorRepository>();
            services.AddScoped<ARS_Schema>();
            //services.AddDbContext<AdminContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:MarsTeam"]));
            services.AddScoped<AdminRepository>();
            services.AddScoped<FuelRepository>();
            services.AddScoped<OrderRepository>();
            services.AddScoped<IServiceProvider>(s => new FuncServiceProvider(s.GetRequiredService)); // Iservice provider -> to create object of name class dynamically
            services.AddGraphQL().AddSystemTextJson().AddGraphTypes(ServiceLifetime.Scoped);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
                                DatabaseContext dbContext)
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
            dbContext.Seed();
 
            app.UseGraphQL<ARS_Schema>();
            app.UseGraphQLPlayground();
        }
    }
}
