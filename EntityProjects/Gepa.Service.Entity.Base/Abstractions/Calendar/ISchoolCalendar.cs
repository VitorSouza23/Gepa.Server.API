using System.Collections.Generic;

namespace Gepa.Service.Entity.Base.Abstractions.Calendar
{
    public interface ISchoolCalendar : IGepaEntity, IGepaObservation
    {
        string Name { get; }
        IList<ISchoolEvent> SchoolEvents { get; }
        long TeacherID { get; }
    }
}
