using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Teachers;
using Gepa.Server.Infra.Data.Common;
using Gepa.Server.Infra.Data.Contexts;

namespace Gepa.Server.Infra.Data.Repositories.Teachers
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ICommonRepository<Teacher> _common;
        private readonly MainContext _context;

        public TeacherRepository(ICommonRepository<Teacher> common)
        {
            _common = common;
            _context = _common.Context;
        }

        public async Task<(Teacher, Exception)> AddAsync(Teacher entity)
        {
            return await _common.AddAsync(entity);
        }

        public async Task<(Teacher, Exception)> DeleteAsync(Teacher entity)
        {
            return await _common.DeleteAsync(entity);
        }

        public async Task<(IEnumerable<Teacher>, Exception)> FindAllAsync()
        {
            return await _common.FindAllAsync();
        }

        public async Task<(Teacher, Exception)> FindAsync(Guid id)
        {
            return await _common.FindAsync(id);
        }

        public async Task<(Teacher, Exception)> UpdateAsync(Teacher entity)
        {
            return await _common.UpdateAsync(entity);
        }
    }
}