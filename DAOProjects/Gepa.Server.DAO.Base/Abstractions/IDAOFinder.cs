using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAOFinder<TEntity>
    {
        TEntity Find(long entityIDToFind);
    }
}
