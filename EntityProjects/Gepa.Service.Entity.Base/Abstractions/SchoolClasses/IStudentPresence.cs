using Gepa.Service.Entity.Base.Enumerations.SchoolClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Service.Entity.Base.Abstractions.SchoolClasses
{
    public interface IStudentPresence : IGepaEntity, IGepaObservation
    {
        long StudentID { get; }
        ClassPresenceStatus ClassPresenceStatus { get; }
        DateTime ClassDate { get; }
    }
}
