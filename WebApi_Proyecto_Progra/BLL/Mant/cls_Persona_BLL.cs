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
    public class cls_Persona_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_Persona()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Persona";
            obj_DAL.sSP_Name = "dbo.SP_ListarPersona";
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

        public string Insertar_Persona(ref cls_Persona_DAL Obj_Persona_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_PERSONA", SqlDbType.Int, Obj_Persona_DAL.iIdPersona);
            obj_DAL.DT_Parametros.Rows.Add("@NOMBRE", SqlDbType.NVarChar, Obj_Persona_DAL.sNombre);
            obj_DAL.DT_Parametros.Rows.Add("@APELLIDOS", SqlDbType.NVarChar, Obj_Persona_DAL.sApellidos);
            obj_DAL.DT_Parametros.Rows.Add("@CORREO", SqlDbType.NVarChar, Obj_Persona_DAL.sCorreo);


            obj_DAL.sSP_Name = "dbo.SP_InsertarPersona";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);
                        
            return MsjError;            
        }

        public string Modificar_Persona(ref cls_Persona_DAL Obj_Persona_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_PERSONA", SqlDbType.Int, Obj_Persona_DAL.iIdPersona);
            obj_DAL.DT_Parametros.Rows.Add("@NOMBRE", SqlDbType.NVarChar, Obj_Persona_DAL.sNombre);
            obj_DAL.DT_Parametros.Rows.Add("@APELLIDOS", SqlDbType.NVarChar, Obj_Persona_DAL.sApellidos);
            obj_DAL.DT_Parametros.Rows.Add("@CORREO", SqlDbType.NVarChar, Obj_Persona_DAL.sCorreo);


            obj_DAL.sSP_Name = "dbo.SP_ModificarPersona";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
