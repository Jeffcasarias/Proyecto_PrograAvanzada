using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.BD;
using BLL.BD;
using DAL.Mant;

namespace BLL.Login
{
    public class cls_Login_BLL
    {
        cls_BD_BLL Obj_DB_BLL = new cls_BD_BLL();
        cls_BD_DAL Obj_DB_DAL = new cls_BD_DAL();

        public string ValidarUsuario(ref string User, ref string Password)
        {
            Obj_DB_BLL.CrearParametros(ref Obj_DB_DAL);
            Obj_DB_DAL.DT_Parametros.Rows.Add("@ID_ADMIN", SqlDbType.VarChar, User.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@CONTRASENA", SqlDbType.VarChar, Password.ToString().Trim());
            Obj_DB_DAL.sTableName = "Validar_Usuario";
            Obj_DB_DAL.sSP_Name = "dbo.SP_ValidarUsuario";

            Obj_DB_BLL.Execute_DataAdapter(ref Obj_DB_DAL);

            if (Obj_DB_DAL.Obj_DSet.Tables[0].Rows.Count > 0)
            {
                return "Login exitoso";
            }
            else
            {
                return null;
            }

        }
    }
}
