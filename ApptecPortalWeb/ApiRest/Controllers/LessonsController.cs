﻿using ApiRest.Models;
using ApiRest.Providers;
using Business.Data;
using System.Web.Http;

namespace ApiRest.Controllers
{
    [RoutePrefix("Api/Lesson")]
    public class LessonsController : ApiController
    {
        /// <summary>
        /// Controlador que permite crear un horario
        /// </summary>
        /// <param name="lessons"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]LessonModel lessons)
        {
            var consulta = LessonData.Crear(lessons.Dia, lessons.EmpleadosId, lessons.HoraIn, lessons.HoraFin, lessons.AulaId, lessons.MateriaId, lessons.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar los horarios 
        /// </summary>
        /// <returns>Lista de horarios</returns>
        [HttpPost]
        [Route("Show")]
        public IHttpActionResult Show([FromBody]LessonModel lesson)
        {
            var consulta = LessonData.Mostrar(lesson.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar infromacion de un horari segun su id
        /// </summary>
        /// <param name="lesson"></param>
        /// <returns>Lista de tipo horario</returns>
        [HttpPost]
        [Route("ShowUpdate")]
        public IHttpActionResult ShowUpdate(LessonModel lesson)
        {
            var consulta = LessonData.MostrarActualizar(lesson.LessonId);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite determinar el dia en el que se efectua el horario
        /// </summary>
        /// <param name="lesson"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Day")]
        public IHttpActionResult Day(LessonModel lesson)
        {
            var consulta = LessonData.GetDia(lesson.Dia, lesson.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlaor que permite actualizar un horario segun su id
        /// </summary>
        /// <param name="lesson"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Update")]
        public IHttpActionResult Update(LessonModel lesson)
        {
            var consulta = LessonData.Actualizar(lesson.LessonId, lesson.Dia, lesson.EmpleadosId, lesson.HoraIn, lesson.HoraFin, lesson.AulaId, lesson.MateriaId, lesson.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite eliminar un horario
        /// </summary>
        /// <param name="lesson"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Delete(LessonModel lesson)
        {
            var consulta = LessonData.Eliminar(lesson.LessonId);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar los profesores registrados
        /// </summary>
        /// <returns>Lista de profesores</returns>
        [HttpPost]
        [Route("ShowEmployer")]
        public IHttpActionResult GetEmployer([FromBody]LessonModel lesson)
        {
            var consulta = LessonData.ObtenerEmpleado(lesson.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Conrolador que permite mostrar las aulas registradas
        /// </summary>
        /// <returns>Lista de aulas</returns>
        [HttpPost]
        [Route("ShowClassroom")]
        public IHttpActionResult GetAula([FromBody]LessonModel lesson)
        {
            var consulta = LessonData.ObtenerAula(lesson.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar las materias registradas
        /// </summary>
        /// <returns>Lista de tipo materia</returns>
        [HttpPost]
        [Route("ShowSubject")]
        public IHttpActionResult GetMateria([FromBody]LessonModel lesson)
        {
            var consulta = LessonData.ObtenerMateria(lesson.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar los grupos tegistrados
        /// </summary>
        /// <returns>Lista de grupos</returns>
        [HttpPost]
        [Route("ShowGroup")]
        public IHttpActionResult GetGrupo([FromBody]LessonModel lesson)
        {
            var consulta = LessonData.ObtenerGrupo(lesson.Users);
            return Ok(consulta);
        }
        
    }
}
