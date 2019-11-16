﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.BD
{
    public class cls_BD_DAL
    {
        private DataTable _DT_Parametros;
        private SqlConnection _Obj_Connec_DB;
        private SqlDataAdapter _Obj_DAdapter;
        private DataSet _Obj_DSet;
        private SqlCommand _Obj_Command;
        private int _iValorScalar;

        private string _sCxCadena, _sTableName, _sSP_Name, _sScalarV, _sMsjError;

        #region Variables Publicas

        public DataTable DT_Parametros
        {
            get
            {
                return _DT_Parametros;
            }

            set
            {
                _DT_Parametros = value;
            }
        }

        public SqlConnection Obj_Connec_DB
        {
            get
            {
                return _Obj_Connec_DB;
            }

            set
            {
                _Obj_Connec_DB = value;
            }
        }

        public SqlDataAdapter Obj_DAdapter
        {
            get
            {
                return _Obj_DAdapter;
            }

            set
            {
                _Obj_DAdapter = value;
            }
        }

        public DataSet Obj_DSet
        {
            get
            {
                return _Obj_DSet;
            }

            set
            {
                _Obj_DSet = value;
            }
        }

        public SqlCommand Obj_Command
        {
            get
            {
                return _Obj_Command;
            }

            set
            {
                _Obj_Command = value;
            }
        }

        public int iValorScalar
        {
            get
            {
                return _iValorScalar;
            }

            set
            {
                _iValorScalar = value;
            }
        }

        public string sCxCadena
        {
            get
            {
                return _sCxCadena;
            }

            set
            {
                _sCxCadena = value;
            }
        }

        public string sTableName
        {
            get
            {
                return _sTableName;
            }

            set
            {
                _sTableName = value;
            }
        }

        public string sSP_Name
        {
            get
            {
                return _sSP_Name;
            }

            set
            {
                _sSP_Name = value;
            }
        }

        public string sScalarV
        {
            get
            {
                return _sScalarV;
            }

            set
            {
                _sScalarV = value;
            }
        }

        public string sMsjError
        {
            get
            {
                return _sMsjError;
            }

            set
            {
                _sMsjError = value;
            }
        }
    }
}
#endregion
