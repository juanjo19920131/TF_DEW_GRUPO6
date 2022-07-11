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
    [Route("api/combustible")]
    public class CombustibleController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ICombustibleRepository __combustibleRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combustibleRepository"></param>
        public CombustibleController(ICombustibleRepository combustibleRepository)
        {
            __combustibleRepository = combustibleRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetCombustibles()
        {
            var rest = __combustibleRepository.GetCombustibles();
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
        public ActionResult GetCombustible(int id)
        {
            var rest = __combustibleRepository.GetCombustible(id);
            return Json(rest);
        }
    }
}
