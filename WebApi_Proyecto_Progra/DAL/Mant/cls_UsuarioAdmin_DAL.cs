using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_UsuarioAdmin_DAL
    {
        private string _sIdAdmin, _sContrasena;
        private char _cIdEstado, _cIdRol;
        private int _iIdPersona;

        #region Variables publicas
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

        public string sContrasena
        {
            get
            {
                return _sContrasena;
            }

            set
            {
                _sContrasena = value;
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

        public char cIdRol
        {
            get
            {
                return _cIdRol;
            }

            set
            {
                _cIdRol = value;
            }
        }

        public int iIdPersona
        {
            get
            {
                return _iIdPersona;
            }

            set
            {
                _iIdPersona = value;
            }
        }
        #endregion
    }
}
