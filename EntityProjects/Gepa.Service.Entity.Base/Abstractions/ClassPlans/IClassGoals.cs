using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Service.Entity.Base.Abstractions.ClassPlans
{
    public interface IClassGoals : IGepaEntity
    {
        string Objective { get; }
        bool IsCompleted { get; }
        long ClassPlanID { get; }
    }
}
