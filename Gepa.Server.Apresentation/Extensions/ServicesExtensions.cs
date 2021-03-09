using Gepa.Server.Domain.Calendar;
using Gepa.Server.Domain.Classes;
using Gepa.Server.Domain.ClassPlans;
using Gepa.Server.Domain.Schools;
using Gepa.Server.Domain.Students;
using Gepa.Server.Domain.Teachers;
using Gepa.Server.Infra.Data.Common;
using Gepa.Server.Infra.Data.Repositories.Calendar;
using Gepa.Server.Infra.Data.Repositories.Classes;
using Gepa.Server.Infra.Data.Repositories.ClassPlans;
using Gepa.Server.Infra.Data.Repositories.Schools;
using Gepa.Server.Infra.Data.Repositories.Students;
using Gepa.Server.Infra.Data.Repositories.Teachers;
using Microsoft.Extensions.DependencyInjection;

namespace Gepa.Server.Apresentation.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddGepaServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICommonRepository<>), typeof(CommonRepository<>));
            services.AddScoped<ISchoolCalendarRepository, SchoolCalendarRepository>();
            services.AddScoped<ISchoolEventRepository, SchoolEventRepository>();
            services.AddScoped<IClassDiaryRepository, ClassDiaryRepository>();
            services.AddScoped<IClassPlanRepository, ClassPlanRepository>();
            services.AddScoped<ISchoolClassRepository, SchoolClassRepository>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
        }
    }
}