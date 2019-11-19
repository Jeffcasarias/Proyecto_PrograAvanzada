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
    public class UsuarioController : ApiController
    {
        cls_Usuario_BLL obj_BLL = new cls_Usuario_BLL();

        // GET: api/Usuario
        public DataTable Get()
        {
            return obj_BLL.Listar_Usuario();
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
