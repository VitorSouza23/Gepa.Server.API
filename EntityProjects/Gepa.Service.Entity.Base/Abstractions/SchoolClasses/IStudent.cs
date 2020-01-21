using System.Collections.Generic;

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
