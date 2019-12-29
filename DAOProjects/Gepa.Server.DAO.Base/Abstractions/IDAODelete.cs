using Gepa.Service.Entity.Base.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAODelete<TEntity> where TEntity : IGepaEntity
    {
        bool Delete(TEntity entityToDelete);
    }
}
