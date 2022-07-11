using DBContext;
using DBEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NSwag.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;


namespace API
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/usuario")]
    public class UsuarioController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IUsuarioRepository __usuarioRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioRepository"></param>
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            __usuarioRepository = usuarioRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetUsuarios()
        {
            var rest = __usuarioRepository.GetUsuarios();
            return Json(rest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("obtener")]
        public ActionResult GetUsuario(int id)
        {
            var rest = __usuarioRepository.GetUsuario(id);
            return Json(rest);
        }
    }
}
