using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Service.Entity.Base.Abstractions.SchoolClasses
{
    public interface IClassDiary : IGepaEntity
    {
        DateTime InitialPeriod { get; }
        DateTime FinalPeriod { get; }
        IList<IStudent> Students { get; }
        long SchoolClassID { get; }
    }
}
