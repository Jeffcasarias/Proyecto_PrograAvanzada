using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Login;

namespace WebApi_Proyecto_Progra.Controllers.Login
{
    public class LoginController : ApiController
    {
        cls_Login_BLL Obj_BLL = new cls_Login_BLL();
        string Msj = string.Empty;

        // GET: api/Login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(string id)
        {
            return "Value";
        }

        // POST: api/Login
        public string Post(string IdUser, string Contrasena)
        {
            Msj = Obj_BLL.ValidarUsuario(ref IdUser, ref Contrasena);

            if (Msj == null)
            {
                return null;
            }
            else
            {
                return Msj;
            }
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
