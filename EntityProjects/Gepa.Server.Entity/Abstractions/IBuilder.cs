namespace Gepa.Server.Entity.Abstractions
{
    internal interface IBuilder<Tout>
    {
        Tout Build();
    }
}
