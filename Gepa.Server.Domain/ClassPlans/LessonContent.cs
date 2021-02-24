using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.ClassPlans
{
    public record LessonContent(string ContentValue, Guid ClassPlanId)
        : ValueObject()
    {
        public virtual ClassPlan ClassPlan { get; init; }
    }
}
