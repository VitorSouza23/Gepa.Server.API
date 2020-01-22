using Gepa.Service.Entity.Base.Abstractions.SchoolClasses;
using Gepa.Service.Entity.Base.Enumerations.SchoolClasses;
using System;

namespace Gepa.Server.Entity.SchoolClasses
{
    public class StudentPresence : IStudentPresence
    {
        public long ID => throw new NotImplementedException();

        public string Observation => throw new NotImplementedException();

        public long StudentID => throw new NotImplementedException();

        public ClassPresenceStatus ClassPresenceStatus => throw new NotImplementedException();

        public DateTime ClassDate => throw new NotImplementedException();
    }
}
