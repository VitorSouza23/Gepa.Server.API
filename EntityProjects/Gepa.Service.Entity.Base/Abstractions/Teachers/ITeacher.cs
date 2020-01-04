﻿using Gepa.Service.Entity.Base.Abstractions.Calendar;
using Gepa.Service.Entity.Base.Abstractions.ClassPlans;
using Gepa.Service.Entity.Base.Abstractions.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Service.Entity.Base.Abstractions.Teachers
{
    public interface ITeacher : IGepaEntity
    {
        string Name { get; }
        IList<IClassPlan> ClassPlans { get; }
        IList<ISchool> Schools { get; }
        IList<ISchoolCalendar> SchoolCalendars { get; }
    }
}