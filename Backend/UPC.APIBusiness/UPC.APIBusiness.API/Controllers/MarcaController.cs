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
    [Route("api/marca")]
    public class MarcaController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IMarcaRepository __marcaRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="marcaRepository"></param>
        public MarcaController(IMarcaRepository marcaRepository)
        {
            __marcaRepository = marcaRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetMarcas()
        {
            var rest = __marcaRepository.GetMarcas();
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
        public ActionResult GetMarca(int id)
        {
            var rest = __marcaRepository.GetMarca(id);
            return Json(rest);
        }
    }
}
