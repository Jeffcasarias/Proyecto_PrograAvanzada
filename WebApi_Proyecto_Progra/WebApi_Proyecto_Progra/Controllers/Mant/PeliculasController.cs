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
    public class PeliculasController : ApiController
    {
        cls_Peliculas_BLL obj_BLL = new cls_Peliculas_BLL();
        cls_Peliculas_DAL obj_DAL = new cls_Peliculas_DAL();

        // GET: api/Peliculas
        public string Get()
        {
            return JsonConvert.SerializeObject(obj_BLL.Listar_Peliculas(), Formatting.Indented);
        }

        // GET: api/Peliculas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Peliculas
        public void Post(string Nombre, string Precio, string AnioEstreno, string Idiomas, string Sinopsis, string NumDescargas, string IdEstado, string IdGenero)
        {
            obj_DAL.sNombre = Nombre;
            obj_DAL.dPrecio = Convert.ToDecimal(Precio);
            obj_DAL.dtAnioEstreno = Convert.ToDateTime(AnioEstreno);
            obj_DAL.sIdiomas = Idiomas;
            obj_DAL.sSinopsis = Sinopsis;
            obj_DAL.iNumeroDescargas = Convert.ToInt16(NumDescargas);
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);
            obj_DAL.sGenero = IdGenero;

            obj_BLL.Insertar_Pelicula(ref obj_DAL);
        }

        // PUT: api/Peliculas/5
        public void Put(string IdPelicula, string Nombre, string Precio, string AnioEstreno, string Idiomas, string Sinopsis, string NumDescargas, string IdEstado, string IdGenero)
        {
            obj_DAL.iIdPelicula = Convert.ToInt16(IdPelicula);
            obj_DAL.sNombre = Nombre;
            obj_DAL.dPrecio = Convert.ToDecimal(Precio);
            obj_DAL.dtAnioEstreno = Convert.ToDateTime(AnioEstreno);
            obj_DAL.sIdiomas = Idiomas;
            obj_DAL.sSinopsis = Sinopsis;
            obj_DAL.iNumeroDescargas = Convert.ToInt16(NumDescargas);
            obj_DAL.cIdEstado = Convert.ToChar(IdEstado);
            obj_DAL.sGenero = IdGenero;

            obj_BLL.Modificar_Pelicula(ref obj_DAL);
        }

        // DELETE: api/Peliculas/5
        public void Delete(int id)
        {
        }
    }
}
