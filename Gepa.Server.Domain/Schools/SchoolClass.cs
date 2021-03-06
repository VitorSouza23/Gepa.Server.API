using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Classes;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Students;

namespace Gepa.Server.Domain.Schools
{
    public record SchoolClass(Guid Id, string Observation, string Name,
    IReadOnlyCollection<ClassDiary> ClassDiaries, IReadOnlyCollection<Student> Students, Guid SchoolId)
        : Entity(Id)
    {
        public virtual School School { get; init; }

    }
}
