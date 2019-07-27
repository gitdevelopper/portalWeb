using ApiRest.Models;
using Business.Data;
using System.Web.Http;

namespace ApiRest.Controllers
{
    [RoutePrefix("Api/Classroom")]
    public class ClassroomController : ApiController
    {


        /// <summary>
        /// Controlador que permite crear un aula
        /// </summary>
        /// <param name="classroom"></param>
        /// <returns>Estado de la consulta true/false</returns>

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]ClassroomModel classroom)
        {
     
            var consulta = ClassroomData.Crear(classroom.Clave,classroom.Nombre,classroom.Descripcion,classroom.Institucion,classroom.TipoAula, classroom.Users);
            return Ok(consulta);
        }


        /// <summary>
        /// Controlador que permite mostrar las aulas registradas
        /// </summary>
        /// <param name="classroom"></param>
        /// <returns>Lista de aulas</returns>
        [HttpPost]
        [Route("Show")]
        public IHttpActionResult Show([FromBody]ClassroomModel classroom)
        {
            var consulta = ClassroomData.Mostrar(classroom.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que muestra infromación especifica de un aula segun su id
        /// </summary>
        /// <param name="classroom"></param>
        /// <returns>Lista de aulas</returns>

        [HttpPost]
        [Route("ShowUpdate")]
        public IHttpActionResult ShowUpdate(ClassroomModel classroom)
        {
            var consulta = ClassroomData.MostrarUpdate(classroom.ClassroomId);
            return Ok(consulta);
        }


        /// <summary>
        /// Controlador que permite actualizar un aula especifica segun su id
        /// </summary>
        /// <param name="classroom"></param>
        /// <returns>Estado de la consulta true/false</returns>

        [HttpPost]
        [Route("Update")]
        public IHttpActionResult Update(ClassroomModel classroom)
        {
            var consulta = ClassroomData.Atualizar(classroom.ClassroomId, classroom.Clave, classroom.Nombre, classroom.Descripcion, classroom.Institucion, classroom.TipoAula, classroom.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite eliminar un aula segun su id
        /// </summary>
        /// <param name="classroom"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Delete(ClassroomModel classroom)
        {
            var consulta = ClassroomData.Eliminar(classroom.ClassroomId);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar los tipos de aulas registrados
        /// </summary>
        /// <returns>Lista de tipo de aulas</returns>
        [HttpPost]
        [Route("ShowClassroomType")]
        public IHttpActionResult ShowClassroomType()
        {
            var consulta = ClassroomData.ObtenerAula();
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar las instituciones registradas
        /// </summary>
        /// <returns>Lista de instituciones</returns>
        [HttpPost]
        [Route("ShowInstitution")]
        public IHttpActionResult ShowInstitution([FromBody]ClassroomModel classroom)
        {
            var consulta = ClassroomData.ObtenerInstitucion(classroom.Users);
            return Ok(consulta);
        }
    }
}
