using Gepa.Server.Common.DependencyInjection.Exceptions;
using System;
using System.Collections.Concurrent;

namespace Gepa.Server.Common.DependencyInjection.Abstractions
{
    public abstract class AbstractDependencyInjectorDictionary : IInjector
    {
        private readonly ConcurrentDictionary<Type, object> _dependencies;

        protected AbstractDependencyInjectorDictionary()
        {
            _dependencies = new ConcurrentDictionary<Type, object>();
            ConfigureDependencies();
        }

        protected abstract void ConfigureDependencies();

        protected void AddDependencyConfiguration<TDependency>(Func<TDependency> dependencyBuilder)
        {
            Type key = typeof(TDependency);
            _dependencies.TryAdd(key, dependencyBuilder);
        }

        public Tout Inject<Tout>()
        {
            Type key = typeof(Tout);
            if (_dependencies.TryGetValue(key, out object dependecyFactory))
            {
                return (dependecyFactory as IDependencyFactory<Tout>).BuildDependency();
            }

            throw new DependencyNotConfiguredException(key);
        }
    }
}
