using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IDepartamentoRepository
    {
        List<EntityDepartamento> GetDepartamentos();
        EntityDepartamento GetDepartamento(string codigo);
    }
}
