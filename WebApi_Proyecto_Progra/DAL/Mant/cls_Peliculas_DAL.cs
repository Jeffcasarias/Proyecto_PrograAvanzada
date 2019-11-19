using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Peliculas_DAL
    {
        private string _sIdPelicula, _sNombre, _sPrecio, _sGenero, _sAnioEstreno, _sIdiomas,
            _sActores, _sArchivoDescargas, _sNumeroDescargas, _sIdConsecutivo, _sIdPrametro, _sIdEstado;

        #region Variables Publicas

        public string sActores
        {
            get
            {
                return _sActores;
            }

            set
            {
                _sActores = value;
            }
        }

        public string sAnioEstreno
        {
            get
            {
                return _sAnioEstreno;
            }

            set
            {
                _sAnioEstreno = value;
            }
        }

        public string sArchivoDescargas
        {
            get
            {
                return _sArchivoDescargas;
            }

            set
            {
                _sArchivoDescargas = value;
            }
        }

        public string sGenero
        {
            get
            {
                return _sGenero;
            }

            set
            {
                _sGenero = value;
            }
        }

        public string sIdConsecutivo
        {
            get
            {
                return _sIdConsecutivo;
            }

            set
            {
                _sIdConsecutivo = value;
            }
        }

        public string sIdEstado
        {
            get
            {
                return _sIdEstado;
            }

            set
            {
                _sIdEstado = value;
            }
        }

        public string sIdiomas
        {
            get
            {
                return _sIdiomas;
            }

            set
            {
                _sIdiomas = value;
            }
        }

        public string sIdPelicula
        {
            get
            {
                return _sIdPelicula;
            }

            set
            {
                _sIdPelicula = value;
            }
        }

        public string sIdPrametro
        {
            get
            {
                return _sIdPrametro;
            }

            set
            {
                _sIdPrametro = value;
            }
        }

        public string sNombre
        {
            get
            {
                return _sNombre;
            }

            set
            {
                _sNombre = value;
            }
        }

        public string sNumeroDescargas
        {
            get
            {
                return _sNumeroDescargas;
            }

            set
            {
                _sNumeroDescargas = value;
            }
        }

        public string sPrecio
        {
            get
            {
                return _sPrecio;
            }

            set
            {
                _sPrecio = value;
            }
        }

        #endregion
    }
}
