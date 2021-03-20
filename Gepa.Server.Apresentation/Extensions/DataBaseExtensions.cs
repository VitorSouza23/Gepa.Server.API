using Gepa.Server.Infra.Data.Configurations;
using Gepa.Server.Infra.Data.Contexts;
using Gepa.Server.Infra.Data.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Gepa.Server.Apresentation.Extensions
{
    public static class DataBaseCustomExtensions
    {
        public static void AddDataBaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<GepaMongoDBSettings>(configuration.GetSection(nameof(GepaMongoDBSettings)));
            services.AddSingleton<IGepaMongoDBSettings>(sp => sp.GetRequiredService<IOptions<GepaMongoDBSettings>>().Value);
            services.AddSingleton<MainContext>();
            MongoDbPersistence.Configure();
        }
    }
}