using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IProvinciaRepository
    {
        EntityBaseResponse GetProvincias(string cod_dep);
        EntityBaseResponse GetProvincia(string cod_dep, string cod_pro);
    }
}
