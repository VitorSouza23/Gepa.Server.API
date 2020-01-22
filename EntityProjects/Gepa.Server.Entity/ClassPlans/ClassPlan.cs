using Gepa.Service.Entity.Base.Abstractions.ClassPlans;
using System.Collections.Generic;

namespace Gepa.Server.Entity.ClassPlans
{
    public class ClassPlan : IClassPlan
    {
        public long ID { get; set; }

        public string Observation { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IList<IChores> Chores { get; set; }

        public IList<IClassGoals> ClassGoals { get; set; }

        public IList<IEvaluetion> Evaluetions { get; set; }

        public IList<ILessonContent> LessonContents { get; set; }

        public long TeacherID { get; set; }
    }
}
