﻿using System;
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
        #endregion
    }
}
