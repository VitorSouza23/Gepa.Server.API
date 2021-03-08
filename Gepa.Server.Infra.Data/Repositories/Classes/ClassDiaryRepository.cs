using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.Classes;
using Gepa.Server.Infra.Data.Common;
using Gepa.Server.Infra.Data.Contexts;

namespace Gepa.Server.Infra.Data.Repositories.Classes
{
    public class ClassDiaryRepository : IClassDiaryRepository
    {
        private readonly ICommonRepository<ClassDiary> _common;
        private readonly MainContext _context;

        public ClassDiaryRepository(ICommonRepository<ClassDiary> common)
        {
            _common = common;
            _context = _common.Context;
        }

        public async Task<(ClassDiary, Exception)> AddAsync(ClassDiary entity)
        {
            return await _common.AddAsync(entity);
        }

        public async Task<(ClassDiary, Exception)> DeleteAsync(ClassDiary entity)
        {
            return await _common.DeleteAsync(entity);
        }

        public async Task<(IEnumerable<ClassDiary>, Exception)> FindAllAsync()
        {
            return await _common.FindAllAsync();
        }

        public async Task<(ClassDiary, Exception)> FindAsync(Guid id)
        {
            return await _common.FindAsync(id);
        }

        public async Task<(ClassDiary, Exception)> UpdateAsync(ClassDiary entity)
        {
            return await _common.UpdateAsync(entity);
        }
    }
}