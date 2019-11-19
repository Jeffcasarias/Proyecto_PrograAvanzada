using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Musica_DAL
    {
        private string _sIdMusica, _sNombre, _sPrecio, _sGenero, _sTipoInterpretacion,
            _sIdioma, _sPais, _sDisquera, _sNombreDisco, _sAnioPublicacion, _sArchivoDescarga, _sNumeroDescargas, _sIdConsecutivo, _sIdParametro, _sIdEstado;

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

        public string sDisquera
        {
            get
            {
                return _sDisquera;
            }

            set
            {
                _sDisquera = value;
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

        public string sIdioma
        {
            get
            {
                return _sIdioma;
            }

            set
            {
                _sIdioma = value;
            }
        }

        public string sIdMusica
        {
            get
            {
                return _sIdMusica;
            }

            set
            {
                _sIdMusica = value;
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

        public string sNombreDisco
        {
            get
            {
                return _sNombreDisco;
            }

            set
            {
                _sNombreDisco = value;
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

        public string sPais
        {
            get
            {
                return _sPais;
            }

            set
            {
                _sPais = value;
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

        public string sTipoInterpretacion
        {
            get
            {
                return _sTipoInterpretacion;
            }

            set
            {
                _sTipoInterpretacion = value;
            }
        }

        #endregion
    }
}
