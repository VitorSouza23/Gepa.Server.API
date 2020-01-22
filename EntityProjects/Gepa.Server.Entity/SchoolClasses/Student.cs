using Gepa.Service.Entity.Base.Abstractions.SchoolClasses;
using System.Collections.Generic;

namespace Gepa.Server.Entity.SchoolClasses
{
    public class Student : IStudent
    {
        public long ID { get; set; }

        public string Observation { get; set; }

        public string Name { get; set; }

        public IList<IStudentNote> StudentNotes { get; set; }

        public IList<IStudentPresence> StudentPresences { get; set; }

        public long SchoolClassID { get; set; }

        public long ClassDiaryID { get; set; }
    }
}
