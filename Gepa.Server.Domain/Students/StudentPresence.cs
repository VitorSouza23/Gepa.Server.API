using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.Students
{
    public class StudentPresence : Entity
    {
        protected StudentPresence() { }

        public StudentPresence(string observation, DateTime classDate, bool isPresent, bool isAbsence, bool isJustifiedAbsence, Guid studentId) : this()
        {
            Observation = observation;
            ClassDate = classDate;
            IsPresent = isPresent;
            IsAbsence = isAbsence;
            IsJustifiedAbsence = isJustifiedAbsence;
            StudentId = studentId;
        }

        public StudentPresence(string observation, DateTime classDate, bool isPresent, bool isAbsence, bool isJustifiedAbsence, Student student) : this()
        {
            Observation = observation;
            ClassDate = classDate;
            IsPresent = isPresent;
            IsAbsence = isAbsence;
            IsJustifiedAbsence = isJustifiedAbsence;
            Student = student;
            StudentId = student.Id;
        }

        public string Observation { get; protected set; }
        public DateTime ClassDate { get; protected set; }
        public bool IsPresent { get; protected set; }
        public bool IsAbsence { get; protected set; }
        public bool IsJustifiedAbsence { get; protected set; }
        public Guid StudentId { get; protected set; }
        public virtual Student Student { get; protected set; }
    }
}
