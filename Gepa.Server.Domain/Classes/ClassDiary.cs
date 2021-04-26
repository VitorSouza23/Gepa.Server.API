using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Schools;
using Gepa.Server.Domain.Students;

namespace Gepa.Server.Domain.Classes
{
    public class ClassDiary : Entity
    {
        protected ClassDiary()
        {
            Students = new List<Student>();
        }

        public ClassDiary(DateTime initialPeriod, DateTime finalPeriod, Guid schoolClassId) : this()
        {
            InitialPeriod = initialPeriod;
            FinalPeriod = finalPeriod;
            SchoolClassId = schoolClassId;
        }

        public ClassDiary(DateTime initialPeriod, DateTime finalPeriod, SchoolClass schoolClass) : base()
        {
            InitialPeriod = initialPeriod;
            FinalPeriod = finalPeriod;
            SchoolClass = schoolClass;
            SchoolClassId = schoolClass.Id;
        }

        public DateTime InitialPeriod { get; protected set; }
        public DateTime FinalPeriod { get; protected set; }
        public ICollection<Student> Students { get; protected set; }
        public Guid SchoolClassId { get; protected set; }
        public virtual SchoolClass SchoolClass { get; protected set; }
        public bool IsItInForce(DateTime baseDate) => InitialPeriod <= baseDate && baseDate <= FinalPeriod;
        public void AddStudent(Student student) => Students.Add(student);
    }
}
