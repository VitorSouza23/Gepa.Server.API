namespace Gepa.Server.Infra.Data.Settings
{
    public interface IGepaMongoDBSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}