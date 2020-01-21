using System;

namespace Gepa.Service.Entity.Base.Abstractions.Calendar
{
    public interface ISchoolEvent : IGepaEntity, IGepaObservation
    {
        string Name { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        long SchollCalendarID { get; }
    }
}
