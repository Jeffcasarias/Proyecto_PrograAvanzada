using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Persona_DAL
    {
        private string _sIdPersona, _sNombrePersona, _sApellido1, _sApellido2, _sCorreo;

        #region Variables Publicas
        public string sApellido1
        {
            get
            {
                return _sApellido1;
            }

            set
            {
                _sApellido1 = value;
            }
        }

        public string sApellido2
        {
            get
            {
                return _sApellido2;
            }

            set
            {
                _sApellido2 = value;
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

        public string sNombrePersona
        {
            get
            {
                return _sNombrePersona;
            }

            set
            {
                _sNombrePersona = value;
            }
        }
#endregion
    }
}
