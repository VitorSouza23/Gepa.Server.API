using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.Schools
{
    public record StudentNote(string Observation, decimal? QuantitativeGrade,
    string QualitativeNote, Guid StudentId)
        : ValueObject()
    {
        public virtual Student Student { get; init; }
    }
}
