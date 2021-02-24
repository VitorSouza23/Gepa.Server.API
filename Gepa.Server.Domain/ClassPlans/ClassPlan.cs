using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Teachers;

namespace Gepa.Server.Domain.ClassPlans
{
    public record ClassPlan(Guid Id, string Observation, string Title,
    string Description, IReadOnlyCollection<Chores> Chores,
    IReadOnlyCollection<Evaluetion> Evaluetions, IReadOnlyCollection<LessonContent> LessonContents,
    Guid TeacherId)
        : Entity(Id)
    {
        public virtual Teacher Teacher { get; init; }
    }
}
