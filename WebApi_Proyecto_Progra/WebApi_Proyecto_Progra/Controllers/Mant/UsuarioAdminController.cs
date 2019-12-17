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
