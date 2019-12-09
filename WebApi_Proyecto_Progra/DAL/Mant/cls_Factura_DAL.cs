using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class cls_Factura_DAL
    {
        private int _iIdFactura, _iIdMusica, _iIdLibro, _iIdPelicula;
        private decimal _dMonto;
        private string _sIdUsuario;

        #region Variables publicas
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

        public int iIdMusica
        {
            get
            {
                return _iIdMusica;
            }

            set
            {
                _iIdMusica = value;
            }
        }

        public int iIdLibro
        {
            get
            {
                return _iIdLibro;
            }

            set
            {
                _iIdLibro = value;
            }
        }

        public decimal dMonto
        {
            get
            {
                return _dMonto;
            }

            set
            {
                _dMonto = value;
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

        public int iIdPelicula
        {
            get
            {
                return _iIdPelicula;
            }

            set
            {
                _iIdPelicula = value;
            }
        }
        #endregion
    }
}