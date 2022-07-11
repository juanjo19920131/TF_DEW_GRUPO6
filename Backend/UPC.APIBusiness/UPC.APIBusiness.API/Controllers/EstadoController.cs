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
    [Route("api/estado")]
    public class EstadoController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IEstadoRepository __estadoRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="estadoRepository"></param>
        public EstadoController(IEstadoRepository estadoRepository)
        {
            __estadoRepository = estadoRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetEstados()
        {
            var rest = __estadoRepository.GetEstados();
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
        public ActionResult GetEstado(int id)
        {
            var rest = __estadoRepository.GetEstado(id);
            return Json(rest);
        }
    }
}
