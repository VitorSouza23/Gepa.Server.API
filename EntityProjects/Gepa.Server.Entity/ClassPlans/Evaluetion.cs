using Gepa.Service.Entity.Base.Abstractions.ClassPlans;

namespace Gepa.Server.Entity.ClassPlans
{
    public class Evaluetion : IEvaluetion
    {
        public long ID { get; set; }

        public string Description { get; set; }

        public long ClassPlanID { get; set; }
    }
}
