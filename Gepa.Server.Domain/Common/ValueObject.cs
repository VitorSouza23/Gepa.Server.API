using System;

namespace Gepa.Server.Domain.Common
{
    public class ValueObject
    {
        public DateTime CreatedAt { get; protected set; } = DateTime.Now;
        public DateTime UpdatedAt { get; protected set; } = DateTime.Now;
        public void Updated() => UpdatedAt = DateTime.Now;
    }
}