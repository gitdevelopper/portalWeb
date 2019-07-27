﻿using ApiRest.Models;
using Business.Data;
using System.Web.Http;

namespace ApiRest.Controllers
{
    [RoutePrefix("Api/Speciality")]
    public class SpecialityController : ApiController
    {

        /// <summary>
        /// Controlador que permite crear un aespecialidad
        /// </summary>
        /// <param name="speciality"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]SpecialityModel speciality)
        {
            var consulta = SpecialityData.Crear(speciality.Nombre, speciality.InstitucionId, speciality.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar las especialidades registradas 
        /// </summary>
        /// <returns>Lista de especilidades</returns>
        [HttpPost]
        [Route("Show")]
        public IHttpActionResult Show([FromBody] SpecialityModel speciality)
        {
            var consulta = SpecialityData.Mostrar(speciality.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que muestra informacion especifica de una especialidad segun su id
        /// </summary>
        /// <param name="speciality"></param>
        /// <returns>Lista de tipo especialidad</returns>
        [HttpPost]
        [Route("ShowUpdate")]
        public IHttpActionResult ShowActualizar(SpecialityModel speciality)
        {
            var consulta = SpecialityData.MostrarUpdate(speciality.SpecialityId);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite actualizar una especialidad segun su id
        /// </summary>
        /// <param name="speciality"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Update")]
        public IHttpActionResult Update(SpecialityModel speciality)
        {

            var consulta = SpecialityData.Actualizar(speciality.SpecialityId, speciality.Nombre, speciality.InstitucionId, speciality.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite eliminar una especialidad segun su id
        /// </summary>
        /// <param name="speciality"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Delete(SpecialityModel speciality)
        {
            var consulta = SpecialityData.Eliminar(speciality.SpecialityId);
            return Ok(consulta);
        }
    }
}
