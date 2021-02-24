using System;
using System.Collections.Generic;
using Gepa.Server.Doamin.Calendar;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Teachers;

namespace Gepa.Server.Domain.Calendar
{
    public record SchoolCalendar(Guid Id, string Observation, string Name,
    IReadOnlyCollection<SchoolEvent> SchoolEvents, Guid TeacherId)
        : Entity(Id)
    {
        public virtual Teacher Teacher { get; init; }
    }
}
