using System;

namespace Gepa.Server.Domain.Common
{
    public record ValueObject
    {
        public DateTime CreatedAt { get; } = DateTime.Now;
        public DateTime UpdatedAt { get;  init; } = DateTime.Now;
    }

    public static class ValueObjectExtensions
    {
        public static ValueObject Updated(this ValueObject valueObject) => valueObject with { UpdatedAt = DateTime.Now };
    }
}