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
    public class cls_Musica_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_Musica()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Musica";
            obj_DAL.sSP_Name = "dbo.SP_ListarMusica";
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
        public string Insertar_Musica(ref cls_Musica_DAL Obj_Musica_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_MUSICA", SqlDbType.Int, Obj_Musica_DAL.iIdMusica);
            obj_DAL.DT_Parametros.Rows.Add("@NOMBRE", SqlDbType.VarChar, Obj_Musica_DAL.sNombre);
            obj_DAL.DT_Parametros.Rows.Add("@PRECIO", SqlDbType.Money, Obj_Musica_DAL.sPrecio);
            obj_DAL.DT_Parametros.Rows.Add("@ID_GENERO", SqlDbType.SmallInt, Obj_Musica_DAL.sGenero);
            obj_DAL.DT_Parametros.Rows.Add("@PAIS", SqlDbType.VarChar, Obj_Musica_DAL.sPais);
            obj_DAL.DT_Parametros.Rows.Add("@DISQUERA", SqlDbType.VarChar, Obj_Musica_DAL.sDisquera);
            obj_DAL.DT_Parametros.Rows.Add("@NOMBRE_DISCO", SqlDbType.VarChar, Obj_Musica_DAL.sNombre);
            obj_DAL.DT_Parametros.Rows.Add("@ANIO_PUBLICACION", SqlDbType.DateTime, Obj_Musica_DAL.dtAnioPublicacion);
            obj_DAL.DT_Parametros.Rows.Add("@NUMERO_DESCARGAS", SqlDbType.SmallInt, Obj_Musica_DAL.iNumeroDescargas);
            obj_DAL.DT_Parametros.Rows.Add("@ID_ESTADO", SqlDbType.Char, Obj_Musica_DAL.cIdEstado);

            obj_DAL.sSP_Name = "dbo.SP_InsertarMusica";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }

        public string Modificar_Musica(ref cls_Musica_DAL Obj_Musica_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@ID_MUSICA", SqlDbType.Int, Obj_Musica_DAL.iIdMusica);
            obj_DAL.DT_Parametros.Rows.Add("@NOMBRE", SqlDbType.VarChar, Obj_Musica_DAL.sNombre);
            obj_DAL.DT_Parametros.Rows.Add("@PRECIO", SqlDbType.Money, Obj_Musica_DAL.sPrecio);
            obj_DAL.DT_Parametros.Rows.Add("@ID_GENERO", SqlDbType.SmallInt, Obj_Musica_DAL.sGenero);
            obj_DAL.DT_Parametros.Rows.Add("@PAIS", SqlDbType.VarChar, Obj_Musica_DAL.sPais);
            obj_DAL.DT_Parametros.Rows.Add("@DISQUERA", SqlDbType.VarChar, Obj_Musica_DAL.sDisquera);
            obj_DAL.DT_Parametros.Rows.Add("@NOMBRE_DISCO", SqlDbType.VarChar, Obj_Musica_DAL.sNombre);
            obj_DAL.DT_Parametros.Rows.Add("@ANIO_PUBLICACION", SqlDbType.DateTime, Obj_Musica_DAL.dtAnioPublicacion);
            obj_DAL.DT_Parametros.Rows.Add("@NUMERO_DESCARGAS", SqlDbType.SmallInt, Obj_Musica_DAL.iNumeroDescargas);
            obj_DAL.DT_Parametros.Rows.Add("@ID_ESTADO", SqlDbType.Char, Obj_Musica_DAL.cIdEstado);

            obj_DAL.sSP_Name = "dbo.SP_ModificarMusica";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
