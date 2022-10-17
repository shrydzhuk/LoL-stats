using LoL.Stats.Application.PreProcessors;
using LoL.Stats.Application.Services.Matches;
using LoL.Stats.Application.Services.Summoners;
using LoL.Stats.Domain;
using LoL.Stats.Domain.MappingProfiles;
using LoL.Stats.Riot.Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.IO;
using System.Reflection;

namespace LoL.Stats.Api
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
            services.AddCors(options =>
            {
                options.AddPolicy("Cors", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LoL.Stats", Version = "v1" });
            });

            services.AddAutoMapper(typeof(SummonersProfile));

            services.AddScoped<ISummonersService, SummonersService>();
            services.AddScoped<IMatchesService, MatchesService>();
            services.AddSingleton<IStaticInfoHandler, StaticInfoHandler>();
            services.Configure<StaticFilesOptions>(Configuration.GetSection("StaticFiles"));

            RiotConfiguration.SetApiKey(Configuration["RiotApiKey"]);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env,
            IStaticInfoHandler staticInfoHandler,
            IOptions<StaticFilesOptions> staticFilesOptions)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LoL Stats v1"));
            }

            app.UseCors("Cors");
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            LoadStaticInfo(staticInfoHandler, staticFilesOptions);
        }

        private void LoadStaticInfo(
            IStaticInfoHandler staticInfoHandler,
            IOptions<StaticFilesOptions> staticFilesOptions)
        {
            string fullPath = Assembly.GetAssembly(typeof(Startup)).Location;
            string directory = Path.GetDirectoryName(fullPath);

            staticInfoHandler.LoadChampionsInfo($"{directory}\\{staticFilesOptions.Value.ChampionsInfoFile}");
            staticInfoHandler.LoadItemsInfo($"{directory}\\{staticFilesOptions.Value.ItemsInfoFile}");
        }
    }
}
