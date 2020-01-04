using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Service.Entity.Base.Abstractions.ClassPlans
{
    public interface IChores : IGepaEntity
    {
        string TaskName { get; }
        bool Completed { get; }
        long ClassPlanID { get; }
    }
}
