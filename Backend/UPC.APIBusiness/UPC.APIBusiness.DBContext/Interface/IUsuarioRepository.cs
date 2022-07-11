using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IUsuarioRepository
    {
        EntityBaseResponse GetUsuarios();
        EntityBaseResponse GetUsuario(int id);
    }
}
