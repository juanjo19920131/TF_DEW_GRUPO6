using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IPaisRepository
    {
        List<EntityPais> GetPaises();
        EntityPais GetPais(string codigo);
    }
}
