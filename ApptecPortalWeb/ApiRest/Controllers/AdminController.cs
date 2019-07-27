using System;
using System.Web.Http;
using Business.Data;
using ApiRest.Providers;
using System.Web;
using ApiRest.Models;

namespace ApiRest.Controllers
{
    [RoutePrefix("Api/Admin")]
    public class AdminController : ApiController
    {

        /// <summary>
        /// Controlador que permite mostrar la imagen de perfil de un usuario logeado
        /// </summary>
        /// <returns>imagen</returns>
        [HttpPost]
        [Route("file")]
        public string PosteandoMostrar()
        {
            string imagen;
            byte[] buffer;

            var request = HttpContext.Current.Request;

            if (request.Files.Count > 0)
            {
                foreach (string file in request.Files)
                {
                    var postedFile = request.Files[file];
                    int length = postedFile.ContentLength;
                    buffer = new byte[length];
                    postedFile.InputStream.Read(buffer, 0, length);
                    imagen = Convert.ToBase64String(buffer);

                    ImagenModel imagenModel = new ImagenModel(imagen);

                    return imagen;
                }
            }
            return "";
        }


        /// <summary>
        /// Controlador que permite crear un usuario en el portal
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]AdminModel admin)
        {
          
            ImagenModel imagenModel = new ImagenModel();
            var imagen = imagenModel.getIamge();

            var consulta = AdminData.Crear(admin.Name, admin.LastNameP, admin.LastNameM, admin.Users, admin.Pass, admin.InstitutionID, imagen);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar los usuarios registados en el portal
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        [HttpPost]
        [Route("Show")]
        public IHttpActionResult Show(AdminModel admin)
        {
            
            var consulta = AdminData.Mostrar(admin.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar la información del usuario en su sesión
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        [HttpPost]
        [Route("ShowUser")]
        public IHttpActionResult ShowUser(AdminModel admin)
        {

            var consulta = AdminData.MostrarUser(admin.Users);
            return Ok(consulta);
           
        }

        /// <summary>
        /// Controlador que permite obtener información de un usuario segun el id que se le mande
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>Lsta de tipo admin</returns>
        [HttpPost]
        [Route("Show2")]
        public IHttpActionResult Show2(AdminModel admin)
        {
            var consulta = AdminData.Mostrar2(admin.AdminsID);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite eliminar un usuario
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>Estado de la consulta true/false</returns>
        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Delete(AdminModel admin)
        {
            var consulta = AdminData.Eliminar(admin.AdminsID);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite obtener los datos especificos de un usuario segun su usuario y password
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>Lista de tipo admin</returns>
        [HttpPost]
        [Route("UpdateShow")]
        public IHttpActionResult UpdateShow([FromBody]AdminModel admin)
        {
            var consulta = AdminData.UpdateShow(admin.Users, admin.Pass);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite actualziar los datos de un usuario
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>Estado d ela consulta true/false</returns>
        [HttpPost]
        [Route("UpdateRegister")]
        public IHttpActionResult UpdateRegister([FromBody]AdminModel admin)
        {

            ImagenModel imagenModel = new ImagenModel();
            var imagen = imagenModel.getIamge();

            var consulta = AdminData.UpdateRegister(admin.AdminsID, admin.Name, admin.LastNameP, admin.LastNameM, imagen, admin.Users);
            return Ok(consulta);
        }

        /// <summary>
        /// Controlador que permite mostrar las instituciones educativas registradas
        /// </summary>
        /// <returns>Lista de las instituciones registradas</returns>
        [HttpPost]
        [Route("ShowInstitutions")]
        public IHttpActionResult ShowInstitutions()
        {
            var consulta = AdminData.ObtenerInstitution();
            return Ok(consulta);
        }


    }
}
