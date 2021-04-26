using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.ClassPlans
{
    public class Chores : Entity
    {
        protected Chores() { }

        public Chores(string taskName, bool completed, Guid classPlanId) : this()
        {
            TaskName = taskName;
            Completed = completed;
            ClassPlanId = classPlanId;
        }

        public Chores(string taskName, bool completed, ClassPlan classPlan) : this()
        {
            TaskName = taskName;
            Completed = completed;
            ClassPlan = classPlan;
            ClassPlanId = classPlan.Id;
        }

        public string TaskName { get; protected set; }
        public bool Completed { get; protected set; }
        public Guid ClassPlanId { get; protected set; }
        public virtual ClassPlan ClassPlan { get; protected set; }

        public void Complete()
        {
            Completed = true;
            Updated();
        }
    }
}
