using Gepa.Server.Infra.Data.Configurations.Common;
using Gepa.Server.Infra.Data.Configurations.Teachers;

namespace Gepa.Server.Infra.Data.Configurations
{
    public static class MongoDbPersistence
    {
        public static void Configure()
        {
            EntityTypeConfiguration.Configure();
            TeacherEntityConfiguration.Configure();
        }
    }
}