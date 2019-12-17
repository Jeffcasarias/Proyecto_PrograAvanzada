using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using BLL.Mant;
using DAL.Mant;
using Newtonsoft.Json;

namespace WebApi_Proyecto_Progra.Controllers.Mant
{
    public class MusicaController : ApiController
    {
        cls_Musica_BLL obj_BLL = new cls_Musica_BLL();
        cls_Musica_DAL obj_DAL = new cls_Musica_DAL();

        // GET: api/Musica
        public string Get()
        {
            return JsonConvert.SerializeObject(obj_BLL.Listar_Musica(), Formatting.Indented);
        }

        // GET: api/Musica/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Musica
        public void Post(string Nombre, string Precio, string IdGenero, string Pais, string Disquera, string NombreDisco, string AnioPublicacion, string NumDescargas, string IdEstado)
        {
            obj_DAL.sNombre = Nombre;
            obj_DAL.sPrecio = Convert.ToDecimal(Precio);
            obj_DAL.sGenero = IdGenero;
            obj_DAL.sPais = Pais;
            obj_DAL.sDisquera = Disquera;
            obj_DAL.sNombreDisco = NombreDisco;
            obj_DAL.dtAnioPublicacion = Convert.ToDateTime(AnioPublicacion);
            obj_DAL.iNumeroDescargas = Convert.ToInt16(NumDescargas);
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);

            obj_BLL.Insertar_Musica(ref obj_DAL);
        }

        // PUT: api/Musica/5
        public void Put(string IdMusica, string Nombre, string Precio, string IdGenero, string Pais, string Disquera, string NombreDisco, string AnioPublicacion, string NumDescargas, string IdEstado)
        {
            obj_DAL.iIdMusica = Convert.ToInt16(IdMusica);
            obj_DAL.sNombre = Nombre;
            obj_DAL.sPrecio = Convert.ToDecimal(Precio);
            obj_DAL.sGenero = IdGenero;
            obj_DAL.sPais = Pais;
            obj_DAL.sDisquera = Disquera;
            obj_DAL.sNombreDisco = NombreDisco;
            obj_DAL.dtAnioPublicacion = Convert.ToDateTime(AnioPublicacion);
            obj_DAL.iNumeroDescargas = Convert.ToInt16(NumDescargas);
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);

            obj_BLL.Modificar_Musica(ref obj_DAL);
        }

        // DELETE: api/Musica/5
        public void Delete(int id)
        {
        }
    }
}
