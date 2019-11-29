using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Bitacora_DAL
    {
        private Int16 _iIdBitacora;
        private DateTime _dtFechaBitacora;
        private string _sDescripcion, _sIdAdmin;
        private char _cIdEstado;

        #region Variables publicas
        public short iIdBitacora
        {
            get
            {
                return _iIdBitacora;
            }

            set
            {
                _iIdBitacora = value;
            }
        }

        public DateTime dtFechaBitacora
        {
            get
            {
                return _dtFechaBitacora;
            }

            set
            {
                _dtFechaBitacora = value;
            }
        }

        public string sDescripcion
        {
            get
            {
                return _sDescripcion;
            }

            set
            {
                _sDescripcion = value;
            }
        }

        public string sIdAdmin
        {
            get
            {
                return _sIdAdmin;
            }

            set
            {
                _sIdAdmin = value;
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
