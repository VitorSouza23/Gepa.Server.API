using Gepa.Service.Entity.Base.Abstractions;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAODelete<TEntity> where TEntity : IGepaEntity
    {
        bool Delete(TEntity entityToDelete);
    }
}
