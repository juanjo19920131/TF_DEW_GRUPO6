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
using API.Security;


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
        /// <param name="Usuario"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult Insert(EntityUsuario Usuario)
        {
            var rest = __usuarioRepository.Insert(Usuario);
            return Json(rest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]

        public async Task<ActionResult> Login(EntityLogin login)
        {
            var rest = __usuarioRepository.Login(login);

            if (rest.issuccess)
            {
                var loginresponse = rest.data as EntityLoginResponse;
                var usercod = loginresponse.IdUsuario.ToString();
                var userdni = loginresponse.DocumentoIdentidad;

                var token = JsonConvert.DeserializeObject<AccessToken>(
                        await new Authentication().GenerateToken(userdni, usercod)
                    ).access_token;

                loginresponse.token = token;
                rest.data = loginresponse;
            }

            return Json(rest);
        }
    }
}
