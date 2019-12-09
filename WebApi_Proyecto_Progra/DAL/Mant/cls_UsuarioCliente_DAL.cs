using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_UsuarioCliente_DAL
    {
        private string _sIdUsuario, _sContrasena;
        private char _cIdEstado, _cIdRol;
        private Int16 _iIdMetodoPago;
        private int _iIdPersona, _iNumTarjeta;

        #region Variables publicas

        public string sIdUsuario
        {
            get
            {
                return _sIdUsuario;
            }

            set
            {
                _sIdUsuario = value;
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

        public short iIdMetodoPago
        {
            get
            {
                return _iIdMetodoPago;
            }

            set
            {
                _iIdMetodoPago = value;
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

        public int iNumTarjeta
        {
            get
            {
                return _iNumTarjeta;
            }

            set
            {
                _iNumTarjeta = value;
            }
        }
        #endregion
    }

}
