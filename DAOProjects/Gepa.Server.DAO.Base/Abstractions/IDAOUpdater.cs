using Gepa.Service.Entity.Base.Abstractions;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAOUpdater<TEntity> where TEntity : IGepaEntity
    {
        bool Update(TEntity entityToUpdate);
    }
}
