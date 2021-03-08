using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Common;
using Gepa.Server.Infra.Data.Contexts;

namespace Gepa.Server.Infra.Data.Common
{
    public interface ICommonRepository<TEntity> where TEntity : Entity
    {
        MainContext Context { get; }
        Task<(TEntity, Exception)> AddAsync(TEntity entity);
        Task<(TEntity, Exception)> FindAsync(Guid id);
        Task<(TEntity, Exception)> UpdateAsync(TEntity entity);
        Task<(TEntity, Exception)> DeleteAsync(TEntity entity);
        Task<(IEnumerable<TEntity>, Exception)> FindAllAsync();
    }
}