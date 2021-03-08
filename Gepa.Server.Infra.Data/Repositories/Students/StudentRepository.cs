using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Students;
using Gepa.Server.Infra.Data.Common;
using Gepa.Server.Infra.Data.Contexts;

namespace Gepa.Server.Infra.Data.Repositories.Students
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ICommonRepository<Student> _common;
        private readonly MainContext _context;

        public StudentRepository(ICommonRepository<Student> common)
        {
            _common = common;
            _context = _common.Context;
        }

        public async Task<(Student, Exception)> AddAsync(Student entity)
        {
            return await _common.AddAsync(entity);
        }

        public async Task<(Student, Exception)> DeleteAsync(Student entity)
        {
            return await _common.DeleteAsync(entity);
        }

        public async Task<(IEnumerable<Student>, Exception)> FindAllAsync()
        {
            return await _common.FindAllAsync();
        }

        public async Task<(Student, Exception)> FindAsync(Guid id)
        {
            return await _common.FindAsync(id);
        }

        public async Task<(Student, Exception)> UpdateAsync(Student entity)
        {
            return await _common.UpdateAsync(entity);
        }
    }
}