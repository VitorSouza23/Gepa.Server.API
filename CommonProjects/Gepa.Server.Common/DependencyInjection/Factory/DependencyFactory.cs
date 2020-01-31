using Gepa.Server.Common.DependencyInjection.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Server.Common.DependecyInjection.Factory
{
    public class DependencyFactory<Tout> : IDependencyFactory<Tout>
    {
        private readonly Func<Tout> _dependencyBuilder;

        public DependencyFactory(Func<Tout> dependencyBuilder)
        {
            _dependencyBuilder = dependencyBuilder;
        }

        public Tout BuildDependency() => _dependencyBuilder();
    }
}
