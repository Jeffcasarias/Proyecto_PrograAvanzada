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
    public class BitacoraController : ApiController
    {
        cls_Bitacora_BLL obj_BLL = new cls_Bitacora_BLL();
        cls_Bitacora_DAL obj_DAL = new cls_Bitacora_DAL();

        // GET: api/Bitacora
        public string Get()
        {
            return JsonConvert.SerializeObject(obj_BLL.Listar_Bitacora(), Formatting.Indented);
        }

        // GET: api/Bitacora/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Bitacora
        public void Post(string IdBitacora, string Fecha, string Descripcion, string IdAdmin, string IdEstado)
        {
            obj_DAL.iIdBitacora = Convert.ToInt16(IdBitacora);
            obj_DAL.dtFechaBitacora = Convert.ToDateTime(Fecha);
            obj_DAL.sDescripcion = Descripcion;
            obj_DAL.sIdAdmin = IdAdmin;
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);

            obj_BLL.Insertar_Bitacora(ref obj_DAL);
        }

        // PUT: api/Bitacora/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Bitacora/5
        public void Delete(int id)
        {
        }
    }
}
