using Gepa.Service.Entity.Base.Abstractions;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAOFinder<TEntity> where TEntity : IGepaEntity
    {
        TEntity Find(long entityIDToFind);
    }
}
