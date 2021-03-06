using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Gepa.Server.Domain.Teachers;
using Gepa.Server.Domain.Calendar;
using Gepa.Server.Domain.ClassPlans;
using Gepa.Server.Domain.Schools;

//Simulações com o domínio

var teacher = new Teacher(Guid.NewGuid(), "Teste", new ReadOnlyCollection<ClassPlan>(new List<ClassPlan>()),
new ReadOnlyCollection<School>(new List<School>()), new ReadOnlyCollection<SchoolCalendar>(new List<SchoolCalendar>()));

Console.WriteLine(teacher.ToString());