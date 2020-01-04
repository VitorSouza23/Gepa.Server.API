using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Service.Entity.Base.Abstractions.ClassPlans
{
    public interface IClassPlan : IGepaEntity, IGepaObservation
    {
        string Title { get; }
        string Description { get; }
        IList<IChores> Chores { get; }
        IList<IClassGoals> ClassGoals { get; }
        IList<IEvaluetion> Evaluetions { get; }
        IList<ILessonContent> LessonContents { get; }
        long TeacherID { get; }
    }
}
