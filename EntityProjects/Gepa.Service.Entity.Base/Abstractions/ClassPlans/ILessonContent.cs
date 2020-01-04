using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Service.Entity.Base.Abstractions.ClassPlans
{
    public interface ILessonContent : IGepaEntity
    {
        string ContentValue { get; }
        long ClassPlanID { get; }
    }
}
