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
    public class MusicaController : ApiController
    {
        cls_Musica_BLL obj_BLL = new cls_Musica_BLL();

        // GET: api/Musica
        public DataTable Get()
        {
            return obj_BLL.Listar_Musica();
        }

        // GET: api/Musica/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Musica
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Musica/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Musica/5
        public void Delete(int id)
        {
        }
    }
}
