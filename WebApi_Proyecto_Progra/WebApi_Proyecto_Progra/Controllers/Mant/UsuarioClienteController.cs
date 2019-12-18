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
    public class UsuarioClienteController : ApiController
    {
        cls_UsuarioCliente_BLL obj_BLL = new cls_UsuarioCliente_BLL();
        cls_UsuarioCliente_DAL obj_DAL = new cls_UsuarioCliente_DAL();
        // GET: api/UsuarioCliente
        public string Get()
        {
            return JsonConvert.SerializeObject(obj_BLL.Listar_UsuarioCliente(), Formatting.Indented);
        }

        // GET: api/UsuarioCliente/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UsuarioCliente
        public void Post(string IdUsuario, string Contrasena, string IdEstado, string IdMetodo, string IdPersona, string IdRol)
        {
            obj_DAL.sIdUsuario = IdUsuario;
            obj_DAL.sContrasena = Contrasena;
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);
            obj_DAL.iIdMetodoPago = Convert.ToInt16(IdMetodo);
            obj_DAL.iIdPersona = Convert.ToInt32(IdPersona);
            obj_DAL.cIdRol = Convert.ToChar(IdRol);

            obj_BLL.Insertar_UsuarioCliente(ref obj_DAL);
        }

        // PUT: api/UsuarioCliente/5
        public void Put(string IdUsuario, string Contrasena, string IdEstado, string IdMetodo, string IdPersona, string IdRol)
        {
            obj_DAL.sIdUsuario = IdUsuario;
            obj_DAL.sContrasena = Contrasena;
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);
            obj_DAL.iIdMetodoPago = Convert.ToInt16(IdMetodo);
            obj_DAL.iIdPersona = Convert.ToInt32(IdPersona);
            obj_DAL.cIdRol = Convert.ToChar(IdRol);

            obj_BLL.Insertar_UsuarioCliente(ref obj_DAL);
        }

        // DELETE: api/UsuarioCliente/5
        public void Delete(int id)
        {
        }
    }
}
