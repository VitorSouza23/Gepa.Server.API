using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Calendar;
using Gepa.Server.Infra.Data.Common;
using Gepa.Server.Infra.Data.Contexts;

namespace Gepa.Server.Infra.Data.Repositories.Calendar
{
    public class SchoolCalendarRepository : ISchoolCalendarRepository
    {
        private readonly ICommonRepository<SchoolCalendar> _common;
        private readonly MainContext _context;

        public SchoolCalendarRepository(ICommonRepository<SchoolCalendar> common)
        {
            _common = common;
            _context = _common.Context;
        }

        public async Task<(SchoolCalendar, Exception)> AddAsync(SchoolCalendar schoolCalendar)
        {
            return await _common.AddAsync(schoolCalendar);
        }

        public async Task<(SchoolCalendar, Exception)> DeleteAsync(SchoolCalendar schoolCalendar)
        {
            return await _common.DeleteAsync(schoolCalendar);
        }

        public async Task<(IEnumerable<SchoolCalendar>, Exception)> FindAllAsync()
        {
            return await _common.FindAllAsync();
        }

        public async Task<(SchoolCalendar, Exception)> FindAsync(Guid id)
        {
            return await _common.FindAsync(id);
        }

        public async Task<(SchoolCalendar, Exception)> UpdateAsync(SchoolCalendar schoolCalendar)
        {
            return await _common.UpdateAsync(schoolCalendar);
        }
    }
}