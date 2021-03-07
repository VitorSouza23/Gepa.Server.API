using System;
using Gepa.Server.Domain.Calendar;
using Gepa.Server.Domain.Classes;
using Gepa.Server.Domain.ClassPlans;
using Gepa.Server.Domain.Schools;
using Gepa.Server.Domain.Students;
using Gepa.Server.Domain.Teachers;
using Microsoft.EntityFrameworkCore;

namespace Gepa.Server.Infra.Data.Contexts
{
    public sealed class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options)
        : base(options)
        {
        }

        public DbSet<SchoolEvent> SchoolEvents { get; set; }
        public DbSet<SchoolCalendar> SchoolCalendars { get; set; }
        public DbSet<ClassDiary> ClassDiaries { get; set; }
        public DbSet<ClassPlan> ClassPlans { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.LogTo(Console.WriteLine);
    }
}