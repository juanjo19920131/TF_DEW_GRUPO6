using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class EntityLoginResponse
    {
        public int idusuario { get; set; }
        public object IdUsuario { get; set; }
        public int idperfil { get; set; }
        public string nombres { get; set; }
        public string apellidopaterno { get; set; }
        public string apellidomaterno { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string token { get; set; }
    }
}
