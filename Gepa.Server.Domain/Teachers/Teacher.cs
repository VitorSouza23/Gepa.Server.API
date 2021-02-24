using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Calendar;
using Gepa.Server.Domain.ClassPlans;
using Gepa.Server.Domain.Schools;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.Teachers
{
    public record Teacher(Guid Id, string Name,
    IReadOnlyCollection<ClassPlan> ClassPlans, IReadOnlyCollection<School> Schools,
    IReadOnlyCollection<SchoolCalendar> SchoolCalendars)
        : Entity(Id);
}
