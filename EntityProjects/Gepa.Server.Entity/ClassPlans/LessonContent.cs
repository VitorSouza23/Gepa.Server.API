using Gepa.Service.Entity.Base.Abstractions.ClassPlans;

namespace Gepa.Server.Entity.ClassPlans
{
    public class LessonContent : ILessonContent
    {
        public long ID { get; set; }

        public string ContentValue { get; set; }

        public long ClassPlanID { get; set; }
    }
}
