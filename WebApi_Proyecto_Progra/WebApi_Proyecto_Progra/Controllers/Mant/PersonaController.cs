using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using BLL.Mant;
using DAL.Mant;
using Newtonsoft.Json;

namespace WebApi_Proyecto_Progra.Controllers.Mant
{
    public class PersonaController : ApiController
    {
        cls_Persona_BLL obj_BLL = new cls_Persona_BLL();
        cls_Persona_DAL obj_DAL = new cls_Persona_DAL();

        // GET: api/Persona
        public string Get()
        {
            return JsonConvert.SerializeObject(obj_BLL.Listar_Persona(), Formatting.Indented);
        }

        // GET: api/Persona/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Persona
        public void Post(string IdPersona, string Nombre, string apellidos, string correo)
        {
            obj_DAL.iIdPersona = Convert.ToInt32(IdPersona);
            obj_DAL.sNombre = Nombre;
            obj_DAL.sApellidos = apellidos;
            obj_DAL.sCorreo = correo;

            obj_BLL.Insertar_Persona(ref obj_DAL);
        }

        // PUT: api/Persona/5
        public void Put(string IdPersona, string Nombre, string apellidos, string correo)
        {
            obj_DAL.iIdPersona = Convert.ToInt32(IdPersona);
            obj_DAL.sNombre = Nombre;
            obj_DAL.sApellidos = apellidos;
            obj_DAL.sCorreo = correo;

            obj_BLL.Modificar_Persona(ref obj_DAL);
        }

        // DELETE: api/Persona/5
        public void Delete(int id)
        {
        }
    }
}
