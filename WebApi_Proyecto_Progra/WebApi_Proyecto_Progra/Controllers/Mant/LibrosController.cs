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
    public class LibrosController : ApiController
    {
        cls_Libros_BLL obj_BLL = new cls_Libros_BLL();
        cls_Libros_DAL obj_DAL = new cls_Libros_DAL();

        // GET: api/Libros
        public string Get()
        {
            return JsonConvert.SerializeObject(obj_BLL.Listar_Libros(), Formatting.Indented);
        }

        // GET: api/Libros/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Libros
        public void Post(string Nombre, string Precio, string Autores, string Idiomas, string AnioPublicacion, string NumDescargas, string IdEstado, string IdGenero)
        {
            obj_DAL.sNombre = Nombre;
            obj_DAL.dPrecio = Convert.ToDecimal(Precio);
            obj_DAL.sAutores = Autores;
            obj_DAL.sIdiomas = Idiomas;
            obj_DAL.dtAnioPublicacion = Convert.ToDateTime(AnioPublicacion);
            obj_DAL.iNumeroDescargas = Convert.ToInt16(NumDescargas);
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);
            obj_DAL.iIdGenero = Convert.ToInt16(IdGenero);

            obj_BLL.Insertar_Libro(ref obj_DAL);

        }

        // PUT: api/Libros/5
        public void Put(string IdLibro, string Nombre, string Precio, string Autores, string Idiomas, string AnioPublicacion, string NumDescargas, string IdEstado, string IdGenero)
        {
            obj_DAL.iIdLibro = Convert.ToInt16(IdLibro);
            obj_DAL.sNombre = Nombre;
            obj_DAL.dPrecio = Convert.ToDecimal(Precio);
            obj_DAL.sAutores = Autores;
            obj_DAL.sIdiomas = Idiomas;
            obj_DAL.dtAnioPublicacion = Convert.ToDateTime(AnioPublicacion);
            obj_DAL.iNumeroDescargas = Convert.ToInt16(NumDescargas);
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);
            obj_DAL.iIdGenero = Convert.ToInt16(IdGenero);

            obj_BLL.Mdificar_Libro(ref obj_DAL);
        }

        // DELETE: api/Libros/5
        public void Delete(int id)
        {
        }
    }
}
