using Gepa.Server.Domain.Common;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Gepa.Server.Infra.Data.Configurations.Common
{
    public static class EntityTypeConfiguration
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<Entity>(map =>
            {
                map.AutoMap();
                map.MapCreator(t => new Entity(t.Id));
                map.MapIdMember(t => t.Id).SetIdGenerator(CombGuidGenerator.Instance);
                map.SetIsRootClass(true);
            });
        }
    }
}