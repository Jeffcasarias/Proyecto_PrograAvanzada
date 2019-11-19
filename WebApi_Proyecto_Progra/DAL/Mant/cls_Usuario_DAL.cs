using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Usuario_DAL
    {
        private string _sIdUsuario, _sContrasena, _sPreguntaSeguridad, _sRespuestaSeguridad, _sIdRol, _sIdPersona, _sIdEstado;


        #region Variables Publicas

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

        public string sIdPersona
        {
            get
            {
                return _sIdPersona;
            }

            set
            {
                _sIdPersona = value;
            }
        }

        public string sIdRol
        {
            get
            {
                return _sIdRol;
            }

            set
            {
                _sIdRol = value;
            }
        }

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

        public string sPreguntaSeguridad
        {
            get
            {
                return _sPreguntaSeguridad;
            }

            set
            {
                _sPreguntaSeguridad = value;
            }
        }

        public string sRespuestaSeguridad
        {
            get
            {
                return _sRespuestaSeguridad;
            }

            set
            {
                _sRespuestaSeguridad = value;
            }
        }

        #endregion
    }
}
