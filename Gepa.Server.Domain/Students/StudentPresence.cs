﻿using System;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.Schools
{
    public record StudentPresence(string Observation, Guid StudentId, DateTime ClassDate)
        : ValueObject()
    {
        public virtual Student Student { get; init; }
    }
}
