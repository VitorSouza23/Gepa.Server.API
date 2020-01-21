namespace Gepa.Service.Entity.Base.Abstractions.SchoolClasses
{
    public interface IStudentNote : IGepaEntity, IGepaObservation
    {
        decimal? QuantitativeGrade { get; }
        string QualitativeNote { get; }
        long StudentID { get; }
    }
}
