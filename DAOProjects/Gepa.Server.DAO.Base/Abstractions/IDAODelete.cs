using System;
using System.Collections.Generic;
using System.Text;

namespace Gepa.Server.DAO.Base.Abstractions
{
    public interface IDAODelete<TEntity>
    {
        bool Delete(TEntity entityToDelete);
    }
}
