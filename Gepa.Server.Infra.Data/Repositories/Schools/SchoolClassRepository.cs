using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Schools;
using Gepa.Server.Infra.Data.Common;
using Gepa.Server.Infra.Data.Contexts;

namespace Gepa.Server.Infra.Data.Repositories.Schools
{
    public class SchoolClassRepository : ISchoolClassRepository
    {
        private readonly ICommonRepository<SchoolClass> _common;

        public SchoolClassRepository(ICommonRepository<SchoolClass> common)
        {
            _common = common;
        }

        public async Task<(SchoolClass, Exception)> AddAsync(SchoolClass entity)
        {
            return await _common.AddAsync(entity);
        }

        public async Task<(SchoolClass, Exception)> DeleteAsync(SchoolClass entity)
        {
            return await _common.DeleteAsync(entity);
        }

        public async Task<(IEnumerable<SchoolClass>, Exception)> FindAllAsync()
        {
            return await _common.FindAllAsync();
        }

        public async Task<(SchoolClass, Exception)> FindAsync(Guid id)
        {
            return await _common.FindAsync(id);
        }

        public async Task<(SchoolClass, Exception)> UpdateAsync(SchoolClass entity)
        {
            return await _common.UpdateAsync(entity);
        }
    }
}