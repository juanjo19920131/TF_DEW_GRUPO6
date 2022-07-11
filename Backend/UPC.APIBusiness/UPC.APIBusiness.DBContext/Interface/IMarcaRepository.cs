using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IMarcaRepository
    {
        EntityBaseResponse GetMarcas();
        EntityBaseResponse GetMarca(int id);
    }
}
