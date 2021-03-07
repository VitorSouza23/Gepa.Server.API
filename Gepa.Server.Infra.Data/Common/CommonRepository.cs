using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Common;
using Gepa.Server.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Gepa.Server.Infra.Data.Common
{
    public sealed class CommonRepository<TEntity> : ICommonRepository<TEntity> where TEntity : Entity
    {
        private readonly MainContext _context;

        public CommonRepository(MainContext context)
        {
            _context = context;
        }

        public async Task<(TEntity, Exception)> AddAsync(TEntity entity)
        {
            (TEntity newEntity, Exception exception) = (null, null);
            try
            {
                newEntity = _context.Set<TEntity>().Add(entity).Entity;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) { exception = ex; }
            return (newEntity, exception);
        }

        public async Task<(TEntity, Exception)> DeleteAsync(TEntity entity)
        {
            (TEntity deletedEntity, Exception exception) = (null, null);
            try
            {
                deletedEntity = _context.Set<TEntity>().Remove(entity).Entity;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) { exception = ex; }
            return (deletedEntity, exception);
        }

        public async Task<(IEnumerable<TEntity>, Exception)> FindAllAsync()
        {
            (IEnumerable<TEntity> entities, Exception exception) = (null, null);
            try
            {
                entities = await _context.Set<TEntity>().ToListAsync();
            }
            catch (Exception ex) { exception = ex; }
            return (entities, exception);
        }

        public async Task<(TEntity, Exception)> FindAsync(Guid id)
        {
            (TEntity entitie, Exception exception) = (null, null);
            try
            {
                entitie = await _context.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex) { exception = ex; }
            return (entitie, exception);
        }

        public async Task<(TEntity, Exception)> UpdateAsync(TEntity entity)
        {
            (TEntity updatedEntity, Exception exception) = (null, null);
            try
            {
                updatedEntity = _context.Set<TEntity>().Update(entity).Entity;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) { exception = ex; }
            return (updatedEntity, exception);
        }
    }
}