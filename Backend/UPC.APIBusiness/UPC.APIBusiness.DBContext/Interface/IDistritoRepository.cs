using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IDistritoRepository
    {
        EntityBaseResponse GetDistritos(string cod_dep, string cod_pro);
        EntityBaseResponse GetDistrito(string cod_dep, string cod_pro, string cod_dis);
    }
}
