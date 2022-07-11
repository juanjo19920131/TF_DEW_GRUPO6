using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface ICombustibleRepository
    {
        List<EntityCombustible> GetCombustibles();
        EntityCombustible GetCombustible(int id);
    }
}
