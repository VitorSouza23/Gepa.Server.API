using System;
using System.Collections.Generic;
using System.Text;

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
