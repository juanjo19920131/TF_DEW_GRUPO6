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
    [Route("api/carroceria")]
    public class CarroceriaController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ICarroceriaRepository __carroceriaRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="carroceriaRepository"></param>
        public CarroceriaController(ICarroceriaRepository carroceriaRepository)
        {
            __carroceriaRepository = carroceriaRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public ActionResult GetCarrocerias()
        {
            var rest = __carroceriaRepository.GetCarrocerias();
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
        public ActionResult GetCarroceria(int id)
        {
            var rest = __carroceriaRepository.GetCarroceria(id);
            return Json(rest);
        }
    }
}
