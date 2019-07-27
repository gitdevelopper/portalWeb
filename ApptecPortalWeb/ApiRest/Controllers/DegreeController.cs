using ApiRest.Models;
using ApiRest.Providers;
using Business.Data;
using System.Web.Http;

namespace ApiRest.Controllers
{
    [RoutePrefix("Api/Degree")]
    public class DegreeController : ApiController
    {

        /// <summary>
        /// Controlador que permite crear un grado
        /// </summary>
        /// <param name="degree"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]DegreeModel degree)
        {
            var consulta = DegreeData.Crear(degree.Nombre, degree.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que muestra los datos de un grupo segun su id
        /// </summary>
        /// <param name="degree"></param>
        /// <returns>Lista de tipo grado</returns>
        [HttpPost]
        [Route("ShowUpdate")]
        public IHttpActionResult ShowUpdate([FromBody]DegreeModel degree)
        {
            var consulta = DegreeData.MostrarUpdate(degree.DegreeId);
          
            return Ok(consulta);
        }

        /// <summary>
        /// Conrtolador que permite actualizar un grado segun su id
        /// </summary>
        /// <param name="degree"></param>
        /// <returns>estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Update")]
        public IHttpActionResult Update([FromBody]DegreeModel degree)
        {
            var consulta = DegreeData.Actualizar(degree.DegreeId, degree.Nombre, degree.Users);

            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar los grados registrados
        /// </summary>
        /// <returns>Lista de grados</returns>
        [HttpPost]
        [Route("Show")]
        public IHttpActionResult Show([FromBody] DegreeModel degree)
        {
            var consulta = DegreeData.Mostrar(degree.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite eliminar un grado segun su id
        /// </summary>
        /// <param name="degree"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Delete(DegreeModel degree)
        {
            var consulta = DegreeData.Eliminar(degree.DegreeId);
            return Ok(consulta);
        }
    }
}
