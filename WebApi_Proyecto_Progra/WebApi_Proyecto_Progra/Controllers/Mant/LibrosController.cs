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
    public class LibrosController : ApiController
    {
        cls_Libros_BLL obj_BLL = new cls_Libros_BLL();

        // GET: api/Libros
        public DataTable Get()
        {
            return obj_BLL.Listar_Libros();
        }

        // GET: api/Libros/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Libros
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Libros/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Libros/5
        public void Delete(int id)
        {
        }
    }
}
