using Gepa.Service.Entity.Base.Abstractions.Calendar;
using Gepa.Service.Entity.Base.Abstractions.ClassPlans;
using Gepa.Service.Entity.Base.Abstractions.SchoolClasses;
using Gepa.Service.Entity.Base.Abstractions.Teachers;
using System.Collections.Generic;

namespace Gepa.Server.Entity.Teachers
{
    public class Teacher : ITeacher
    {
        public long ID { get; set; }
        public string Name { get; set; }

        public IList<IClassPlan> ClassPlans { get; set; }

        public IList<ISchool> Schools { get; set; }

        public IList<ISchoolCalendar> SchoolCalendars { get; set; }
    }
}
