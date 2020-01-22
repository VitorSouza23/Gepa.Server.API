using Gepa.Service.Entity.Base.Abstractions.SchoolClasses;
using System.Collections.Generic;

namespace Gepa.Server.Entity.SchoolClasses
{
    public class SchoolClass : ISchoolClass
    {
        public long ID { get; set; }

        public string Observation { get; set; }

        public string Name { get; set; }

        public IList<IClassDiary> ClassDiaries { get; set; }

        public IList<IStudent> Students { get; set; }

        public long SchoolID { get; set; }

    }
}
