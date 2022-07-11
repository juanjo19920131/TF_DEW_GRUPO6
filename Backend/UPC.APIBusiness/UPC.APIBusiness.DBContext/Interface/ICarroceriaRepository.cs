using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface ICarroceriaRepository
    {
        EntityBaseResponse GetCarrocerias();
        EntityBaseResponse GetCarroceria(int id);
    }
}
