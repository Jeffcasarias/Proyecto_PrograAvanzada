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
    public class cls_UsuarioAdmin_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_UsuarioAdmin()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Usuario Administrador";
            obj_DAL.sSP_Name = "dbo.SP_ListarAdmin";
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
        public string Insertar_UsuarioAdmin(ref cls_UsuarioAdmin_DAL Obj_UsuarioAdmin_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_ADMIN", SqlDbType.VarChar, Obj_UsuarioAdmin_DAL.sIdAdmin);
            obj_DAL.DT_Parametros.Rows.Add("@CONTRASENA", SqlDbType.VarChar, Obj_UsuarioAdmin_DAL.sContrasena);
            obj_DAL.DT_Parametros.Rows.Add("@ID_ESTADO", SqlDbType.Char, Obj_UsuarioAdmin_DAL.cIdEstado);
            obj_DAL.DT_Parametros.Rows.Add("@ID_PERSONA", SqlDbType.Int, Obj_UsuarioAdmin_DAL.iIdPersona);
            obj_DAL.DT_Parametros.Rows.Add("@ID_ROL", SqlDbType.Char, Obj_UsuarioAdmin_DAL.cIdRol);


            obj_DAL.sSP_Name = "dbo.SP_InsertarAdmin";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }

        public string Modificar_UsuarioAdmin(ref cls_UsuarioAdmin_DAL Obj_UsuarioAdmin_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_ADMIN", SqlDbType.VarChar, Obj_UsuarioAdmin_DAL.sIdAdmin);
            obj_DAL.DT_Parametros.Rows.Add("@CONTRASENA", SqlDbType.VarChar, Obj_UsuarioAdmin_DAL.sContrasena);
            obj_DAL.DT_Parametros.Rows.Add("@ID_ESTADO", SqlDbType.Char, Obj_UsuarioAdmin_DAL.cIdEstado);
            obj_DAL.DT_Parametros.Rows.Add("@ID_PERSONA", SqlDbType.Int, Obj_UsuarioAdmin_DAL.iIdPersona);
            obj_DAL.DT_Parametros.Rows.Add("@ID_ROL", SqlDbType.Char, Obj_UsuarioAdmin_DAL.cIdRol);


            obj_DAL.sSP_Name = "dbo.SP_ModificarAdmin";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
