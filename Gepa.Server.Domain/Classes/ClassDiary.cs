using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Schools;

namespace Gepa.Server.Domain.Classes
{
    public record ClassDiary(Guid Id, DateTime InitialPeriod, DateTime FinalPeriod,
    IReadOnlyCollection<Student> Students, Guid SchoolClassId)
        : Entity(Id)
    {
        public virtual SchoolClass SchoolClass { get; init; }
    }
}
