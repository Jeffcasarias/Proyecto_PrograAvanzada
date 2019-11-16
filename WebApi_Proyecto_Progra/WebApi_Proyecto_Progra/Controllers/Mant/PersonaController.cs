using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using BLL.Mant;

namespace WebApi_Proyecto_Progra.Controllers.Mant
{
    public class PersonaController : ApiController
    {
        cls_Persona_BLL obj_BLL = new cls_Persona_BLL();

        // GET: api/Persona
        public DataTable Get()
        {
            return obj_BLL.Listar_Persona();
        }

        // GET: api/Persona/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Persona
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Persona/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Persona/5
        public void Delete(int id)
        {
        }
    }
}
