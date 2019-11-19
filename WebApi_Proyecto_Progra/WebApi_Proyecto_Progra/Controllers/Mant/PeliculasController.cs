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
    public class PeliculasController : ApiController
    {
        cls_Peliculas_BLL obj_BLL = new cls_Peliculas_BLL();

        // GET: api/Peliculas
        public DataTable Get()
        {
            return obj_BLL.Listar_Peliculas();
        }

        // GET: api/Peliculas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Peliculas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Peliculas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Peliculas/5
        public void Delete(int id)
        {
        }
    }
}
