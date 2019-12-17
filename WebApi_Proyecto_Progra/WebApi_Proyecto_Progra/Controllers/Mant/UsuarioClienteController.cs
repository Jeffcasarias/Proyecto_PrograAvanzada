using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_Proyecto_Progra.Controllers.Mant
{
    public class UsuarioClienteController : ApiController
    {
        // GET: api/UsuarioCliente
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UsuarioCliente/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UsuarioCliente
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UsuarioCliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UsuarioCliente/5
        public void Delete(int id)
        {
        }
    }
}
