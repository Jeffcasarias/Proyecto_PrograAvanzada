using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Mant;
using DAL.Mant;
using Newtonsoft.Json;

namespace WebApi_Proyecto_Progra.Controllers.Mant
{
    public class UsuarioAdminController : ApiController
    {
        cls_UsuarioAdmin_BLL obj_BLL = new cls_UsuarioAdmin_BLL();
        cls_UsuarioAdmin_DAL obj_DAL = new cls_UsuarioAdmin_DAL();
        // GET: api/UsuarioAdmin
        public string Get()
        {
            return JsonConvert.SerializeObject(obj_BLL.Listar_UsuarioAdmin(), Formatting.Indented);
        }

        // GET: api/UsuarioAdmin/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UsuarioAdmin
        public void Post(string IdUsuario, string Contrasena, string IdEstado, string IdPersona, string IdRol)
        {
            obj_DAL.sIdAdmin = IdUsuario;
            obj_DAL.sContrasena = Contrasena;
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);
            obj_DAL.iIdPersona = Convert.ToInt32(IdPersona);
            obj_DAL.cIdRol = Convert.ToChar(IdRol);

            obj_BLL.Insertar_UsuarioAdmin(ref obj_DAL);
        }

        // PUT: api/UsuarioAdmin/5
        public void Put(string IdUsuario, string Contrasena, string IdEstado, string IdPersona, string IdRol)
        {
            obj_DAL.sIdAdmin = IdUsuario;
            obj_DAL.sContrasena = Contrasena;
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);
            obj_DAL.iIdPersona = Convert.ToInt32(IdPersona);
            obj_DAL.cIdRol = Convert.ToChar(IdRol);

            obj_BLL.Modificar_UsuarioAdmin(ref obj_DAL);
        }

        // DELETE: api/UsuarioAdmin/5
        public void Delete(int id)
        {
        }
    }
}
