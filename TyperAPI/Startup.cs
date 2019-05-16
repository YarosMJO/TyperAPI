using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TyperAPI.DAL.Models;
using TyperAPI.Shared.Configs;

namespace TyperAPI
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TyperContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            var config = new AutoMapperConfiguration().Configure().CreateMapper();
            services.AddSingleton(sp => config);

          // add IOW
          // add base service

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddFluentValidation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logFac)
        {
            logFac.AddConsole(Configuration.GetSection("Logging"));
            logFac.AddDebug();

            app.UseCors(builder =>
                builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials().AllowAnyOrigin().SetIsOriginAllowedToAllowWildcardSubdomains());
            app.UseMvc();
        }
    }
}
