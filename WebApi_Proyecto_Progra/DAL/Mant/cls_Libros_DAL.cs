using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Libros_DAL
    {
        private int _iIdLibro;
        private string _sNombre, _sAutores, _sIdiomas;
        private decimal _dPrecio;
        private DateTime _dtAnioPublicacion;
        private Int16 _iNumeroDescargas;
        private char _cIdEstado;

        #region Variables publicas
        public int iIdLibro
        {
            get
            {
                return _iIdLibro;
            }

            set
            {
                _iIdLibro = value;
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

        public DateTime dtAnioPublicacion
        {
            get
            {
                return _dtAnioPublicacion;
            }

            set
            {
                _dtAnioPublicacion = value;
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
