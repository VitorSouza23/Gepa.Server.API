namespace Gepa.Server.Common.DependencyInjection.Abstractions
{
    public interface IDependencyFactory<Tout>
    {
        Tout BuildDependency();
    }
}
