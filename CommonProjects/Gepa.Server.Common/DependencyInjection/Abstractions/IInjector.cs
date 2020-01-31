using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Server.Common.DependencyInjection.Abstractions
{
    public interface IInjector
    {
        Tout Inject<Tout>();
    }
}
