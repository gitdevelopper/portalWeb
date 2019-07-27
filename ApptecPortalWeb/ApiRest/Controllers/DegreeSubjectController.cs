﻿using ApiRest.Models;
using ApiRest.Providers;
using Business.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiRest.Controllers
{
    [RoutePrefix("Api/DegreeSubject")]
    public class DegreeSubjectController : ApiController
    {

        /// <summary>
        /// Controlador que permite crear una asignacion de materia con grados
        /// </summary>
        /// <param name="degreeSubject"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]DegreeSubjectModel degreeSubject)
        {

            var consulta = DegreeSubjectData.Crear(degreeSubject.DegreeId, degreeSubject.SubjectId, degreeSubject.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mortrar las asignaciones registradas
        /// </summary>
        /// <returns>Lista de MateriasGrados</returns>
        [HttpPost]
        [Route("Show")]
        public IHttpActionResult Show([FromBody]DegreeSubjectModel degreeSubject)
        {
            var consulta = DegreeSubjectData.Mostrar(degreeSubject.Users);
            return Ok(consulta);
        }


        /// <summary>
        /// Controlador que permite mostrar informacion sobre una asignacion segun su id
        /// </summary>
        /// <param name="degreeSubject"></param>
        /// <returns>Lista de tipo GradoMateria</returns>
        [HttpPost]
        [Route("ShowUpdate")]
        public IHttpActionResult ShowUpdate(DegreeSubjectModel degreeSubject)
        {
            var consulta = DegreeSubjectData.MostrarActualizar(degreeSubject.DegreeSubjectId);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite actualizar una asigancion segun su id
        /// </summary>
        /// <param name="degreeSubject"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Update")]
        public IHttpActionResult Update(DegreeSubjectModel degreeSubject)
        {
            var consulta = DegreeSubjectData.Actualizar(degreeSubject.DegreeSubjectId, degreeSubject.DegreeId, degreeSubject.SubjectId, degreeSubject.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar los grados registrados
        /// </summary>
        /// <returns>Lista de grados</returns>
        [HttpPost]
        [Route("GetDegree")]
        public IHttpActionResult GetDegree([FromBody]DegreeSubjectModel degreeSubject)
        {
            var consulta = DegreeSubjectData.GetDegree(degreeSubject.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar las materias registradas
        /// </summary>
        /// <returns>Lista de materias</returns>
        [HttpPost]
        [Route("GetSubject")]
        public IHttpActionResult GetSubject([FromBody]DegreeSubjectModel degreeSubject)
        {
            var consulta = DegreeSubjectData.GetSubject(degreeSubject.Users);
            return Ok(consulta);
        }

    }
}
