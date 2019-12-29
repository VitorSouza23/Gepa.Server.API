using Gepa.Service.Entity.Base.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAOFinder<TEntity> where TEntity : IGepaEntity
    {
        TEntity Find(long entityIDToFind);
    }
}
