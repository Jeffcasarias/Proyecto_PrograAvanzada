using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_Proyecto_Progra.Controllers.Mant
{
    public class UsuarioAdminController : ApiController
    {
        // GET: api/UsuarioAdmin
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UsuarioAdmin/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UsuarioAdmin
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UsuarioAdmin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UsuarioAdmin/5
        public void Delete(int id)
        {
        }
    }
}
