using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.ClassPlans
{
    public record Chores(string TaskName, bool Completed, Guid ClassPlanId)
        : ValueObject()
    {
        public virtual ClassPlan ClassPlan { get; init; }
    }
}
