using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Common;
using Gepa.Server.Infra.Data.Contexts;
using MongoDB.Driver;

namespace Gepa.Server.Infra.Data.Common
{
    public sealed class CommonRepository<TEntity> : ICommonRepository<TEntity> where TEntity : Entity
    {
        private readonly IMongoCollection<TEntity> _collection;
        public IMongoCollection<TEntity> Collection => _collection;

        public CommonRepository(MainContext context)
        {
            var collectionName = typeof(TEntity).Name;
            _collection = context.Database.GetCollection<TEntity>(collectionName);
        }

        public async Task<(TEntity, Exception)> AddAsync(TEntity entity)
        {
            (TEntity newEntity, Exception exception) = (null, null);
            try
            {
                await _collection.InsertOneAsync(entity);
            }
            catch (Exception ex) { exception = ex; }
            return (newEntity, exception);
        }

        public async Task<(TEntity, Exception)> DeleteAsync(TEntity entity)
        {
            (TEntity deletedEntity, Exception exception) = (null, null);
            try
            {
                await _collection.DeleteOneAsync(t => t.Id == t.Id);
            }
            catch (Exception ex) { exception = ex; }
            return (deletedEntity, exception);
        }

        public async Task<(IEnumerable<TEntity>, Exception)> FindAllAsync()
        {
            (IEnumerable<TEntity> entities, Exception exception) = (null, null);
            try
            {
                entities = await _collection.Find(t => true).ToListAsync();
            }
            catch (Exception ex) { exception = ex; }
            return (entities, exception);
        }

        public async Task<(TEntity, Exception)> FindAsync(Guid id)
        {
            (TEntity entitie, Exception exception) = (null, null);
            try
            {
                entitie = await _collection.Find(t => t.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex) { exception = ex; }
            return (entitie, exception);
        }

        public async Task<(TEntity, Exception)> UpdateAsync(TEntity entity)
        {
            (TEntity updatedEntity, Exception exception) = (null, null);
            try
            {
                await _collection.ReplaceOneAsync(t => t.Id == entity.Id, entity);
            }
            catch (Exception ex) { exception = ex; }
            return (updatedEntity, exception);
        }
    }
}