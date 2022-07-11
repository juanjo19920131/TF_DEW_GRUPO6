using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IModeloRepository
    {
        List<EntityModelo> GetModelos(int id);
        EntityModelo GetModelo(int id);
    }
}
