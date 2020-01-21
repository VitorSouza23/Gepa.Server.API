using System.Collections.Generic;

namespace Gepa.Service.Entity.Base.Abstractions.SchoolClasses
{
    public interface ISchoolClass : IGepaEntity, IGepaObservation
    {
        string Name { get; }
        IList<IClassDiary> ClassDiaries { get; }
        IList<IStudent> Students { get; }
        long SchoolID { get; }
    }
}
