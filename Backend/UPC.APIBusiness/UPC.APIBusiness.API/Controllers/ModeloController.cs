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
    [Route("api/modelo")]
    public class ModeloController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IModeloRepository __modeloRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modeloRepository"></param>
        public ModeloController(IModeloRepository modeloRepository)
        {
            __modeloRepository = modeloRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetModelos(int id)
        {
            var rest = __modeloRepository.GetModelos(id);
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
        public ActionResult GetModelo(int id)
        {
            var rest = __modeloRepository.GetModelo(id);
            return Json(rest);
        }
    }
}
