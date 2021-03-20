using Gepa.Server.Infra.Data.Settings;
using MongoDB.Driver;

namespace Gepa.Server.Infra.Data.Contexts
{
    public sealed class MainContext
    {
        private readonly IMongoDatabase _dataBase;
        public IMongoDatabase Database => _dataBase;
        public MainContext(IGepaMongoDBSettings gepaMongoDBSettings)
        {
            var client = new MongoClient(gepaMongoDBSettings.ConnectionString);
            _dataBase = client.GetDatabase(gepaMongoDBSettings.DatabaseName);
        }
    }
}