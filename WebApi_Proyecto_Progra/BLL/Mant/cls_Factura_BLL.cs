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
    public class cls_Factura_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_Factura()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Factura";
            obj_DAL.sSP_Name = "dbo.SP_ListarFactura";
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
        public string Insertar_Factura(ref cls_Factura_DAL Obj_Factura_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_FACTURA", SqlDbType.Int, Obj_Factura_DAL.iIdFactura);
            obj_DAL.DT_Parametros.Rows.Add("@ID_MUSICA", SqlDbType.Int, Obj_Factura_DAL.iIdMusica);
            obj_DAL.DT_Parametros.Rows.Add("@ID_LIBRO", SqlDbType.Int, Obj_Factura_DAL.iIdLibro);
            obj_DAL.DT_Parametros.Rows.Add("@ID_PELICULA", SqlDbType.Int, Obj_Factura_DAL.iIdPelicula);
            obj_DAL.DT_Parametros.Rows.Add("@MONTO", SqlDbType.Money, Obj_Factura_DAL.dMonto);
            obj_DAL.DT_Parametros.Rows.Add("@ID_USUARIO", SqlDbType.VarChar, Obj_Factura_DAL.sIdUsuario.ToString().Trim());

            obj_DAL.sSP_Name = "dbo.SP_InsertarFactura";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }

        public string Modificar_Factura(ref cls_Factura_DAL Obj_Factura_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_FACTURA", SqlDbType.Int, Obj_Factura_DAL.iIdFactura);
            obj_DAL.DT_Parametros.Rows.Add("@ID_MUSICA", SqlDbType.Int, Obj_Factura_DAL.iIdMusica);
            obj_DAL.DT_Parametros.Rows.Add("@ID_LIBRO", SqlDbType.Int, Obj_Factura_DAL.iIdLibro);
            obj_DAL.DT_Parametros.Rows.Add("@ID_PELICULA", SqlDbType.Int, Obj_Factura_DAL.iIdPelicula);
            obj_DAL.DT_Parametros.Rows.Add("@MONTO", SqlDbType.Money, Obj_Factura_DAL.dMonto);
            obj_DAL.DT_Parametros.Rows.Add("@ID_USUARIO", SqlDbType.VarChar, Obj_Factura_DAL.sIdUsuario.ToString().Trim());

            obj_DAL.sSP_Name = "dbo.SP_ModificarFactura";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
