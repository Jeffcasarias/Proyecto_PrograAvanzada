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
    public class cls_UsuarioCliente_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_UsuarioCliente()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Usuario Cliente";
            obj_DAL.sSP_Name = "dbo.SP_ListarUsuario";
            obj_BLL.Execute_DataAdapter(ref obj_DAL);

            if (MsjError == null)
            {
                return obj_DAL.Obj_DSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public string Insertar_UsuarioCliente(ref cls_UsuarioCliente_DAL Obj_UsuarioCliente_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_USUARIO", SqlDbType.VarChar, Obj_UsuarioCliente_DAL.sIdUsuario.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@CONTRASENA", SqlDbType.VarChar, Obj_UsuarioCliente_DAL.sContrasena.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@NUM_TARJETA", SqlDbType.Int, Obj_UsuarioCliente_DAL.iNumTarjeta.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_ESTADO", SqlDbType.Char, Obj_UsuarioCliente_DAL.cIdEstado.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_METODO_PAGO", SqlDbType.SmallInt, Obj_UsuarioCliente_DAL.iIdMetodoPago.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_PERSONA", SqlDbType.Int, Obj_UsuarioCliente_DAL.iIdPersona.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_ROL", SqlDbType.Char, Obj_UsuarioCliente_DAL.cIdRol.ToString().Trim());

            obj_DAL.sSP_Name = "dbo.SP_InsertarUsuario";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
