using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Transaccion_DAL
    {
        private int _iIdTransaccion, _iIdFactura;
        private DateTime _dtFechaTransaccion;

        public int iIdTransaccion
        {
            get
            {
                return _iIdTransaccion;
            }

            set
            {
                _iIdTransaccion = value;
            }
        }

        public int iIdFactura
        {
            get
            {
                return _iIdFactura;
            }

            set
            {
                _iIdFactura = value;
            }
        }

        public DateTime dtFechaTransaccion
        {
            get
            {
                return _dtFechaTransaccion;
            }

            set
            {
                _dtFechaTransaccion = value;
            }
        }
    }
}
