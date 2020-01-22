using Gepa.Service.Entity.Base.Abstractions.SchoolClasses;
using System.Collections.Generic;

namespace Gepa.Server.Entity.SchoolClasses
{
    public class School : ISchool
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public IList<ISchoolClass> SchoolClasses { get; set; }

        public long TeacherID { get; set; }
    }
}
