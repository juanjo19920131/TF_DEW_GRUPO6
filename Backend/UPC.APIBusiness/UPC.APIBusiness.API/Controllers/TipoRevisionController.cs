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
    [Route("api/tipoRevision")]
    public class TipoRevisionController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ITipoRevisionRepository __tipoRevisionRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoRevisionRepository"></param>
        public TipoRevisionController(ITipoRevisionRepository tipoRevisionRepository)
        {
            __tipoRevisionRepository = tipoRevisionRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetTipoRevisiones()
        {
            var rest = __tipoRevisionRepository.GetTipoRevisiones();
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
        public ActionResult GetTipoRevision(int id)
        {
            var rest = __tipoRevisionRepository.GetTipoRevision(id);
            return Json(rest);
        }
    }
}
