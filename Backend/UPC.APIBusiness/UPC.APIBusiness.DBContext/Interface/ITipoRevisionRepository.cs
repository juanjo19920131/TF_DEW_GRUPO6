using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface ITipoRevisionRepository
    {
        List<EntityTipoRevision> GetTipoRevisiones();
        EntityTipoRevision GetTipoRevision(int id);
    }
}
