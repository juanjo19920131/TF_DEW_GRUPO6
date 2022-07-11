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
    [Route("api/departamento")]
    public class DepartamentoController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IDepartamentoRepository __departamentoRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departamentoRepository"></param>
        public DepartamentoController(IDepartamentoRepository departamentoRepository)
        {
            __departamentoRepository = departamentoRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetDepartamentos()
        {
            var rest = __departamentoRepository.GetDepartamentos();
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
        public ActionResult GetDepartamento(string codigo)
        {
            var rest = __departamentoRepository.GetDepartamento(codigo);
            return Json(rest);
        }
    }
}
