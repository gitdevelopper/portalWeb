using ApiRest.Models;
using ApiRest.Providers;
using Business.Data;
using System.Web.Http;

namespace ApiRest.Controllers
{
    [RoutePrefix("Api/Subject")]
    public class SubjectController : ApiController
    {
        /// <summary>
        /// Controlador que permite crear una materia
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]SubjectModel subject)
        {
            var consulta = SubjectData.Crear(subject.Clave, subject.Nombre, subject.Creditos, subject.CarreraId, subject.EspecialidadId, subject.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar las materias registradas
        /// </summary>
        /// <returns>Lista de tipo materias</returns>
        [HttpPost]
        [Route("Show")]
        public IHttpActionResult Show([FromBody]SubjectModel subject)
        {
            var consulta = SubjectData.Mostrar(subject.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar informacion de una materia segun su id
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Lista de tipo materia</returns>
        [HttpPost]
        [Route("ShowUpdate")]
        public IHttpActionResult ShowUpdate(SubjectModel subject)
        {
            var consulta = SubjectData.MostrarActualizar(subject.SubjectId);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite actualizar una materia
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Update")]
        public IHttpActionResult Update(SubjectModel subject)
        {
            var consulta = SubjectData.Actualizar(subject.SubjectId, subject.Clave, subject.Nombre, subject.Creditos, subject.CarreraId, subject.EspecialidadId, subject.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite elimiar una materia
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Delete(SubjectModel subject)
        {
            var consulta = SubjectData.Eliminar(subject.SubjectId);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar las carerras registradas
        /// </summary>
        /// <returns>Lista tipo carrera</returns>
        [HttpPost]
        [Route("ShowCareer")]
        public IHttpActionResult ShowCareer([FromBody]SubjectModel subject)
        {
            var consulta = SubjectData.ObtenerCarrera(subject.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar las especialidades registradas
        /// </summary>
        /// <returns>Lista de tipo especialidades</returns>
        [HttpPost]
        [Route("ShowSpeciality")]
        public IHttpActionResult Showspeciality([FromBody]SubjectModel subject)
        {
            var consulta = SubjectData.ObtenerEspecialidad(subject.Users);
            return Ok(consulta);
        }

    }
}
