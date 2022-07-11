using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IPaisRepository
    {
        EntityBaseResponse GetPaises();
        EntityBaseResponse GetPais(string codigo);
    }
}
