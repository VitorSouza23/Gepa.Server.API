using Gepa.Server.Domain.Teachers;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Gepa.Server.Infra.Data.Configurations.Teachers
{
    public static class TeacherEntityConfiguration
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<Teacher>(map =>
            {
                map.AutoMap();
                map.MapCreator(t => new Teacher(t.Id, t.Name, t.ClassPlans, t.Schools, t.SchoolCalendars));
            });
        }
    }
}