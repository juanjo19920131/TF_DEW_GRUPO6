using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IProvinciaRepository
    {
        List<EntityProvincia> GetProvincias(string cod_dep);
        EntityProvincia GetProvincia(string cod_dep, string cod_pro);
    }
}
