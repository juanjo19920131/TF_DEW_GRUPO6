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
    [Route("api/color")]
    public class ColorController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IColorRepository __colorRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="colorRepository"></param>
        public ColorController(IColorRepository colorRepository)
        {
            __colorRepository = colorRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetColores()
        {
            var rest = __colorRepository.GetColores();
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
        public ActionResult GetColor(string codigo)
        {
            var rest = __colorRepository.GetColor(codigo);
            return Json(rest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigos"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("obtenerPorModelo")]
        public ActionResult GetColoresPorModelo(string codigos)
        {
            var rest = __colorRepository.GetColoresPorModelo(codigos);
            return Json(rest);
        }
    }
}
