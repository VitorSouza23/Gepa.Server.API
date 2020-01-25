using Gepa.Service.Entity.Base.Abstractions.Calendar;
using System.Collections.Generic;

namespace Gepa.Server.Entity.Calendar.SchoolCalendarModule
{
    public class SchoolCalendarBuilder
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
