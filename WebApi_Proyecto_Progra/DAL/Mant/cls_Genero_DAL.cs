using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Genero_DAL
    {
        private Int16 _iIdGenero;
        private string _sDescripcion;

        public short iIdGenero
        {
            get
            {
                return _iIdGenero;
            }

            set
            {
                _iIdGenero = value;
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
