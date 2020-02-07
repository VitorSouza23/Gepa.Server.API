namespace Gepa.Server.Common.DependencyInjection.Abstractions
{
    public interface IInjector
    {
        Tout Inject<Tout>();
    }
}
