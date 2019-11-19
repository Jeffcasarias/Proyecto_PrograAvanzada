using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Libros_DAL
    {
        private string _sIdLibro, _sNombre, _sPrecio, _sAutores, _sIdiomas,
            _sAnioPublicacion, _sArchivoDescarga, _sNumeroDescargas, _sIdConsecutivo, _sIdParametro, _sIdEstado;

        #region Variables Publicas

        public string sAnioPublicacion
        {
            get
            {
                return _sAnioPublicacion;
            }

            set
            {
                _sAnioPublicacion = value;
            }
        }

        public string sArchivoDescarga
        {
            get
            {
                return _sArchivoDescarga;
            }

            set
            {
                _sArchivoDescarga = value;
            }
        }

        public string sAutores
        {
            get
            {
                return _sAutores;
            }

            set
            {
                _sAutores = value;
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

        public string sIdLibro
        {
            get
            {
                return _sIdLibro;
            }

            set
            {
                _sIdLibro = value;
            }
        }

        public string sIdParametro
        {
            get
            {
                return _sIdParametro;
            }

            set
            {
                _sIdParametro = value;
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
