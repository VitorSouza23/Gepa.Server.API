using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Common;
using Gepa.Server.Infra.Data.Contexts;
using MongoDB.Driver;

namespace Gepa.Server.Infra.Data.Common
{
    public interface ICommonRepository<TEntity> where TEntity : Entity
    {
        IMongoCollection<TEntity> Collection { get; }
        Task<(TEntity, Exception)> AddAsync(TEntity entity);
        Task<(TEntity, Exception)> FindAsync(Guid id);
        Task<(TEntity, Exception)> UpdateAsync(TEntity entity);
        Task<(TEntity, Exception)> DeleteAsync(TEntity entity);
        Task<(IEnumerable<TEntity>, Exception)> FindAllAsync();
    }
}