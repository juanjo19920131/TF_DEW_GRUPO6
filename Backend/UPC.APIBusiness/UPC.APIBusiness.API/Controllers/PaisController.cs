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
    [Route("api/pais")]
    public class PaisController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IPaisRepository __paisRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paisRepository"></param>
        public PaisController(IPaisRepository paisRepository)
        {
            __paisRepository = paisRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetPaises()
        {
            var rest = __paisRepository.GetPaises();
            return Json(rest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("obtener")]
        public ActionResult GetPais(string codigo)
        {
            var rest = __paisRepository.GetPais(codigo);
            return Json(rest);
        }
    }
}
