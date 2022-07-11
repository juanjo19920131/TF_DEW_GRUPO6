using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IColorRepository
    {
        EntityBaseResponse GetColores();
        EntityBaseResponse GetColoresPorModelo(string codigos);
        EntityBaseResponse GetColor(string codigo);
        
    }
}
