using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Teachers;

namespace Gepa.Server.Domain.Schools
{
    public record School(Guid Id, string Name, IReadOnlyCollection<SchoolClass> SchoolClasses,
    Guid TeacherId)
        : Entity(Id)
    {
        public virtual Teacher Teacher { get; init; }
    }
}
