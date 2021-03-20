namespace Gepa.Server.Infra.Data.Settings
{
    public class GepaMongoDBSettings : IGepaMongoDBSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}