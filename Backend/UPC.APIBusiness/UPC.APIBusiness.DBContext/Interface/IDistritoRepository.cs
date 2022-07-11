using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IDistritoRepository
    {
        List<EntityDistrito> GetDistritos(string cod_dep, string cod_pro);
        EntityDistrito GetDistrito(string cod_dep, string cod_pro, string cod_dis);
    }
}
