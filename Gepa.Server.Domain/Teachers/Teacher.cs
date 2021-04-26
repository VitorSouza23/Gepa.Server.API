using System.Collections.Generic;
using Gepa.Server.Domain.ClassPlans;
using Gepa.Server.Domain.Schools;
using Gepa.Server.Domain.Common;

namespace Gepa.Server.Domain.Teachers
{
    public class Teacher : Entity
    {
        protected Teacher()
        {
            ClassPlans = new List<ClassPlan>();
            Schools = new List<School>();
        }

        public Teacher(string name) : this()
        {
            Name = name;
        }

        public string Name { get; protected set; }
        public ICollection<ClassPlan> ClassPlans { get; protected set; }
        public ICollection<School> Schools { get; set; }

        public void AddClassPlan(ClassPlan classPlan)
        {
            ClassPlans.Add(classPlan);
            Updated();
        }

        public void AddSchool(School school)
        {
            Schools.Add(school);
            Updated();
        }
    }
}
