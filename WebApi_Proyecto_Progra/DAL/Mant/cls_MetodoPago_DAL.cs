using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_MetodoPago_DAL
    {
        private Int16 _iIdMetodoPago, _iCVV;
        private int _iNumTarjeta;
        private string _sDescripcion;
        private DateTime _dtFechaVencimiento;

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

        public short iCVV
        {
            get
            {
                return _iCVV;
            }

            set
            {
                _iCVV = value;
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

        public DateTime dtFechaVencimiento
        {
            get
            {
                return _dtFechaVencimiento;
            }

            set
            {
                _dtFechaVencimiento = value;
            }
        }
    }
}
