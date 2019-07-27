using System.Web.Http;
using ApiRest.Models;
using Business.Data;

namespace ApiRest.Controllers
{
    [RoutePrefix("Api/Binnacle")]
    public class BinnacleController : ApiController
    {

        
        /// <summary>
        /// Controlador que permite insertar datos en la tabla bitacora
        /// </summary>
        /// <param name="binnacle"></param>
        /// <returns>Estado de la consulta true/false</returns>

        [HttpPost]
        [Route("Info")]
        public IHttpActionResult Create([FromBody]BinnacleModel binnacle)
        {            
            var consulta = BinnacleData.Recibir(binnacle.Accion, binnacle.Error, binnacle.Msj, binnacle.Users);
            return Ok(consulta);
        }

    }
}
