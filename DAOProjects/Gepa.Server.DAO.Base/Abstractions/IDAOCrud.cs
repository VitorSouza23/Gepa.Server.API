using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAOCrud<TEntity> : IDAODelete<TEntity>, IDAOFinder<TEntity>, IDAOInserter<TEntity>, IDAOUpdater<TEntity>
    {
    }
}
