using Gepa.Service.Entity.Base.Enumerations.SchoolClasses;
using System;

namespace Gepa.Service.Entity.Base.Abstractions.SchoolClasses
{
    public interface IStudentPresence : IGepaEntity, IGepaObservation
    {
        long StudentID { get; }
        ClassPresenceStatus ClassPresenceStatus { get; }
        DateTime ClassDate { get; }
    }
}
