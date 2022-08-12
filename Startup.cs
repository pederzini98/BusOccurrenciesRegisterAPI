using BusOcurrenciesAPI.Business;
using BusOcurrenciesAPI.Database;
using Microsoft.OpenApi.Models;

namespace BusOcurrenciesAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<APIOptions>(Configuration.GetSection(APIOptions.SectionName));//Load Settings

            services.AddHttpClient(); //HttpClientFactory
            services.AddOptions();
            services.AddSingleton<IMongoDbData, MongoDbData>();//Database access
            services.AddControllers();
            services.AddCors();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BusOcurrenciesAPI", Version = "v1" });
            });
            services.AddSingleton<IDataAccess, DataAccess>(); //Create the Main manager class/object

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BusOcurrenciesAPI v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
