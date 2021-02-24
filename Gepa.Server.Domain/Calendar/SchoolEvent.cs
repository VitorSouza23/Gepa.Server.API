using System;
using Gepa.Server.Domain.Calendar;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Doamin.Calendar
{
    public record SchoolEvent(Guid Id, string Observation, string Name, DateTime StartDate,
    DateTime EndDate, Guid SchoolCalendarId)
        : Entity(Id)
    {
        public virtual SchoolCalendar SchoolCalendar { get; set; }
    }
}
