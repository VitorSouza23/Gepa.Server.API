using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.ClassPlans
{
    public record Evaluetion(string Description, Guid ClassPlanId)
        : ValueObject()
    {
        public virtual ClassPlan ClassPlan { get; init; }
    }
}
