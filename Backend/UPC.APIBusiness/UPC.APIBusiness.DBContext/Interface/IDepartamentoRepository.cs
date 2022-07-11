﻿using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IDepartamentoRepository
    {
        EntityBaseResponse GetDepartamentos();
        EntityBaseResponse GetDepartamento(string codigo);
    }
}
