using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Server.Common.DependencyInjection.Abstractions
{
    public interface IDependencyFactory<Tout>
    {
        Tout BuildDependency();
    }
}
