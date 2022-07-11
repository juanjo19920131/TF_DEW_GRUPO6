using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IColorRepository
    {
        List<EntityColor> GetColores();
        List<EntityColor> GetColoresPorModelo(string codigos);
        EntityColor GetColor(string codigo);
        
    }
}
