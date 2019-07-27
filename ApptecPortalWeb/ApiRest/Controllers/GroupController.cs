﻿using ApiRest.Models;
using ApiRest.Providers;
using Business.Data;
using System.Web.Http;

namespace ApiRest.Controllers
{
    [RoutePrefix("Api/Group")]
    public class GroupController : ApiController
    {

        /// <summary>
        /// Controlador que permite crear un grupo
        /// </summary>
        /// <param name="group"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]GroupModel group)
        {
            var consulta = GroupData.Crear(group.Nombre, group.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrr los grupos regsitrados
        /// </summary>
        /// <returns>Lista de grupos</returns>
        [HttpPost]
        [Route("Show")]
        public IHttpActionResult Show([FromBody]GroupModel group)
        {
            var consulta = GroupData.Mostrar(group.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar datos de un grupo segun su id
        /// </summary>
        /// <param name="group"></param>
        /// <returns>Lista de tipo grupo</returns>
        [HttpPost]
        [Route("ShowUpdate")]
        public IHttpActionResult ShowUpdate([FromBody]GroupModel group)
        {
            var consulta = GroupData.MostrarUpdate(group.GroupId);

            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que pemite actualizar un grupo segun su id
        /// </summary>
        /// <param name="group"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Update")]
        public IHttpActionResult Update([FromBody]GroupModel group)
        {
            var consulta = GroupData.Actualizar(group.GroupId, group.Nombre, group.Users);

            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite eliminar un grupo segun su id
        /// </summary>
        /// <param name="group"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Delete(GroupModel group)
        {
            var consulta = GroupData.Eliminar(group.GroupId);
            return Ok(consulta);
        }

    }
}
