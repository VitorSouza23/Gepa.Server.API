using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.ClassPlans
{
    public class LessonContent : Entity
    {
        protected LessonContent() { }

        public LessonContent(string contentValue, Guid classPlanId) : this()
        {
            ContentValue = contentValue;
            ClassPlanId = classPlanId;
        }

        public LessonContent(string contentValue, ClassPlan classPlan) : this()
        {
            ContentValue = contentValue;
            ClassPlan = classPlan;
            ClassPlanId = classPlan.Id;
        }

        public string ContentValue { get; protected set; }
        public Guid ClassPlanId { get; protected set; }
        public virtual ClassPlan ClassPlan { get; protected set; }
    }
}
