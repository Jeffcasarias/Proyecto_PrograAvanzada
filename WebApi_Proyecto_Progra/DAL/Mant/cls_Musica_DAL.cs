using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Musica_DAL
    {
        private int _iIdMusica;
        private string _sNombre, _sGenero, _sPais, _sDisquera, _sNombreDisco;
        private decimal _sPrecio;
        private DateTime _dtAnioPublicacion;
        private Int16 _iNumeroDescargas;
        private char _cIdEstado;

        #region Variables publicas
        public int iIdMusica
        {
            get
            {
                return _iIdMusica;
            }

            set
            {
                _iIdMusica = value;
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

        public decimal sPrecio
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
