using Gepa.Server.Entity.Validator.Abstractions;
using Gepa.Server.Entity.Validator.Validators;
using System;
using System.Collections.Generic;

namespace Gepa.Server.Entity.Calendar.SchoolCalendarModule
{
    public class SchoolCalendarValidator : IEntityValidatorRuller<SchoolCalendar>
    {
        private readonly IEntityValidator<SchoolCalendar> _entityValidator;

        public SchoolCalendarValidator()
        {
            _entityValidator = new DefaultEntityValidator<SchoolCalendar>();
        }

        private bool HasTeacherID(SchoolCalendar schoolCalendar) => schoolCalendar.TeacherID > 0;
        private bool SchoolEventsIsNotNull(SchoolCalendar schoolCalendar) => schoolCalendar.SchoolEvents != null;

        private IEnumerable<ValidationRule<SchoolCalendar>> GetRules()
        {
            yield return HasTeacherID;
            yield return SchoolEventsIsNotNull;
        }
        
        public bool CheckIfEntityIsValid(SchoolCalendar entity)
        {
            return _entityValidator.CheckEntity(entity, GetRules());
        }
    }
}
