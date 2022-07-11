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
    [Route("api/distrito")]
    public class DistritoController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IDistritoRepository __distritoRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="distritoRepository"></param>
        public DistritoController(IDistritoRepository distritoRepository)
        {
            __distritoRepository = distritoRepository;
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
        [Route("listar")]
        public ActionResult GetDistritos(string cod_dep, string cod_pro)
        {
            var rest = __distritoRepository.GetDistritos(cod_dep, cod_pro);
            return Json(rest);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cod_dep"></param>
        /// <param name="cod_pro"></param>
        /// <param name="cod_dis"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("obtener")]
        public ActionResult GetDistrito(string cod_dep, string cod_pro, string cod_dis)
        {
            var rest = __distritoRepository.GetDistrito(cod_dep, cod_pro, cod_dis);
            return Json(rest);
        }
    }
}
