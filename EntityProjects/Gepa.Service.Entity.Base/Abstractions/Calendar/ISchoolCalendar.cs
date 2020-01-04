using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Service.Entity.Base.Abstractions.Calendar
{
    public interface ISchoolCalendar : IGepaEntity, IGepaObservation
    {
        string Name { get; }
        IList<ISchoolEvent> SchoolEvents { get; }
        long TeacherID { get; }
    }
}
