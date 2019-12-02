using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Persona_DAL
    {
        private string  _sNombre, _sApellidos, _sCorreo;
        private int _iIdPersona;

        private string Apellido2, idpersonaPrueba;//Prueba


        #region Variables pubicas

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

        public string sApellidos
        {
            get
            {
                return _sApellidos;
            }

            set
            {
                _sApellidos = value;
            }
        }

        public string sCorreo
        {
            get
            {
                return _sCorreo;
            }

            set
            {
                _sCorreo = value;
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

        public string Apellido21
        {
            get
            {
                return Apellido2;
            }

            set
            {
                Apellido2 = value;
            }
        }

        public string IdpersonaPrueba
        {
            get
            {
                return idpersonaPrueba;
            }

            set
            {
                idpersonaPrueba = value;
            }
        }
        #endregion
    }
}
