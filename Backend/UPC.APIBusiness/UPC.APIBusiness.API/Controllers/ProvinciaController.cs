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
    [Route("api/provincia")]
    public class ProvinciaController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IProvinciaRepository __provinciaRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="provinciaRepository"></param>
        public ProvinciaController(IProvinciaRepository provinciaRepository)
        {
            __provinciaRepository = provinciaRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cod_dep"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetProvincias(string cod_dep)
        {
            var rest = __provinciaRepository.GetProvincias(cod_dep);
            return Json(rest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cod_dep"></param>
        /// <param name="cod_pro"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("obtener")]
        public ActionResult GetProvincia(string cod_dep, string cod_pro)
        {
            var rest = __provinciaRepository.GetProvincia(cod_dep, cod_pro);
            return Json(rest);
        }
    }
}
