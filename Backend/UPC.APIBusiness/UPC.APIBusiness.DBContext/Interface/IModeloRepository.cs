using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IModeloRepository
    {
        EntityBaseResponse GetModelos(int id);
        EntityBaseResponse GetModelo(int id);
    }
}
