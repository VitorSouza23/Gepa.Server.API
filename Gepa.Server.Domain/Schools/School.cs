using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Calendar;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Teachers;

namespace Gepa.Server.Domain.Schools
{
    public class School : Entity
    {
        protected School()
        {
            SchoolClasses = new List<SchoolClass>();
        }

        public School(string name, Guid schoolCalendarId, Guid teacherId) : this()
        {
            Name = name;
            SchoolCalendarId = schoolCalendarId;
            TeacherId = teacherId;
        }

        public School(string name, SchoolCalendar schoolCalendar, Teacher teacher) : this()
        {
            Name = name;
            SchoolCalendar = schoolCalendar;
            SchoolCalendarId = schoolCalendar.Id;
            Teacher = teacher;
            TeacherId = teacher.Id;
        }

        public string Name { get; protected set; }
        public ICollection<SchoolClass> SchoolClasses { get; protected set; }
        public Guid SchoolCalendarId { get; set; }
        public virtual SchoolCalendar SchoolCalendar { get; protected set; }
        public Guid TeacherId { get; protected set; }
        public virtual Teacher Teacher { get; protected set; }

        public void AddSchoolClass(SchoolClass schoolClass)
        {
            SchoolClasses.Add(schoolClass);
            Updated();
        }
    }
}
