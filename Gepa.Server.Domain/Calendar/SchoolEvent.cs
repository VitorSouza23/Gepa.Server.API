using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.Calendar
{
    public class SchoolEvent : Entity
    {

        protected SchoolEvent() { }

        public SchoolEvent(string name, DateTime startDate, DateTime endDate, Guid schoolCalendarId) : this()
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            SchoolCalendarId = schoolCalendarId;
        }

        public SchoolEvent(string name, DateTime startDate, DateTime endDate, SchoolCalendar schoolCalendar) : this()
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            SchoolCalendar = schoolCalendar;
            SchoolCalendarId = schoolCalendar.Id;
        }

        public string Name { get; protected set; }
        public DateTime StartDate { get; protected set; }
        public DateTime EndDate { get; protected set; }
        public Guid SchoolCalendarId { get; protected set; }
        public SchoolCalendar SchoolCalendar { get; protected set; }

        public bool IsItRunning(DateTime dateBase) => StartDate <= dateBase && dateBase <= EndDate;
        public bool HasItAlreadyOccured(DateTime dateBse) => dateBse > EndDate;
    }
}
