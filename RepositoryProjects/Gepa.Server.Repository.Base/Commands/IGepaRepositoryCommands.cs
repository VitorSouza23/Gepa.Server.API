namespace Gepa.Server.Repository.Base.Commands
{
    public interface IGepaRepositoryCommands<TOut, Tin>
    {
        TOut ExecuteRepositoryCommand(Tin parameter);
    }
}
