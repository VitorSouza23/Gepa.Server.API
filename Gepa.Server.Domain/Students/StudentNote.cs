using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.Students
{
    public class StudentNote : Entity
    {
        protected StudentNote() { }

        public StudentNote(string observation, decimal? quantitativeGrade, string qualitativeNote, Guid studentId) : this()
        {
            Observation = observation;
            QuantitativeGrade = quantitativeGrade;
            QualitativeNote = qualitativeNote;
            StudentId = studentId;
        }

        public StudentNote(string observation, decimal? quantitativeGrade, string qualitativeNote, Student student) : this()
        {
            Observation = observation;
            QuantitativeGrade = quantitativeGrade;
            QualitativeNote = qualitativeNote;
            Student = student;
            StudentId = student.Id;
        }

        public string Observation { get; protected set; }
        public decimal? QuantitativeGrade { get; protected set; }
        public string QualitativeNote { get; protected set; }
        public Guid StudentId { get; protected set; }
        public virtual Student Student { get; protected set; }
    }
}
