using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gepa.Server.Domain.ClassPlans;
using Gepa.Server.Infra.Data.Common;
using Gepa.Server.Infra.Data.Contexts;

namespace Gepa.Server.Infra.Data.Repositories.ClassPlans
{
    public class ClassPlanRepository : IClassPlanRepository
    {
        private readonly ICommonRepository<ClassPlan> _common;
        private readonly MainContext _context;

        public ClassPlanRepository(ICommonRepository<ClassPlan> common)
        {
            _common = common;
            _context = _common.Context;
        }

        public async Task<(ClassPlan, Exception)> AddAsync(ClassPlan entity)
        {
            return await _common.AddAsync(entity);
        }

        public async Task<(ClassPlan, Exception)> DeleteAsync(ClassPlan entity)
        {
            return await _common.DeleteAsync(entity);
        }

        public async Task<(IEnumerable<ClassPlan>, Exception)> FindAllAsync()
        {
            return await _common.FindAllAsync();
        }

        public async Task<(ClassPlan, Exception)> FindAsync(Guid id)
        {
            return await _common.FindAsync(id);
        }

        public async Task<(ClassPlan, Exception)> UpdateAsync(ClassPlan entity)
        {
            return await _common.UpdateAsync(entity);
        }
    }
}