using Gepa.Service.Entity.Base.Abstractions.ClassPlans;

namespace Gepa.Server.Entity.ClassPlans
{
    public class Chores : IChores
    {
        public long ClassPlanID { get; set; }

        public long ID { get; set; }

        public string TaskName { get; set; }

        public bool Completed { get; set; }
    }
}
