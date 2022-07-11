using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IUsuarioRepository
    {
        EntityBaseResponse Login(EntityLogin login);
        EntityBaseResponse Insert(EntityUsuario usuario);
        EntityBaseResponse GetUsuario(EntityUsuario usuario);
    }
}
