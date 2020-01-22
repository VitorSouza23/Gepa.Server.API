using Gepa.Service.Entity.Base.Abstractions.SchoolClasses;
using System;
using System.Collections.Generic;

namespace Gepa.Server.Entity.SchoolClasses
{
    public class ClassDiary : IClassDiary
    {
        public long ID { get; set; }

        public DateTime InitialPeriod { get; set; }

        public DateTime FinalPeriod { get; set; }

        public IList<IStudent> Students { get; set; }

        public long SchoolClassID { get; set; }
    }
}
