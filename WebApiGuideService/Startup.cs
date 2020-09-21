using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebApiGuideService.Data;
using WebApiGuideService.Data.Implementations;
using WebApiGuideService.Data.Interfaces;
using WebApiGuideService.Data.Repository;

namespace WebApiGuideService
{
    public class Startup
    {
        public Startup(IConfiguration configuration,IWebHostEnvironment hostEnv)
        {
            Configuration = configuration;
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build(); // получаем строку подключение к базе данных в файле конфигурации dbsettings
        }

        public IConfiguration Configuration { get; }
        private IConfigurationRoot _confString;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(optionsAction=> optionsAction.UseSqlServer(_confString.GetConnectionString("DefaultConnection"))); //Регистрация класса AppDbContext и доступа к базе данных через строку подключения
            services.AddTransient<IGuideData, GuideDataRepository>(); //Регистрация зависимости реализации интерфейса IGuideData
            services.AddControllers();
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

            using (var scope = app.ApplicationServices.CreateScope()) // Выделение области для работы с базой данных и сама ее инициализация
            {AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>(); DBObjects.Initial(content); }
            
        }
    }
}
