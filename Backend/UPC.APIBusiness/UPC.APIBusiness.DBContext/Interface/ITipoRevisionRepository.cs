using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface ITipoRevisionRepository
    {
        EntityBaseResponse GetTipoRevisiones();
        EntityBaseResponse GetTipoRevision(int id);
    }
}
