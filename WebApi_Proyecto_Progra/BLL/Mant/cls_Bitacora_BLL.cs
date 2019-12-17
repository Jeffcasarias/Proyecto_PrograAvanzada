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
    public class cls_Bitacora_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_Bitacora()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Bitacora";
            obj_DAL.sSP_Name = "dbo.SP_ListarBitacora";
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
        public string Insertar_Bitacora(ref cls_Bitacora_DAL Obj_Bitacora_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_BITACORA", SqlDbType.SmallInt, Obj_Bitacora_DAL.iIdBitacora);
            obj_DAL.DT_Parametros.Rows.Add("@FECHA_BITACORA", SqlDbType.DateTime, Obj_Bitacora_DAL.dtFechaBitacora);
            obj_DAL.DT_Parametros.Rows.Add("@DESCRIPCION", SqlDbType.VarChar, Obj_Bitacora_DAL.sDescripcion.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_ADMIN", SqlDbType.VarChar, Obj_Bitacora_DAL.sIdAdmin.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_ESTADO", SqlDbType.Char, Obj_Bitacora_DAL.cIdEstado);


            obj_DAL.sSP_Name = "dbo.SP_InsertarBitacora";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
