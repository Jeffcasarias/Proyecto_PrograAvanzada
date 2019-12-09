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
    public class cls_Transaccion_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_Bitacora()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Transaccion";
            obj_DAL.sSP_Name = "dbo.SP_ListarTransaccion";
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
        public string Insertar_Bitacora(ref cls_Transaccion_DAL Obj_Transaccion_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_TRANSACCION", SqlDbType.Int, Obj_Transaccion_DAL.iIdTransaccion.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@FECHA_TRANSACCION", SqlDbType.DateTime, Obj_Transaccion_DAL.dtFechaTransaccion.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_FACTURA", SqlDbType.Int, Obj_Transaccion_DAL.iIdFactura.ToString().Trim());
            
            obj_DAL.sSP_Name = "dbo.SP_InsertarTransaccion";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
