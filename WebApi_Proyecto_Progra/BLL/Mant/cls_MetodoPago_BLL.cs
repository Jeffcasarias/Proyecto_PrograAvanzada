using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.BD;
using BLL.BD;
using DAL.Mant;

namespace BLL.Mant
{
    public class cls_MetodoPago_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_MetodoPago()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "MetodoPago";
            obj_DAL.sSP_Name = "dbo.SP_ListarMetodoPago";
            MsjError = obj_BLL.Execute_DataAdapter(ref obj_DAL);

            if (MsjError == null)
            {
                return obj_DAL.Obj_DSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public string Insertar_MetodoPago(ref cls_MetodoPago_DAL Obj_MetodoPago_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_METODO_PAGO", SqlDbType.SmallInt, Obj_MetodoPago_DAL.iIdMetodoPago);
            obj_DAL.DT_Parametros.Rows.Add("@NUM_TARJETA", SqlDbType.Int, Obj_MetodoPago_DAL.iNumTarjeta);
            obj_DAL.DT_Parametros.Rows.Add("@CVV", SqlDbType.SmallInt, Obj_MetodoPago_DAL.iCVV);
            obj_DAL.DT_Parametros.Rows.Add("@FECHA_VENCIMIENTO", SqlDbType.DateTime, Obj_MetodoPago_DAL.dtFechaVencimiento);

            obj_DAL.sSP_Name = "dbo.SP_InsertarMetodoPago";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }

        public string Modificar_MetodoPago(ref cls_MetodoPago_DAL Obj_MetodoPago_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_METODO_PAGO", SqlDbType.SmallInt, Obj_MetodoPago_DAL.iIdMetodoPago);
            obj_DAL.DT_Parametros.Rows.Add("@NUM_TARJETA", SqlDbType.Int, Obj_MetodoPago_DAL.iNumTarjeta);
            obj_DAL.DT_Parametros.Rows.Add("@CVV", SqlDbType.SmallInt, Obj_MetodoPago_DAL.iCVV);
            obj_DAL.DT_Parametros.Rows.Add("@FECHA_VENCIMIENTO", SqlDbType.DateTime, Obj_MetodoPago_DAL.dtFechaVencimiento);

            obj_DAL.sSP_Name = "dbo.SP_ModificarMetodoPago";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
