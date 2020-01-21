using Gepa.Service.Entity.Base.Abstractions;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAOCrud<TEntity> :
        IDAODelete<TEntity>,
        IDAOFinder<TEntity>,
        IDAOInserter<TEntity>,
        IDAOUpdater<TEntity> where TEntity : IGepaEntity
    {
    }
}
