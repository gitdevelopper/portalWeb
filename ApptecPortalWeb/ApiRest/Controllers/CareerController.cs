using ApiRest.Models;
using ApiRest.Providers;
using Business.Data;
using System.Web.Http;


namespace ApiRest.Controllers
{
    [RoutePrefix("Api/Career")]
    public class CareerController : ApiController
    {

        /// <summary>
        /// Controlador que permite crear una  carrera
        /// </summary>
        /// <param name="career"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]CareerModel career)
        {
            var consulta = CareerData.Crear(career.Clave, career.Nombre, career.InstitucionId, career.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar datos de las carreras registradas
        /// </summary>
        /// <param name="career"></param>
        /// <returns>Lista de carreras</returns>

        [HttpPost]
        [Route("Show")]
        public IHttpActionResult Show([FromBody]CareerModel career)
        {
            var consulta = CareerData.Mostrar(career.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que muestra infromación especifica de una carrera segun su id
        /// </summary>
        /// <param name="career"></param>
        /// <returns>Lista de carreras</returns>
        [HttpPost]
        [Route("ShowUpdate")]
        public IHttpActionResult ShowUpdate(CareerModel career)
        {
     
            var consulta = CareerData.MostrarActualizar(career.CareerId);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite actualizar una carrera especifica segun su id
        /// </summary>
        /// <param name="career"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Update")]
        public IHttpActionResult Update(CareerModel career)
        {
            var consulta = CareerData.Actualizar(career.CareerId, career.Clave, career.Nombre, career.InstitucionId, career.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite eliminar una carrera segun su id
        /// </summary>
        /// <param name="career"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Delete(CareerModel career)
        {
            var consulta = CareerData.Eliminar(career.CareerId);
            return Ok(consulta);
        }
    }
}
