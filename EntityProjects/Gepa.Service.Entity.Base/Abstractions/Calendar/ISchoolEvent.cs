using System;
using System.Collections.Generic;
using System.Text;

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
