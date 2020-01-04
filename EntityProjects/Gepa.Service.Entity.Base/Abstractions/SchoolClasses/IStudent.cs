using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Service.Entity.Base.Abstractions.SchoolClasses
{
    public interface IStudent : IGepaEntity, IGepaObservation
    {
        string Name { get; }
        IList<IStudentNote> StudentNotes { get; }
        IList<IStudentPresence> StudentPresences { get; }
        long SchoolClassID { get; }
        long ClassDiaryID { get; }
    }
}
