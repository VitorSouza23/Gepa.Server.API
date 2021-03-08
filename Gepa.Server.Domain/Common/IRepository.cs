using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gepa.Server.Domain.Common
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<(TEntity, Exception)> AddAsync(TEntity entity);
        Task<(TEntity, Exception)> FindAsync(Guid id);
        Task<(TEntity, Exception)> UpdateAsync(TEntity entity);
        Task<(TEntity, Exception)> DeleteAsync(TEntity entity);
        Task<(IEnumerable<TEntity>, Exception)> FindAllAsync();
    }
}