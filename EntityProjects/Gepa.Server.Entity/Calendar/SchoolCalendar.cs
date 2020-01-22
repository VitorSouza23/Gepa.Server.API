using Gepa.Service.Entity.Base.Abstractions.Calendar;
using System.Collections.Generic;

namespace Gepa.Server.Entity.Calendar
{
    public class SchoolCalendar : ISchoolCalendar
    {
        public long ID { get; set; }

        public string Observation { get; set; }

        public string Name { get; set; }

        public IList<ISchoolEvent> SchoolEvents { get; set; }

        public long TeacherID { get; set; }
    }
}
