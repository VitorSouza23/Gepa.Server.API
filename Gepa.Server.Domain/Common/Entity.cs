using System;

namespace Gepa.Server.Domain.Common
{
    public record Entity(Guid Id)
    {
        public DateTime CreatedAt { get; } = DateTime.Now;
        public DateTime UpdatedAt { get; init; } = DateTime.Now;
    }

    public static class EntityExtensions
    {
        public static Entity Updated(this Entity Domain) => Domain with { UpdatedAt = DateTime.Now };
    }
}