using Gepa.Server.Entity.Abstractions;
using Gepa.Server.Entity.Attributes;
using Gepa.Service.Entity.Base.Abstractions.Calendar;
using System.Collections.Generic;

namespace Gepa.Server.Entity.Calendar
{
    [Manufacturable(typeof(SchoolCalendar))]
    public class SchoolCalendar : ISchoolCalendar
    {
        internal SchoolCalendar(long iD, string observation, string name, IList<ISchoolEvent> schoolEvents, long teacherID)
        {
            ID = iD;
            Observation = observation;
            Name = name;
            SchoolEvents = schoolEvents;
            TeacherID = teacherID;
        }

        [Manufacturer]
        public static SchoolCalendarBuilder Factory => new SchoolCalendarBuilder();

        public long ID { get; private set; }

        public string Observation { get; private set; }

        public string Name { get; private set; }

        public IList<ISchoolEvent> SchoolEvents { get; private set; }

        public long TeacherID { get; private set; }
    }

    public class SchoolCalendarBuilder : IBuilder<SchoolCalendar>
    {
        private long _ID;
        private string _observation;
        private string _name;
        private IList<ISchoolEvent> _schoolEvents;
        private long _teacherID;

        public SchoolCalendarBuilder SetID(long ID)
        {
            _ID = ID;
            return this;
        }

        public SchoolCalendarBuilder SetObservation(string observation)
        {
            _observation = observation;
            return this;
        }

        public SchoolCalendarBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public SchoolCalendarBuilder SetSchoolEvents(IList<ISchoolEvent> schoolEvents)
        {
            _schoolEvents = schoolEvents;
            return this;
        }

        public SchoolCalendarBuilder SetTeacherID(long teacherID)
        {
            _teacherID = teacherID;
            return this;
        }

        public SchoolCalendar Build()
        {
            return new SchoolCalendar(_ID, _observation, _name, _schoolEvents, _teacherID);
        }
    }
}
