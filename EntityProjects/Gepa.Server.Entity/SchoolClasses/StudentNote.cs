using Gepa.Service.Entity.Base.Abstractions.SchoolClasses;

namespace Gepa.Server.Entity.SchoolClasses
{
    public class StudentNote : IStudentNote
    {
        public long ID { get; set; }

        public string Observation { get; set; }

        public decimal? QuantitativeGrade { get; set; }

        public string QualitativeNote { get; set; }

        public long StudentID { get; set; }
    }
}
