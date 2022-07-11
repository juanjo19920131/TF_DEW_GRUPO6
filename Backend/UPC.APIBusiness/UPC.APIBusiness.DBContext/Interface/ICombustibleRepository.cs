using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface ICombustibleRepository
    {
        EntityBaseResponse GetCombustibles();
        EntityBaseResponse GetCombustible(int id);
    }
}
