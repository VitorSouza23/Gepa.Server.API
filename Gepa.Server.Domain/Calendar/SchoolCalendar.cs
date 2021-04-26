using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Teachers;

namespace Gepa.Server.Domain.Calendar
{
    public class SchoolCalendar : Entity
    {
        protected SchoolCalendar()
        {
            SchoolEvents = new List<SchoolEvent>();
        }

        public SchoolCalendar(string observation, string name, Guid teacherId) : this()
        {
            Observation = observation;
            Name = name;
            TeacherId = teacherId;
        }

        public SchoolCalendar(string observation, string name, Teacher teacher) : this()
        {
            Observation = observation;
            Name = name;
            Teacher = teacher;
            TeacherId = teacher.Id;
        }

        public string Observation { get; protected set; }
        public string Name { get; protected set; }
        public virtual ICollection<SchoolEvent> SchoolEvents { get; protected set; }
        public Guid TeacherId { get; protected set; }
        public virtual Teacher Teacher { get; protected set; }

        public void AddSchoolEvent(SchoolEvent schoolEvent)
        {
            SchoolEvents.Add(schoolEvent);
            Updated();
        }
    }
}
