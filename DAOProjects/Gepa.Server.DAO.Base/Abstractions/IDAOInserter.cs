using Gepa.Service.Entity.Base.Abstractions;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAOInserter<TEntity> where TEntity : IGepaEntity
    {
        bool Insert(TEntity entityToInsert);
    }
}
