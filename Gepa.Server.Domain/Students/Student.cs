using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Classes;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Schools;

namespace Gepa.Server.Domain.Students
{
    public class Student : Entity
    {
        protected Student()
        {
            Notes = new List<StudentNote>();
            Presences = new List<StudentPresence>();
        }

        public Student(string observation, string name, Guid schoolClassId, Guid classDiaryId) : this()
        {
            Observation = observation;
            Name = name;
            SchoolClassId = schoolClassId;
            ClassDiaryId = classDiaryId;
        }

        public Student(string observation, string name, SchoolClass schoolClass, ClassDiary classDiary) : this()
        {
            Observation = observation;
            Name = name;
            SchoolClass = schoolClass;
            SchoolClassId = schoolClass.Id;
            ClassDiary = classDiary;
            ClassDiaryId = classDiary.Id;
        }

        public string Observation { get; protected set; }
        public string Name { get; protected set; }
        public ICollection<StudentNote> Notes { get; protected set; }
        public ICollection<StudentPresence> Presences { get; protected set; }
        public Guid SchoolClassId { get; protected set; }
        public virtual SchoolClass SchoolClass { get; protected set; }
        public Guid ClassDiaryId { get; protected set; }
        public virtual ClassDiary ClassDiary { get; protected set; }

        public void AddNote(StudentNote studentNote)
        {
            Notes.Add(studentNote);
            Updated();
        }
        public void AddPresence(StudentPresence studentPresence)
        {
            Presences.Add(studentPresence);
            Updated();
        }
    }
}
