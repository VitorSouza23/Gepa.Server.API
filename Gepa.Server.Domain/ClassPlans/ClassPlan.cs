using System;
using System.Collections.Generic;
using Gepa.Server.Domain.Common;
using Gepa.Server.Domain.Teachers;

namespace Gepa.Server.Domain.ClassPlans
{
    public class ClassPlan : Entity
    {
        protected ClassPlan()
        {
            Chores = new List<Chores>();
            Evaluetions = new List<Evaluetion>();
            LessonContents = new List<LessonContent>();
        }

        public ClassPlan(string title, string description, Guid teacherId) : this()
        {
            Title = title;
            Description = description;
            TeacherId = teacherId;
        }

        public ClassPlan(string title, string description, Teacher teacher) : this()
        {
            Title = title;
            Description = description;
            Teacher = teacher;
            TeacherId = teacher.Id;
        }

        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public ICollection<Chores> Chores { get; protected set; }
        public ICollection<Evaluetion> Evaluetions { get; protected set; }
        public ICollection<LessonContent> LessonContents { get; protected set; }
        public Guid TeacherId { get; protected set; }
        public virtual Teacher Teacher { get; protected set; }

        public void AddChores(Chores chores)
        {
            Chores.Add(chores);
            Updated();
        }

        public void AddEvaluation(Evaluetion evaluetion)
        {
            Evaluetions.Add(evaluetion);
            Updated();
        }

        public void AddLessonContent(LessonContent lessonContent)
        {
            LessonContents.Add(lessonContent);
            Updated();
        }

    }
}
