using Gepa.Service.Entity.Base.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAOUpdater<TEntity> where TEntity : IGepaEntity
    {
        bool Update(TEntity entityToUpdate);
    }
}
