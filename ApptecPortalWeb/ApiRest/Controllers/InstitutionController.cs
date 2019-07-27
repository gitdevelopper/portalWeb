﻿using System.Web.Http;
using ApiRest.Models;
using ApiRest.Providers;
using Business.Data;

namespace ApiRest.Controllers
{

    [RoutePrefix("Api/Institution")]
    public class InstitutionController : ApiController
    {

        /// <summary>
        /// Controlador que permite mostrr los niveles educativos registrados
        /// </summary>
        /// <returns>Lista de niveles educativos</returns>
        [HttpPost]
        [Route("ShowEducationLevel")]
        public IHttpActionResult ShowEducationLevel()
        {
            var consulta = InstitutionData.ObtenerNivel();
            return Ok(consulta);
        }

        /// <summary>
        /// Contolador que permite mostrar las instituciones registradas
        /// </summary>
        /// <returns>Lista de instituciones</returns>
        [HttpPost]
        [Route("SHow")]
        public IHttpActionResult Show([FromBody]InstitutionsRegisterModel institutions)
        {

            var consulta = InstitutionData.Mostrar(institutions.UserCreation);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite crear un institucion
        /// </summary>
        /// <param name="inst"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]InstitutionsRegisterModel inst)
        {
            var consulta = InstitutionData.Crear(inst.Name, inst.Direction, inst.Phone, inst.EducationLevelID, inst.Director);
            return Ok(consulta);
        }

        /// <summary>
        /// Controladr que permite mostrar informacion de un institucion segun su id
        /// </summary>
        /// <param name="inst"></param>
        /// <returns>Lista de tipo institucion</returns>
        [HttpPost]
        [Route("UpdateSHow")]
        public IHttpActionResult UpdateShow([FromBody] InstitutionsRegisterModel inst)
        {
            var consulta = InstitutionData.UpdateShow(inst.InstitutionID);
            return Ok(consulta);
        }
        
        /// <summary>
        /// Controlador que permite actualizar datos de la institucion
        /// </summary>
        /// <param name="inst"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("UpdateRegister")]
        public IHttpActionResult UpdateRegister([FromBody] InstitutionsRegisterModel inst)
        {
            var consulta = InstitutionData.UpdateRegister(inst.InstitutionID, inst.Name, inst.Direction, inst.Phone, inst.EducationLevelID, inst.Logo, inst.Director, inst.UserCreation);
            return Ok(consulta);
        }

        /// <summary>
        /// Conrtolador que permite actualizar el usuario que registro la institucion
        /// </summary>
        /// <param name="inst"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("UpdateRegisterUser")]
        public IHttpActionResult UpdateRegisterUser([FromBody] InstitutionsRegisterModel inst)
        {
            var consulta = InstitutionData.UpdateRegisterUser(inst.InstitutionID, inst.UserCreation);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite eliminar una institucion segu su id
        /// </summary>
        /// <param name="inst"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Delete([FromBody]InstitutionsRegisterModel inst)
        {
            var consulta = InstitutionData.Eliminar(inst.InstitutionID);
            return Ok(consulta);
        }

    }
}
