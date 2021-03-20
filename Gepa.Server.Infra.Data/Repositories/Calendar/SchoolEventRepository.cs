using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Calendar;
using Gepa.Server.Infra.Data.Common;
using Gepa.Server.Infra.Data.Contexts;

namespace Gepa.Server.Infra.Data.Repositories.Calendar
{
    public class SchoolEventRepository : ISchoolEventRepository
    {
        private readonly ICommonRepository<SchoolEvent> _common;

        public SchoolEventRepository(ICommonRepository<SchoolEvent> common)
        {
            _common = common;
        }

        public async Task<(SchoolEvent, Exception)> AddAsync(SchoolEvent entity)
        {
            return await _common.AddAsync(entity);
        }

        public async Task<(SchoolEvent, Exception)> DeleteAsync(SchoolEvent entity)
        {
            return await _common.DeleteAsync(entity);
        }

        public async Task<(IEnumerable<SchoolEvent>, Exception)> FindAllAsync()
        {
            return await _common.FindAllAsync();
        }

        public async Task<(SchoolEvent, Exception)> FindAsync(Guid id)
        {
            return await _common.FindAsync(id);
        }

        public async Task<(SchoolEvent, Exception)> UpdateAsync(SchoolEvent entity)
        {
            return await _common.UpdateAsync(entity);
        }
    }
}