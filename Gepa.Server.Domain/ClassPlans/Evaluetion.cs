using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.ClassPlans
{
    public class Evaluetion : Entity
    {
        protected Evaluetion() { }

        public Evaluetion(string description, Guid classPlanId) : this()
        {
            Description = description;
            ClassPlanId = classPlanId;
        }

        public Evaluetion(string description, ClassPlan classPlan) : this()
        {
            Description = description;
            ClassPlan = classPlan;
            ClassPlanId = classPlan.Id;
        }

        public string Description { get; protected set; }
        public Guid ClassPlanId { get; protected set; }
        public virtual ClassPlan ClassPlan { get; set; }
    }
}
