using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IPaisRepository
    {
        List<EntityPais> GetPais();
        EntityPais GetPais(string CodPais);
    }
}
