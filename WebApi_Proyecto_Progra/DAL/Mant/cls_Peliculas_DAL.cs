using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Peliculas_DAL
    {
        private int _iIdPelicula;
        private string _sNombre, _sGenero, _sIdiomas, _sSinopsis;
        private decimal _dPrecio;
        private DateTime _dtAnioEstreno;
        private Int16 _iNumeroDescargas;
        private char _cIdEstado;

        #region Variables publicas
        public int iIdPelicula
        {
            get
            {
                return _iIdPelicula;
            }

            set
            {
                _iIdPelicula = value;
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

        public string sSinopsis
        {
            get
            {
                return _sSinopsis;
            }

            set
            {
                _sSinopsis = value;
            }
        }

        public decimal dPrecio
        {
            get
            {
                return _dPrecio;
            }

            set
            {
                _dPrecio = value;
            }
        }

        public DateTime dtAnioEstreno
        {
            get
            {
                return _dtAnioEstreno;
            }

            set
            {
                _dtAnioEstreno = value;
            }
        }

        public short iNumeroDescargas
        {
            get
            {
                return _iNumeroDescargas;
            }

            set
            {
                _iNumeroDescargas = value;
            }
        }

        public char cIdEstado
        {
            get
            {
                return _cIdEstado;
            }

            set
            {
                _cIdEstado = value;
            }
        }
        #endregion
    }
}
