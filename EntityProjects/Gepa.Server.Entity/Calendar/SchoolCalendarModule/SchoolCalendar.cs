using Gepa.Server.Entity.Attributes;
using Gepa.Server.Entity.Validator.Abstractions;
using Gepa.Server.Entity.Validator.Exceptions;
using Gepa.Service.Entity.Base.Abstractions.Calendar;
using System.Collections.Generic;

namespace Gepa.Server.Entity.Calendar.SchoolCalendarModule
{
    [Manufacturable(typeof(SchoolCalendar))]
    [Validable]
    public class SchoolCalendar : ISchoolCalendar
    {
        internal SchoolCalendar(long ID, string observation, string name, IList<ISchoolEvent> schoolEvents, long teacherID)
        {
            this.ID = ID;
            Observation = observation;
            Name = name;
            SchoolEvents = schoolEvents;
            TeacherID = teacherID;

            IEntityValidatorRuller<SchoolCalendar> entityValidatorRuller = new SchoolCalendarValidator();
            if(entityValidatorRuller.CheckIfEntityIsValid(this) == false)
            {
                throw new RuleNotValidException();
            }
        }

        [Manufacturer]
        public static SchoolCalendarBuilder Factory => new SchoolCalendarBuilder();

        public long ID { get; private set; }

        public string Observation { get; private set; }

        public string Name { get; private set; }

        public IList<ISchoolEvent> SchoolEvents { get; private set; }

        public long TeacherID { get; private set; }
    }
}
