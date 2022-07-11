﻿using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface ICarroceriaRepository
    {
        List<EntityCarroceria> GetCarrocerias();
        EntityCarroceria GetCarroceria(int id);
    }
}