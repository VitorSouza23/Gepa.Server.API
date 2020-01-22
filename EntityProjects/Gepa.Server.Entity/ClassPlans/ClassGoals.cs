using Gepa.Service.Entity.Base.Abstractions.ClassPlans;

namespace Gepa.Server.Entity.ClassPlans
{
    public class ClassGoals : IClassGoals
    {
        public long ClassPlanID { get; set; }

        public long ID { get; set; }

        public string Objective { get; set; }

        public bool IsCompleted { get; set; }
    }
}
