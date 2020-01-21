using System.Collections.Generic;

namespace Gepa.Service.Entity.Base.Abstractions.SchoolClasses
{
    public interface ISchool : IGepaEntity
    {
        string Name { get; }
        IList<ISchoolClass> SchoolClasses { get; }
        long TeacherID { get; }
    }
}
