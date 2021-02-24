using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Classes;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.Schools
{
    public record Student(Guid Id, string Observation, string Name,
    IReadOnlyCollection<StudentNote> StudentNotes, IReadOnlyCollection<StudentPresence> StudentPresences,
    Guid SchoolClassId, Guid ClassDiaryId)
        : Entity(Id)
    {
        public virtual SchoolClass SchoolClass { get; init; }
        public virtual ClassDiary ClassDiary { get; init; }
    }
}
