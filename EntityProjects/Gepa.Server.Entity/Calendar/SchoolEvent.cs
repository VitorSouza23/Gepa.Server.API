using Gepa.Service.Entity.Base.Abstractions.Calendar;
using System;

namespace Gepa.Server.Entity.Calendar
{
    public class SchoolEvent : ISchoolEvent
    {
        public long ID { get; set; }

        public string Observation { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public long SchollCalendarID { get; set; }
    }
}
