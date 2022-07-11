using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IUsuarioRepository
    {
        List<EntityUsuario> GetUsuarios();
        EntityUsuario GetUsuario(int id);
    }
}
