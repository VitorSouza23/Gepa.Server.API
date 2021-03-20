using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Schools;
using Gepa.Server.Infra.Data.Common;
using Gepa.Server.Infra.Data.Contexts;

namespace Gepa.Server.Infra.Data.Repositories.Schools
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly ICommonRepository<School> _common;

        public SchoolRepository(ICommonRepository<School> common)
        {
            _common = common;
        }

        public async Task<(School, Exception)> AddAsync(School entity)
        {
            return await _common.AddAsync(entity);
        }

        public async Task<(School, Exception)> DeleteAsync(School entity)
        {
            return await _common.DeleteAsync(entity);
        }

        public async Task<(IEnumerable<School>, Exception)> FindAllAsync()
        {
            return await _common.FindAllAsync();
        }

        public async Task<(School, Exception)> FindAsync(Guid id)
        {
            return await _common.FindAsync(id);
        }

        public async Task<(School, Exception)> UpdateAsync(School entity)
        {
            return await _common.UpdateAsync(entity);
        }
    }
}