﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_Proyecto_Progra.Controllers.Mant
{
    public class TransaccionController : ApiController
    {
        // GET: api/Transaccion
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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