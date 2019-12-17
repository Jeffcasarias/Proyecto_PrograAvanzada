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
    public class cls_Genero_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_Genero()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Genero";
            obj_DAL.sSP_Name = "dbo.SP_ListarGenero";
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

        public string Insertar_Genero(ref cls_Genero_DAL Obj_Genero_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_GENERO", SqlDbType.SmallInt, Obj_Genero_DAL.iIdGenero);
            obj_DAL.DT_Parametros.Rows.Add("@DESCRIPCION", SqlDbType.VarChar, Obj_Genero_DAL.sDescripcion);
            
            obj_DAL.sSP_Name = "dbo.SP_InsertarGenero";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
