using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Rol_DAL
    {
        private char _cIdRol;
        private string _sDescripcion;

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
    }
}
