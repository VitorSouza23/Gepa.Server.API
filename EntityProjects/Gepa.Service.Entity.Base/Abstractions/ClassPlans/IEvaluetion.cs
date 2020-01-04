using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Service.Entity.Base.Abstractions.ClassPlans
{
    public interface IEvaluetion : IGepaEntity
    {
        string Description { get; }
        long ClassPlanID { get; }
    }
}
