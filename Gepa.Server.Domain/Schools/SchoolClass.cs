using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Classes;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Students;

namespace Gepa.Server.Domain.Schools
{
    public class SchoolClass : Entity
    {
        protected SchoolClass()
        {
            ClassDiaries = new List<ClassDiary>();
            Students = new List<Student>();
        }

        public SchoolClass(string observation, string name, Guid schoolId) : this()
        {
            Observation = observation;
            Name = name;
            SchoolId = schoolId;
        }

        public SchoolClass(string observation, string name, School school) : this()
        {
            Observation = observation;
            Name = name;
            School = school;
            SchoolId = school.Id;
        }

        public string Observation { get; protected set; }
        public string Name { get; protected set; }
        public ICollection<ClassDiary> ClassDiaries { get; protected set; }
        public ICollection<Student> Students { get; protected set; }
        public Guid SchoolId { get; protected set; }
        public virtual School School { get; protected set; }

        public void AddClassDiary(ClassDiary classDiary)
        {
            ClassDiaries.Add(classDiary);
            Updated();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            Updated();
        }
    }
}
