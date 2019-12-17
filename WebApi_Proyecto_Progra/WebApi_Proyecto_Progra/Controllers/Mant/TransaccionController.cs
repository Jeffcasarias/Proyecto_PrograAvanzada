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
    public class TransaccionController : ApiController
    {
        cls_Transaccion_BLL obj_BLL = new cls_Transaccion_BLL();
        cls_Transaccion_DAL obj_DAL = new cls_Transaccion_DAL();
        // GET: api/Transaccion
        public string Get()
        {
            return JsonConvert.SerializeObject(obj_BLL.Listar_Transaccion(), Formatting.Indented);
        }

        // GET: api/Transaccion/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Transaccion
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Transaccion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Transaccion/5
        public void Delete(int id)
        {
        }
    }
}
